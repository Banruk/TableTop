using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TableTop
{
    public partial class ConnectionWindow : Form
    {
        connection_controller connController;

        public ConnectionWindow(GUI_Frame main_window)
        {
            connController = new connection_controller(main_window, this);
            InitializeComponent();
            setUp();
        }

        private void setUp()
        {
            TopLevel = false;
            String[] selections = { "Mistborn" };
            ModeSelection.DataSource = selections;
            FormBorderStyle = FormBorderStyle.None;
            Dock = DockStyle.Fill;

            ModeSelection.Visible = false;
            modeLbl.Visible = false;

            ConnectButton.Click += connController.ConnectionButton_Click;
            isGM.CheckedChanged += connController.isGM_selected;

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        class connection_controller
        {
            ConnectionWindow connWindow;
            GUI_Frame mainWindow;

            public connection_controller(GUI_Frame main_window, ConnectionWindow window)
            {
                mainWindow = main_window;
                connWindow = window;
            } // End connection_controller

            public void ConnectionButton_Click(object sender, EventArgs e)
            {
                String reg = "([1]{0,1}[0-9]{0,1}[0-9]|[2][0-4][0-9]|[2][5][0-5])";
                reg = "^" + reg + "[.]" + reg + "[.]" + reg + "[.]" + reg + "[:][0-9]{1,5}$";

                if (Regex.IsMatch(connWindow.ServerIP.Text.Trim(), reg))
                {
                    mainWindow.Perform_Login(connWindow.ServerIP.Text, connWindow.isGM.Checked);
                }
                else
                {
                    connWindow.ServerIP.BackColor = Color.Red;
                    ToolTip tip = new ToolTip();
                    tip.SetToolTip(connWindow.ServerIP, "Invalid IP, must be in the form of: XXX.XXX.XXX.XXX:XXXX");
                }


            } // End ConnectionButton_Click

            public void isGM_selected(object sender, EventArgs e)
            {
                if (connWindow.isGM.Checked)
                {
                    connWindow.ModeSelection.Visible = true;
                    connWindow.modeLbl.Visible = true;
                }
                else
                {
                    connWindow.ModeSelection.Visible = false;
                    connWindow.modeLbl.Visible = false;
                }
            } // End isGM_selected
        } // End class connection_controller
    }
}
