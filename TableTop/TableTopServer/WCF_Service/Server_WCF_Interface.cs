using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;

namespace TableTopServer.WCF_Service
{
    [ServiceBehavior(InstanceContextMode = InstanceContextMode.PerSession)]
    public class Server_WCF_Interface : IServer_WCF_Interface
    {
        Server_Driver server;

        public Server_WCF_Interface(Server_Driver driver)
        {
            server = driver;
            
        }

        public string GetData(int value)
        {
            return string.Format("You entered: {0}", value);
        }

        public void performConnection(String userName, Boolean isGM)
        {
            server.AddClient(Callback);
        }

        public void recieveChatInput(String chatType, String message)
        {
            // todo: set up story logger 
            foreach (Client_WCF_Interface client in server.getClientList())
            {
                client.recieveChatInput(chatType, message);
            }
        }

        public Client_WCF_Interface Callback
        {
            get
            {
                return OperationContext.Current.GetCallbackChannel<Client_WCF_Interface>();
            }
        }
    }
}
