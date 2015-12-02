using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TableTopServer.WCF_Service;

namespace TableTop.WCF
{
    [CallbackBehavior(UseSynchronizationContext = false)]
    public class WCF_Client : TableTopServer.WCF_Service.Client_WCF_Interface
    {
        GUI_Frame test;
        public WCF_Client(GUI_Frame intest)
        {
            test = intest;
        }

        public void recieveChatInput(String chatType, String message)
        {
            RichTextBox t = test.mainGUI.bottomPane.getChatWindow(); // Need to fix this a little bit somehow
            //"In Game", "Out of Game", "Action Description"
            if (chatType.Equals("In Game"))
                t.SelectionColor = Color.Red;
            else if (chatType.Equals("Out of Game"))
                t.SelectionColor = Color.Blue;
            else if (chatType.Equals("Action Description"))
                t.SelectionColor = Color.Green;
            else
                t.SelectionColor = Color.Brown;

            t.AppendText(message + Environment.NewLine);
        }
    }
}
