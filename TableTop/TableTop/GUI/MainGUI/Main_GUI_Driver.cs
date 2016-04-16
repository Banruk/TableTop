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
         * UI Drivers
         */

        // Main components of this driver
        private Main_GUI gui = null;
        private Main_GUI_Controller controller = null;

        // Various UI Components
        private Portraits_Driver driver_portrait = null;
        private BottomSection_Driver driver_bottomPane = null;
        private Character_Form_Driver driver_character = null;
        private Game_Field field = null;

        // Connection to the server
        IServer_WCF_Interface server = null;

        /*
         *  Data
         */

        /// <summary>
        /// The current logged in user's Character Sheet.  Null if the user is the Game Master
        /// </summary>
        private CharacterSheet character = null;
        private String userName;
        private String gameMode;
        private Boolean is_gm;

        /*
         *  Methods
         */

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="server">Reference to the game server</param>
        /// <param name="UserName">The logged in user's name</param>
        /// <param name="gameMode">The current game mode</param>
        /// <param name="isGm">Is this player the Game Master</param>
        public Main_GUI_Driver(IServer_WCF_Interface server, String UserName, String gameMode, Boolean isGm) 
        {
            // Make sure all the shit meshes well
            is_gm = isGm;
            userName = UserName;
            this.server = server;
            this.gameMode = gameMode;

            Construct_Main_GUI();
            Construct_Game_Field();
            Construct_Character_Driver();
            Construct_Bottom_Section();
            Construct_Portrait_Pane();
            Link_Control_Drivers();
        }

        /// <summary>
        /// Used to add this UI to your frame (or another panel)
        /// </summary>
        /// <returns>A reference to the GUI built and controlled by this driver</returns>
        public Main_GUI getGUI()
        {
            return gui;
        }

        /// <summary>
        /// Used to contruct the main control containing all the UI elements
        /// </summary>
        private void Construct_Main_GUI()
        {
            gui = new Main_GUI();
            controller = new Main_GUI_Controller();
        }

        /// <summary>
        /// Used to build the player portrait's panel
        /// </summary>
        private void Construct_Portrait_Pane()
        {
            driver_portrait = new Portraits_Driver(is_gm);
            gui.AddPortraitGUI(driver_portrait.GetPortraitGUI());
            driver_portrait.GetPortraitGUI().Show();
        }

        /// <summary>
        /// Used to build the Game Field
        /// </summary>
        private void Construct_Game_Field()
        {
            field = new Game_Field(gui, null); // todo: fix this
            gui.AddGameField(field);
        }

        /// <summary>
        /// Used to build the Character Form Driver
        /// </summary>
        private void Construct_Character_Driver()
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
        /// Used to build the Bottom Section
        /// Containts the chat window, GM controls, etc...
        /// </summary>
        private void Construct_Bottom_Section()
        {
            driver_bottomPane = new BottomSection_Driver(is_gm);
            gui.AddBottomPane(driver_bottomPane.getGUI());
            driver_bottomPane.getGUI().Show();
        }

        /// <summary>
        /// Links all the GUI's control's delegates and methods together.
        /// </summary>
        private void Link_Control_Drivers()
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

        /// <summary>
        /// Delegates link to this method to get the logged in user's name.
        /// </summary>
        /// <returns>The logged in user's name</returns>
        private String get_username()
        {
            return userName;
        }

        /// <summary>
        /// Delegates link to this method to get if the current user is the Game Master
        /// </summary>
        /// <returns>Boolean stating if the player is a GM or not</returns>
        private Boolean get_isGM()
        {
            return is_gm;
        }

        /// <summary>
        /// Delegates link to this method to get the current game mode
        /// </summary>
        /// <returns>A string containing the current game mode</returns>
        private String get_GameMode(){
            return gameMode;
        }
    }
}
