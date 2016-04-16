namespace TableTop.GUI
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
        public Panel contentPane;
        /// <summary>
        /// The game window
        /// </summary>
        public Main_GUI mainGUI;

        public GUI_Frame()
        {
            SuspendLayout();
            InitializeComponent();

            contentPane = new Panel();
            //connectionForm = new ConnectionWindow(this);
            contentPane.Location = new System.Drawing.Point(0, 0);

            Name = "Main_Window_Frame";
            Text = "Game Client";
            ShowIcon = false;
            contentPane.Dock = DockStyle.Fill;

            Controls.Add(contentPane);

            //contentPane.Controls.Add(connectionForm);

            contentPane.Show();
            //connectionForm.Show();
            ResumeLayout(false);
            this.FormClosed += closeWindow;
        }

        /// <summary>
        /// Makes sure the server knows we're logging out when we close the window.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void closeWindow(object sender, EventArgs e)
        {
            try // todo: fix this
            {
                GUI_Frame_Driver.server.connectionClose(client_id); //todo: decouple
            }
            catch (Exception ex)
            {

            }
        }
    }
}
