using Character;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TableTop.GUI.CharacterForms;
using TableTop.GUI.GameField;
using TableTop.GUI.MainGUI.BottomSection;
using TableTop.GUI.Portrait_Controls;
using TableTop.WCF;
using TableTopServer.WCF_Service;

namespace TableTop.GUI.MainGUI
{
    class Main_GUI_Driver
    {

        /*
         * Controls
         */
        IServer_WCF_Interface server = null;

        private Main_GUI gui = null;
        private Main_GUI_Controller controller = null;

        private Portraits_Driver driver_portrait = null;
        private BottomSection_Driver driver_bottomPane = null;
        private Character_Form_Driver driver_character = null;
        private Game_Field field = null;

        private CharacterSheet character = null;

        /*
         *  Data
         */
        private String userName;
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

        /*
         *  Methods
         */

        public Main_GUI_Driver(IServer_WCF_Interface server, String UserName, Boolean isGm) 
        {
            // Make sure all the shit meshes well
            is_gm = isGm;
            userName = UserName;
            this.server = server;

            Build_Main_GUI();
            Build_Game_Field();
            Build_Character_Driver();
            Build_Bottom_Section();
            Buld_Portrait_Pane();
            Build_Links();
        }

        public Main_GUI getGUI()
        {
            return gui;
        }

        /// <summary>
        /// Used to build and link the Main GUI
        /// </summary>
        private void Build_Main_GUI()
        {
            gui = new Main_GUI();
            controller = new Main_GUI_Controller();
        }

        private void Buld_Portrait_Pane()
        {
            driver_portrait = new Portraits_Driver(is_gm);
            gui.AddPortraitGUI(driver_portrait.GetPortraitGUI());
            driver_portrait.GetPortraitGUI().Show();
        }

        /// <summary>
        /// Used to build and link the Game Field
        /// </summary>
        private void Build_Game_Field()
        {
            field = new Game_Field(gui, null); // todo: fix this
            gui.AddGameField(field);
        }

        /// <summary>
        /// Used to build and link the Character Form Driver
        /// </summary>
        private void Build_Character_Driver()
        {
            if (!is_gm)
            {
                driver_character = new Character_Form_Driver(gameMode);
                character = driver_character.get_CharacterSheet();
                gui.AddCharacterForm(driver_character.getCharacterForm());
            }
            else
            {
                driver_character = null;
            }
        }

        /// <summary>
        /// Used to build and link the Bottom Section
        /// Containts the chat window, GM controls, etc...
        /// </summary>
        private void Build_Bottom_Section()
        {
            driver_bottomPane = new BottomSection_Driver(is_gm);
            gui.AddBottomPane(driver_bottomPane.getGUI());
            driver_bottomPane.getGUI().Show();
        }

        private void Build_Links()
        {
            // Main GUI link to Character
            if (driver_character != null)
            {
                driver_character.get_GM_eh = get_isGM;
                driver_character.get_GameMode = get_GameMode;
            }

            // Link Main to bottom section
            driver_bottomPane.get_user_name = get_username;

            // Link bottom pane to character form
            if(driver_character != null)
            {
                driver_bottomPane.get_character_name = character.getFirstName; // NULL
                driver_portrait.AddMyPortrait(driver_character.getPortraitPane());
            }

            // Link Portraits to the server
            WCF_Client.addSomeonesPortrait = driver_portrait.addPortrait;
            WCF_Client.updateSomeonesCharacter = driver_portrait.updateCharacter;
            WCF_Client.removeSomeonesPortrait = driver_portrait.removePortrait;

            // Link the bottom section to the server
            driver_bottomPane.SendMessages_MethodLink = server.recieveChatInput;
            WCF_Client.RecieveMessage = driver_bottomPane.recieveServerMessage;
        }

        private String get_username()
        {
            return userName;
        }

        private Boolean get_isGM()
        {
            return is_gm;
        }

        private String get_GameMode(){
            return gameMode;
        }
    }
}
