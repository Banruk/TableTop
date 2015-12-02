using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TableTopServer.WCF_Service;

namespace TableTop.GUI
{
    public partial class BottomSection : Form
    {
        public BottomSection_EventHandler handler;

        public BottomSection(IServer_WCF_Interface server)
        {
            InitializeComponent();
            TopLevel = false;
            setup(server);
        }

        private void setup(IServer_WCF_Interface server)
        {
            handler = new BottomSection_EventHandler(this, server);

            String[] selections = { "In Game", "Out of Game", "Action Description" };
            ChatTypeSelector.DataSource = selections;

            ChatSubmit.Click += handler.chatEnter;
            ChatInput.KeyUp += handler.chatEnter;
        }


        public RichTextBox getChatWindow()
        {
            return ChatWindow;
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        public class BottomSection_EventHandler
        {
            IServer_WCF_Interface server;
            BottomSection page;

            public BottomSection_EventHandler(BottomSection page, IServer_WCF_Interface input_server)
            {
                server = input_server;
                this.page = page;
            }
            public void chatEnter(object sender, EventArgs e)
            {
                if (sender.GetType() == typeof(Button) || (sender.GetType() == typeof(TextBox) && ((KeyEventArgs)e).KeyCode == Keys.Enter))
                {
                    server.recieveChatInput(page.ChatTypeSelector.SelectedValue.ToString(), page.ChatInput.Text);
                }
            }
        }
    }
}
