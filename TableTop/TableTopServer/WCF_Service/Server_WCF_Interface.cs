using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;
using System.Threading;
using System.Drawing;
using Character;
using Shared_Resources;

namespace TableTopServer.WCF_Service
{
    [ServiceBehavior(InstanceContextMode = InstanceContextMode.PerSession)]
    public class Server_WCF_Interface : IServer_WCF_Interface
    {
        Server_Driver server;
        Mutex connectionMutex;

        public Server_WCF_Interface(Server_Driver driver)
        {
            server = driver;
            connectionMutex = new Mutex();
            
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param FirstName="userName"></param>
        /// <param FirstName="isGM"></param>
        /// <returns></returns>
        public int performConnection(String userName, Boolean isGM, ref String gameMode)
        {
            ClientConnection new_client;
            connectionMutex.WaitOne();
            try
            {
                if (isGM)
                {
                    server.gm_connection = Callback;
                    server.gameMode = gameMode;
                    return 0;
                }

                if (server.gm_connection == null)
                {
                    return -1;
                }

                new_client = server.AddClient(Callback);
                server.gm_connection.newUserLoggedIn(new_client.client_id, userName);
                foreach (ClientConnection client in server.getClientList())
                {
                    if (client.client_id != new_client.client_id)
                    {
                        client.getConnection().newUserLoggedIn(new_client.client_id, userName);
                    }
                }
            }
            finally
            {
                connectionMutex.ReleaseMutex();
            }

            gameMode = server.gameMode;

            return new_client.client_id;
        } // End performConnection

        public void getCurrentlyConnectedPlayers(int client_id)
        {
            foreach (ClientConnection client in server.getClientList())
            {
                if (client.client_id != client_id)
                {
                    Callback.loadLoggedInUsers(client.client_id, client.characterSheet);

                }
            }
        }

        /// <summary>
        /// Used to send chat messages to all connected clients.
        /// </summary>
        /// <param FirstName="chatType">The type of the chat message (In Game, Out Of Game, Action, System)</param>
        /// <param FirstName="message">The message to be sent to the clients</param>
        public void recieveChatInput(String chatType, String message)
        {
            // todo: set up story logger 
            foreach (ClientConnection client in server.getClientList())
            {
                client.getConnection().recieveChatInput(chatType, message);
            }
        } // End recieveChatInput

        public void updateUserProfile(int client_id, CharacterSheet characterSheet)
        {
            server.gm_connection.updateUserProfile(client_id, characterSheet);
            foreach (ClientConnection client in server.getClientList())
            {
                if (client.client_id != client_id)
                {
                    client.getConnection().updateUserProfile(client_id, characterSheet); // todo: fix to pass character sheet
                }
                else
                {
                    client.characterSheet = characterSheet;
                }
            }
        } // End updateUserProfile

        /// <summary>
        /// 
        /// </summary>
        /// <param FirstName="client_number"></param>
        public void connectionClose(int client_number)
        {
            connectionMutex.WaitOne();
            try
            {
                ClientConnection to_remove = null;

                if (server.gm_connection != null)
                {
                    server.gm_connection.clientDisconnected(client_number);
                }

                if (client_number == 0)
                {
                    server.gm_connection = null;
                    return;
                }

                foreach (ClientConnection client in server.getClientList())
                {
                    if (client.client_id == client_number)
                    {
                        to_remove = client;
                    }
                    else
                    {
                        client.getConnection().clientDisconnected(client_number);
                    }
                }
                server.getClientList().Remove(to_remove);
            }
            finally
            {
                connectionMutex.ReleaseMutex();
            }
        } // End connectionClose

        public Client_WCF_Interface Callback
        {
            get
            {
                return OperationContext.Current.GetCallbackChannel<Client_WCF_Interface>();
            }
        } // End Callback
    }
}
