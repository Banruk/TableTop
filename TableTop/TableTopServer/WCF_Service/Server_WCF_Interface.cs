using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;
using System.Threading;
using System.Drawing;

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
        public int performConnection(String userName, Boolean isGM)
        {
            ClientConnection new_client;
            connectionMutex.WaitOne();
            try
            {
                new_client = server.AddClient(Callback);
                foreach (ClientConnection client in server.getClientList())
                {
                    if (client.client_id != new_client.client_id)
                    {
                        client.getConnection().newUserLoggedIn(new_client.client_id, userName);
                        new_client.getConnection().loadLoggedInUsers(client.client_id, client.portrait);
                    }
                }
            }
            finally
            {
                connectionMutex.ReleaseMutex();
            }

            return new_client.client_id;
        } // End performConnection

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

        /// <summary>
        /// Method used to update a client's user portrait to all other clients
        /// </summary>
        /// <param name="client_id">The ID of the client updating their portrait</param>
        /// <param name="portrait">The portrait to update to</param>
        public void updateUserProfile(int client_id, byte[] portrait)
        {
            foreach (ClientConnection client in server.getClientList())
            {
                if (client.client_id != client_id)
                {
                    client.getConnection().updateUserProfile(client_id, portrait);
                }
                else
                {
                    client.portrait = portrait;
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
