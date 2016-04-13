using Shared_Resources;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TableTopServer.WCF_Service;

namespace TableTop.GUI.MainGUI.BottomSection
{
    class BottomSection_Driver
    {
        BottomSection_GUI gui;
        BottomSection_Controller controller;

        /// <summary>
        /// Link Main GUI
        /// </summary>
        public returns_string get_user_name
        {
            get
            {
                return controller.get_user_name;
            }
            set
            {
                controller.get_user_name = value;
            }
        }
        public returns_string get_character_name
        {
            get
            {
                return controller.get_character_name;
            }
            set
            {
                controller.get_character_name = value;
            }
        }

        /// <summary>
        /// Outbound chat to server 
        /// </summary>
        /// <returns></returns>
        public SendMessage SendMessages_MethodLink
        {
            set
            {
                controller.sendMessageToServer = value;
            }
        }
        /// <summary>
        /// Inbound chat from the server
        /// </summary>
        /// <returns></returns>
        public SendMessage recieveServerMessage
        {
            get
            {
                return controller.addToChat;
            }
        }

        public BottomSection_Driver(Boolean is_gm)
        {
            gui = new BottomSection_GUI();
            controller = new BottomSection_Controller();

            if (is_gm)
            {
                gui.RemoveGMSection();
            }

            // Control the GUI
            controller.get_chat_type = gui.get_chat_type;
            controller.get_chat_message = gui.get_chat_message;
            controller.reset_chat = gui.ResetChatInput;
            controller.PassMessageToChatWindow = gui.AddToChat;

            // Link control methods to the gui
            gui.setButtonClick(controller.chatEnter);
            gui.setEnterPressed(controller.chatEnter);

        }

        public BottomSection_GUI getGUI()
        {
            return gui;
        }

    }
}
