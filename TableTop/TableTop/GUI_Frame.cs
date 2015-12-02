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

    public partial class GUI_Frame : Form
    {
        Panel contentPane;
        ConnectionWindow connectionForm;
        public MainGUI mainGUI;
        TableTopServer.WCF_Service.IServer_WCF_Interface server = null;

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
        }

        /// <summary>
        /// This method is used to perform the login of the server.  It sets up the WCF service.
        /// </summary>
        /// <param name="IP">The IP of the server to connect to</param>
        /// <param name="isGM">If the server is a GM or Player connection</param>
        public void Perform_Login(String userName, String IP, Boolean isGM)
        {
            var myBinding = new NetTcpBinding();
            var myEndpoint = new EndpointAddress("net.tcp://" + IP + "/Design_Time_Addresses/ServiceLibrary/Comm/");
            var myChannel = new DuplexChannelFactory<TableTopServer.WCF_Service.IServer_WCF_Interface>(new WCF_Client(this), myBinding, myEndpoint);

            server = myChannel.CreateChannel();
            server.performConnection(userName, isGM);

            Controls.Remove(connectionForm);
            connectionForm.Dispose();
            connectionForm = null;

            mainGUI = new MainGUI(server, userName);
            contentPane.Controls.Add(mainGUI);
            mainGUI.Show();

        }
    }
}
