namespace TableTop
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Data;
    using System.Drawing;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.Windows.Forms;
    using System.ServiceModel;
    using TableTop.WCF;
    using TableTopServer.WCF_Service;
    using Shared_Resources;

    public partial class GUI_Frame : Form
    {
        /// <summary>
        /// The current connection ID for reference in communication between the server and the clients
        /// </summary>
        public static int client_id
        {
            get;
            private set;
        }
        /// <summary>
        /// Houses any current GUI data
        /// </summary>
        Panel contentPane;
        /// <summary>
        /// The login page
        /// </summary>
        ConnectionWindow connectionForm;
        /// <summary>
        /// The game window
        /// </summary>
        public MainGUI mainGUI;

        public static IServer_WCF_Interface server
        {
            get;
            private set;
        }

        public GUI_Frame()
        {
            SuspendLayout();
            InitializeComponent();

            contentPane = new Panel();
            connectionForm = new ConnectionWindow(this);
            contentPane.Location = new System.Drawing.Point(0, 0);

            Name = "Main_Window_Frame";
            Text = "Game Client";
            ShowIcon = false;
            contentPane.Dock = DockStyle.Fill;

            Controls.Add(contentPane);

            contentPane.Controls.Add(connectionForm);

            contentPane.Show();
            connectionForm.Show();
            ResumeLayout(false);
            this.FormClosed += closeWindow;
        }

        /// <summary>
        /// This method is used to perform the login of the server.  It sets up the WCF service.
        /// </summary>
        /// <param FirstName="IP">The IP of the server to connect to</param>
        /// <param FirstName="isGM">If the server is a GM or Player connection</param>
        public void Perform_Login(String userName, String IP, Boolean isGM, String gameMode)
        {
            var myBinding = new NetTcpBinding();
            var myEndpoint = new EndpointAddress("net.tcp://" + IP + "/Design_Time_Addresses/ServiceLibrary/Comm/");
            var myChannel = new DuplexChannelFactory<IServer_WCF_Interface>(new WCF_Client(this), myBinding, myEndpoint);

            try
            {
                server = myChannel.CreateChannel();

                client_id = server.performConnection(userName, isGM, ref gameMode);
            }
            catch (Exception e)
            {
                connectionForm.errorLbl.Text = "Exception occured: " + e.Message;
                return;
            }

            if (client_id == -1)
            {
                connectionForm.errorLbl.Text = "No GM is present, cannot connect.";
                return;
            }

            MainGUI.gameMode = gameMode;
            mainGUI = new MainGUI(server, userName, isGM);

            Controls.Remove(connectionForm);
            connectionForm.Dispose();
            connectionForm = null;

            server.getCurrentlyConnectedPlayers(client_id);

            contentPane.Controls.Add(mainGUI);
            mainGUI.Show();


        }

        public void closeWindow(object sender, EventArgs e)
        {
            server.connectionClose(client_id);
        }
    }
}
