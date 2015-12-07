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
        GUI_Frame gui;

        public WCF_Client(GUI_Frame intest)
        {
            gui = intest;
        }

        public void newUserLoggedIn(int client_id, String user_name)
        {
            // Needs a lot of work still
            gui.mainGUI.bottomPane.getController().addToChat("System", "User " + user_name + " has logged in.");
            gui.mainGUI.getController().getPortraits().addPortrait(client_id, null);
        }

        public void loadLoggedInUsers(int client_id, byte[] portrait)
        {
            // Need to actually load portraits if they exist
            gui.mainGUI.getController().getPortraits().addPortrait(client_id, portrait);
        }

        public void updateUserProfile(int client_id, byte[] portrait)
        {
            gui.mainGUI.getController().getPortraits().updatePortrait(client_id, portrait);
        }

        public void recieveChatInput(String chatType, String message)
        {
            gui.mainGUI.bottomPane.getController().addToChat(chatType, message);
        }

        public void clientDisconnected(int client_id)
        {
            gui.mainGUI.getController().getPortraits().removePortrait(client_id);
        }
    }
}
