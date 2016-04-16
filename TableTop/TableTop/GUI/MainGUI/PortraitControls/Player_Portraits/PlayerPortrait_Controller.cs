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
        public PlayerPortrait_Controller()
            :base()
        {

        }

        /// <summary>
        /// Method to add a new portrait panel to the Portrait's UI
        /// </summary>
        /// <param name="client_id">Client ID for the new portrait</param>
        override public void addPortrait(int client_id)
        {
            Other_Player_Portraits new_player = new Other_Player_Portraits(client_id);
            portraits.Add(new_player);

            add_portrait(new_player.getPortrait());
        }

    }
}
