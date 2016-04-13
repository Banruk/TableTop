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

namespace TableTop.GUI.MainGUI.BottomSection
{
    public partial class BottomSection_GUI : Form
    {

        public BottomSection_GUI()
        {
            InitializeComponent();
            TopLevel = false;

            String[] selections = { "In Game", "Out of Game", "Action Description" };
            ChatTypeSelector.DataSource = selections;
        }

        public void setButtonClick(EventHandler input)
        {
            ChatSubmit.Click += input;
        }

        public void setEnterPressed(KeyEventHandler input)
        {
            ChatInput.KeyUp += (KeyEventHandler)input;
        }

        public void RemoveGMSection()
        {
            //chatEnter(object sender, EventArgs e)
            //EventHandler
            BottomTab.Controls.Remove(GMTab);
        }

        public void AddToChat(String chatType, String message, Color color)
        {
            BeginInvoke((MethodInvoker)delegate
            {
                ChatWindow.SelectionColor = color;
                ChatWindow.AppendText(message);
            });
        }

        private void LoadColors()
        {
            ChatWindow.BackColor = Colors.ConvertColor(ConfigurationManager.AppSettings["chatWindowBackgroundColor"]);
            chatTab.BackColor = Colors.ConvertColor(ConfigurationManager.AppSettings["backgroundColor"]);
            UserControlsTab.BackColor = Colors.ConvertColor(ConfigurationManager.AppSettings["backgroundColor"]);
            GMTab.BackColor = Colors.ConvertColor(ConfigurationManager.AppSettings["backgroundColor"]);
            BackColor = Colors.ConvertColor(ConfigurationManager.AppSettings["backgroundColor"]);
        }

        public String get_chat_type()
        {
            return ChatTypeSelector.SelectedText;
        }

        public String get_chat_message()
        {
            return ChatInput.Text;
        }

        public void ResetChatInput()
        {
            ChatInput.Text = String.Empty;
        }
    } // End BottomSection
}
