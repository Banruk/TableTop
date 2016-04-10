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
using TableTop.GUI.GameField;
using TableTop.GUI.Portrait_Controls;
using TableTop.GUI.CharacterForms;

namespace TableTop
{
    public partial class MainGUI : Form
    {
        public MainGUI_Controller controller;
        Portraits_Driver portrait_driver;
        public BottomSection bottomPane;
        String UserName;
        CharacterSheet character = null;
        GameField field = null;

        protected Character_Form_Driver character_driver;

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

            portrait_driver = new Portraits_Driver(is_gm);
            PortraitPane.Controls.Add(portrait_driver.GetPortraitGUI());

            // Only add if player, not GM.
            if (!is_gm)
            {
                character_driver = new Character_Form_Driver(gameMode);
                portrait_driver.AddPlayersPortrait(character_driver.getPortraitPane());
                Controls.Add(character_driver.getCharacterForm());
            }
            else
            {
                character_driver = null;
            }

            field = new GameField(this, null); // todo: fix this

            bottomPane = new BottomSection(this, server);
            controller = new MainGUI_Controller(this);

            GameGrid.Controls.Add(field);
            ChatPane.Controls.Add(bottomPane);

            bottomPane.Show();
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

            public Portraits_Driver getPortraits()
            {
                return maingui.portrait_driver; // todo: fix this
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
