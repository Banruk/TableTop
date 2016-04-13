namespace TableTop.WCF
{
    using Character;
    using Shared_Resources;
    using System;
    using System.Collections.Generic;
    using System.Drawing;
    using System.Linq;
    using System.ServiceModel;
    using System.Text;
    using System.Threading.Tasks;
    using System.Windows.Forms;
    using TableTop.GUI;
    using TableTopServer.WCF_Service;


    [CallbackBehavior(UseSynchronizationContext = false)]
    public class WCF_Client : Client_WCF_Interface
    {
        //GUI_Frame gui;
        static public takes_int addSomeonesPortrait;
        static public takes_int_and_CharacterSheet updateSomeonesCharacter;
        static public takes_int removeSomeonesPortrait;

        static public SendMessage RecieveMessage;

        public WCF_Client()
        {
            // Currently doesn't do shit
        }

        public void newUserLoggedIn(int client_id, String user_name) // todo: expect a CharacterSheet
        {
            RecieveMessage("System", "User " + user_name + " has logged in.");
            addSomeonesPortrait(client_id);
        }

        public void loadLoggedInUsers(int client_id, CharacterSheet characterSheet)
        {
            addSomeonesPortrait(client_id);
            updateSomeonesCharacter(client_id, characterSheet);
        }

        public void updateUserProfile(int client_id, CharacterSheet characterSheet)
        {
            updateSomeonesCharacter(client_id, characterSheet);
        }

        public void recieveChatInput(String chatType, String message)
        {
            RecieveMessage(chatType, message);
        }

        public void clientDisconnected(int client_id)
        {
            removeSomeonesPortrait(client_id);
        }
    }
}
