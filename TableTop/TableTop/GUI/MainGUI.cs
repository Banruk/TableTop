using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Character;
using TableTop.GUI;
using TableTopServer.WCF_Service;
using TableTop.GUI.Portrait_Controls.PortraitExtensions;
using TableTop.GUI.GameField;

namespace TableTop
{
    public partial class MainGUI : Form
    {
        public MainGUI_Controller controller;
        Portraits portraitPane;
        public BottomSection bottomPane;
        String UserName;
        CharacterSheet character = null;
        GameField field = null;

        public static Boolean is_gm
        {
            get;
            private set;
        }
        public static String gameMode
        {
            get;
            set;
        }

        public MainGUI(IServer_WCF_Interface server, String UserName, Boolean is_gm)
        {
            InitializeComponent();
            this.UserName = UserName;
            MainGUI.is_gm = is_gm;
            setUp(server);
        }

        private void setUp(IServer_WCF_Interface server)
        {
            TopLevel = false;
            FormBorderStyle = FormBorderStyle.None;
            Dock = DockStyle.Fill;

            if (is_gm)
            {
                portraitPane = new GMPortraits(this);
                field = new GameField(this, null);
            }
            else
            {
                portraitPane = new PlayerPortraits(this);
                field = new GameField(this, null); // todo: get player
            }

            bottomPane = new BottomSection(this, server);
            controller = new MainGUI_Controller(this);

            GameGrid.Controls.Add(field);
            ChatPane.Controls.Add(bottomPane);
            PortraitPane.Controls.Add(portraitPane);

            bottomPane.Show();
            portraitPane.Show();
            field.Show();
        }

        public MainGUI_Controller getController()
        {
            return controller;
        }

        public class MainGUI_Controller
        {
            MainGUI maingui;

            public MainGUI_Controller(MainGUI gui)
            {
                maingui = gui;
            }

            public TableTop.GUI.Portraits.Portraits_Controller getPortraits()
            {
                return maingui.portraitPane.getController();
            }

            public String getUserName()
            {
                return maingui.UserName;
            }

            public String getCharacterName()
            {
                if(maingui.character != null)
                    return maingui.character.FirstName;
                else
                    return null;
            }
        }
    }
}
