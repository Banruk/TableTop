namespace TableTop.GUI.Portrait_Controls.Player_Portraits
{
    using Character;
    using Shared_Resources;
    using System;
    using System.Collections.Generic;
    using System.Drawing;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using TableTop.GUI.CharacterForms;

    class PlayerPortrait_Controller: Portraits_Controller
    {
        protected List<Base_Other_Players> portraits;

        public takes_panel addPlayer
        {
            get;
            private set;
        }
        
        public PlayerPortrait_Controller()
        {
            portraits = new List<Base_Other_Players>();
        }

        override public void addPortrait(int client_id, CharacterSheet sheet)
        {
            Other_Player_Portraits new_player = new Other_Player_Portraits(client_id);
            portraits.Add(new_player);

            add_portrait(new_player.getPortrait());
        }

        override public void updateCharacter(int client_id, CharacterSheet updateCharacter)
        {
            foreach (Base_Other_Players tmp in portraits)
            {
                if (tmp.client_id == client_id)
                {
                    tmp.updatePortrait(updateCharacter.portrait);
                    break;
                }
            }
        }

        override public void removePortrait(int client_id)
        {
            foreach (Base_Other_Players tmp in portraits)
            {
                if (tmp.client_id == client_id)
                {
                    remove_portrait(tmp.getPortrait());
                    break;
                }
            }
        } // End removePortrait
    }
}
