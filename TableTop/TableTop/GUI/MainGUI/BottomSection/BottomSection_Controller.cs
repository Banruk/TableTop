using Shared_Resources;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TableTop.Misc;

namespace TableTop.GUI.MainGUI.BottomSection
{
    class BottomSection_Controller
    {
        /// <summary>
        /// Delegate holding a reference to the chatbox window's input settings.
        /// </summary>
        public RecieveMessage PassMessageToChatWindow; //Chat Window
        public SendMessage sendMessageToServer;

        /// <summary>
        /// From Main GUI (not implimented)
        /// </summary>
        public returns_string get_user_name;
        public returns_string get_character_name;

        /// <summary>
        /// From GUI
        /// </summary>
        public returns_string get_chat_type;
        public returns_string get_chat_message;
        public takes_nothing reset_chat;

        /// <summary>
        /// Used to add chat messages to the chatwindow
        /// </summary>
        /// <param FirstName="chatType">The type of message to be displayed, used to set the color that appears in the chat</param>
        /// <param FirstName="message">The message to be displayed in the chatwindow</param>
        public Boolean addToChat_inner(String chatType, String message)
        {
            Color color;

            if (chatType.Equals("In Game") && get_character_name() != null)
            {
                color = Colors.ConvertColor(ConfigurationManager.AppSettings["inGameChatMessage"]);
            }
            else if (chatType.Equals("Out of Game"))
            {
                color = Colors.ConvertColor(ConfigurationManager.AppSettings["outOfGameCharMessage"]);
            }
            else if (chatType.Equals("Action Description") && get_character_name() != null)
            {
                color = Colors.ConvertColor(ConfigurationManager.AppSettings["actionChatMessage"]);
            }
            else if (chatType.Equals("System"))
            {
                color = Colors.ConvertColor(ConfigurationManager.AppSettings["systemChatMessage"]);
            }
            else
            {
                color = Colors.ConvertColor(ConfigurationManager.AppSettings["errorChatMessage"]);
                PassMessageToChatWindow(chatType, "You don't have a character loaded, or else I don't know what chat type this is." + Environment.NewLine, color);
                return false;
            }
            PassMessageToChatWindow(chatType, message + Environment.NewLine, color);
            return true;
        } // End addToChat


        public void addToChat(String chatType, String message)
        {
            addToChat_inner(chatType, message);
        }


        /// <summary>
        /// Used to handle anytime the submit button is pressed, or enter is typed in the chatinput window
        /// </summary>
        /// <param FirstName="sender">Either the submit button, or the chatinput window</param>
        /// <param FirstName="e">Events related to either sender</param>
        public void chatEnter(object sender, EventArgs e)
        {
            
            if (sender.GetType() == typeof(Button) || (sender.GetType() == typeof(TextBox) && ((KeyEventArgs)e).KeyCode == Keys.Enter))
            {
                String prefix = "";

                if (get_chat_type() == MagicalData.chat_type[0])
                {
                    prefix = "[" + get_user_name() + "]: ";
                }

                if (addToChat_inner(get_chat_type(), prefix + get_chat_message()))
                {
                    sendMessageToServer(get_chat_type(), prefix + get_chat_message());
                }

                reset_chat();
            }
        } // End chatEnter
    }
}
