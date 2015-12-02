using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TableTop.GUI;
using TableTopServer.WCF_Service;

namespace TableTop
{
    public partial class MainGUI : Form
    {
        Portraits portraitPane;
        public BottomSection bottomPane;
        String UserName;
        MainGUI_Controller controller;

        public MainGUI(IServer_WCF_Interface server, String UserName)
        {
            InitializeComponent();
            setUp(server);
            this.UserName = UserName;
        }

        private void setUp(IServer_WCF_Interface server)
        {
            TopLevel = false;
            FormBorderStyle = FormBorderStyle.None;
            Dock = DockStyle.Fill;

            portraitPane = new Portraits();
            bottomPane = new BottomSection(server);

            controller = new MainGUI_Controller(this);

            ChatPane.Controls.Add(bottomPane);
            PortraitPane.Controls.Add(portraitPane);

            bottomPane.Show();
            portraitPane.Show();
            portraitPane.addPortrait();
            portraitPane.addPortrait();
            portraitPane.addPortrait();
            portraitPane.addPortrait();
            portraitPane.addPortrait();
            portraitPane.addPortrait();
        }

        public class MainGUI_Controller
        {
            MainGUI maingui;

            public MainGUI_Controller(MainGUI gui)
            {
                maingui = gui;
            }

            public String getUserName()
            {
                return maingui.UserName;
            }
        }
    }
}
