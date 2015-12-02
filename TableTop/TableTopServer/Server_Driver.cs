namespace TableTopServer
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.ServiceModel;
    using System.Text;
    using System.Threading.Tasks;
    using TableTopServer.WCF_Service;


    public class Server_Driver
    {
        List<Client_WCF_Interface> clients;
        ServiceHost myHost = null;
        Server_WCF_Interface wcf_server;

        /*****************************************************
         * 
         * Initialization Methods
         * 
         *****************************************************/

        Server_Driver()
        {
            clients = new List<Client_WCF_Interface>();
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

            var derp = myHost.Description.Behaviors.Find<ServiceBehaviorAttribute>();
            derp.InstanceContextMode = InstanceContextMode.Single; // Allows us to go into Singleton mode, which lets us to use Duplex Mode of WCF

            myHost.Open();
        } // End Setup_WCF

        /// <summary>
        /// Used to add another client connection to the server
        /// </summary>
        /// <param name="client"></param>
        public void AddClient(Client_WCF_Interface client)
        {
            clients.Add(client);
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
        public List<Client_WCF_Interface> getClientList()
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
