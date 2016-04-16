namespace TableTop.GUI
{
    using Shared_Resources;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.ServiceModel;
    using System.Text;
    using System.Threading.Tasks;
    using System.Windows.Forms;
    using TableTop.GUI.LoginScreen;
    using TableTop.GUI.MainGUI;
    using TableTop.WCF;
    using TableTopServer.WCF_Service;

    class GUI_Frame_Driver
    {
        GUI_Frame frame;
        GUI_Frame_Controller controller;
        Form current_form;

        int client_id;

        public static IServer_WCF_Interface server
        {
            get;
            private set;
        }

        /// <summary>
        /// Blah blah construct driver to the Main Frame for the game
        /// </summary>
        public GUI_Frame_Driver()
        {
            frame = new GUI_Frame();
            controller = new GUI_Frame_Controller();
            client_id = 0;

            // Frame starts with the login screen
            LoginScreen_GUI window = new LoginScreen_GUI(Perform_Login);

            current_form = window;
            // link Perform_Login to window
            frame.contentPane.Controls.Add(current_form);
            current_form.Show();
            
        }

        /// <summary>
        /// Used to retrieve the GUI from this driver
        /// </summary>
        /// <returns>This frame for spawning</returns>
        public GUI_Frame getFrame()
        {
            return frame;
        }

        /// <summary>
        /// Attempts to create a connection to the server.  If successful, it destroys the login_screen, and spawns the mainGUI.
        /// </summary>
        /// <param name="userName"></param>
        /// <param name="IP"></param>
        /// <param name="isGM"></param>
        /// <param name="gameMode"></param>
        /// <param name="error_reporting">Method of reporting an error (the GUI's error message label's text in this case)</param>
        public void Perform_Login(String userName, String IP, Boolean isGM, String gameMode, takes_string error_reporting)
        {
            var myBinding = new NetTcpBinding();
            var myEndpoint = new EndpointAddress("net.tcp://" + IP + "/Design_Time_Addresses/ServiceLibrary/Comm/");
            var myChannel = new DuplexChannelFactory<IServer_WCF_Interface>(new WCF_Client(), myBinding, myEndpoint); // todo: decouple frame from WCF

            try
            {
                server = myChannel.CreateChannel();

                client_id = server.performConnection(userName, isGM, ref gameMode);
            }
            catch (Exception e)
            {
                error_reporting("Exception occured: " + e.Message);
                return ;
            }

            if (client_id == -1)
            {
                error_reporting("No GM is present, cannot connect.");
                return ;
            }

            Main_GUI_Driver main_driver = new Main_GUI_Driver(server, userName, gameMode, isGM);

            //Main_GUI mainGUI = new Main_GUI(server, userName, isGM);

            // Replace login window with the main gui
            frame.contentPane.Controls.Remove(current_form);
            frame.contentPane.Controls.Add(main_driver.getGUI());

            current_form.Dispose();
            current_form = null;

            current_form = main_driver.getGUI();

            server.getCurrentlyConnectedPlayers(client_id);

            main_driver.getGUI().Show();
        }

    }
}
