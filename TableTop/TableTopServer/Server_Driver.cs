namespace TableTopServer
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.ServiceModel;
    using System.ServiceModel.Description;
    using System.Text;
    using System.Threading.Tasks;
    using TableTopServer.WCF_Service;


    public class Server_Driver
    {
        List<ClientConnection> clients;
        public Client_WCF_Interface gm_connection = null;
        ServiceHost myHost = null;
        Server_WCF_Interface wcf_server;
        public String gameMode
        {
            get;
            set;
        }

        /*****************************************************
         * 
         * Initialization Methods
         * 
         *****************************************************/

        Server_Driver()
        {
            clients = new List<ClientConnection>();
        }

        /// <summary>
        /// Used for all initialization and causes the server to go into wait mode.
        /// </summary>
        public void Run()
        {

            Setup_WCF();

            while (true)
                Console.ReadKey();

        } // End Run

        /// <summary>
        /// Used to set up the WCF service.  Initalizes the service listener
        /// </summary>
        public void Setup_WCF()
        {
            Uri baseAddress = new Uri("net.tcp://localhost:8733/Design_Time_Addresses/ServiceLibrary/Comm/");

            wcf_server = new Server_WCF_Interface(this);
            myHost = new ServiceHost(wcf_server, baseAddress); //Give our instance of Comm to ServiceHost
            myHost.AddServiceEndpoint(typeof(IServer_WCF_Interface), new NetTcpBinding(), "");
            myHost.Description.Behaviors.Find<ServiceBehaviorAttribute>().IncludeExceptionDetailInFaults = true;
            myHost.Description.Behaviors.Find<ServiceBehaviorAttribute>().ConcurrencyMode = ConcurrencyMode.Multiple;

            myHost.Description.Behaviors.Remove(typeof(ServiceDebugBehavior));
            myHost.Description.Behaviors.Add(new ServiceDebugBehavior { IncludeExceptionDetailInFaults = true });

            var derp = myHost.Description.Behaviors.Find<ServiceBehaviorAttribute>();
            derp.InstanceContextMode = InstanceContextMode.Single; // Allows us to go into Singleton mode, which lets us to use Duplex Mode of WCF

            myHost.Open();
        } // End Setup_WCF

        /// <summary>
        /// Used to add another client connection to the server
        /// </summary>
        /// <param FirstName="client"></param>
        public ClientConnection AddClient(Client_WCF_Interface client)
        {
            ClientConnection new_client = new ClientConnection(client);
            clients.Add(new_client);
            return new_client;
        } // End AddClient

        /*****************************************************
         * 
         * Access Methods
         * 
         *****************************************************/

        /// <summary>
        /// Used to get the list of connected clients for use by the WCF service
        /// </summary>
        /// <returns>List of active client connections</returns>
        public List<ClientConnection> getClientList()
        {
            return clients;
        }

        /*****************************************************
         * 
         * Static Methods
         * 
         *****************************************************/
        static void Main(string[] args)
        {
            Server_Driver driver = new Server_Driver();

            driver.Run();
            
        }
    }
}
