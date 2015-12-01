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

        Server_Driver()
        {
            clients = new List<Client_WCF_Interface>();
        }

        public void Run()
        {

            Setup_WCF();

            while (true)
                Console.ReadKey();

        } // End Run

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

        public void AddClient(Client_WCF_Interface client)
        {
            clients.Add(client);
        } // End AddClient


        static void Main(string[] args)
        {
            Server_Driver driver = new Server_Driver();

            driver.Run();
            
        }
    }
}
