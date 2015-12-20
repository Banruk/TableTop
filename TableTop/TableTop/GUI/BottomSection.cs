using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TableTop.Misc;
using TableTopServer.WCF_Service;

namespace TableTop.GUI
{
    public partial class BottomSection : Form
    {
        public BottomSection_EventHandler handler;

        public BottomSection(MainGUI main, IServer_WCF_Interface server)
        {
            InitializeComponent();
            TopLevel = false;
            setup(main, server);
            ChatWindow.BackColor = Colors.ConvertColor(ConfigurationManager.AppSettings["chatWindowBackgroundColor"]);
            chatTab.BackColor = Colors.ConvertColor(ConfigurationManager.AppSettings["backgroundColor"]);
            UserControlsTab.BackColor = Colors.ConvertColor(ConfigurationManager.AppSettings["backgroundColor"]);
            GMTab.BackColor = Colors.ConvertColor(ConfigurationManager.AppSettings["backgroundColor"]);
            BackColor = Colors.ConvertColor(ConfigurationManager.AppSettings["backgroundColor"]);

        }

        private void setup(MainGUI main, IServer_WCF_Interface server)
        {
            handler = new BottomSection_EventHandler(main, this, server);

            String[] selections = { "In Game", "Out of Game", "Action Description" };
            ChatTypeSelector.DataSource = selections;

            ChatSubmit.Click += handler.chatEnter;
            ChatInput.KeyUp += handler.chatEnter;

            if (!MainGUI.is_gm)
            {
                BottomTab.Controls.Remove(GMTab);
            }
        }

        /// <summary>
        /// Used to get access to the BottomSection GUI
        /// </summary>
        /// <returns>The GUI's controller</returns>
        public BottomSection_EventHandler getController()
        {
            return handler;
        }

        /// <summary>
        /// To Be Removed later
        /// </summary>
        /// <param FirstName="sender"></param>
        /// <param FirstName="e"></param>
        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Controller for the BottomSection GUI
        /// </summary>
        public class BottomSection_EventHandler
        {
            IServer_WCF_Interface server;
            BottomSection page;
            MainGUI main;

            public BottomSection_EventHandler(MainGUI main, BottomSection page, IServer_WCF_Interface input_server)
            {
                server = input_server;
                this.main = main;
                this.page = page;
            }

            /// <summary>
            /// Used to add chat messages to the chatwindow
            /// </summary>
            /// <param FirstName="chatType">The type of message to be displayed, used to set the color that appears in the chat</param>
            /// <param FirstName="message">The message to be displayed in the chatwindow</param>
            public void addToChat(String chatType, String message)
            {

                page.BeginInvoke((MethodInvoker)delegate
                {
                    if (chatType.Equals("In Game") && main.controller.getUserName() != null)
                    {
                        page.ChatWindow.SelectionColor = Colors.ConvertColor(ConfigurationManager.AppSettings["inGameChatMessage"]);
                    }
                    else if (chatType.Equals("Out of Game"))
                    {
                        page.ChatWindow.SelectionColor = Colors.ConvertColor(ConfigurationManager.AppSettings["outOfGameCharMessage"]);
                    }
                    else if (chatType.Equals("Action Description") && main.controller.getUserName() != null)
                    {
                        page.ChatWindow.SelectionColor = Colors.ConvertColor(ConfigurationManager.AppSettings["actionChatMessage"]);
                    }
                    else if (chatType.Equals("System"))
                    {
                        page.ChatWindow.SelectionColor = Colors.ConvertColor(ConfigurationManager.AppSettings["systemChatMessage"]);
                    }
                    else
                    {
                        page.ChatWindow.SelectionColor = Colors.ConvertColor(ConfigurationManager.AppSettings["errorChatMessage"]);
                        page.ChatWindow.AppendText("No Character Selected, can't use this mode until a character is selected.");
                        return;
                    }

                    page.ChatWindow.AppendText(message + Environment.NewLine);
                });
            } // End addToChat

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
                    switch (page.ChatTypeSelector.SelectedValue.ToString()) 
                    { 
                        case "Out of Game":
                            prefix = "[" + main.controller.getUserName() + "]: ";
                            break;
                    }
                    server.recieveChatInput(page.ChatTypeSelector.SelectedValue.ToString(), prefix + page.ChatInput.Text);
                }
            } // End chatEnter
        } // End BottomSection_EventHandler
    } // End BottomSection
}
