using Character;
using CharacterTableTop.GUI.Portrait_Controls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TableTop.GUI.Portrait_Controls
{
    class GM_Player_Control : Base_Other_Players
    {
        Character_Form character;

        public GM_Player_Control(int client_id)
            : base(client_id)
        {

        }

        override public Panel getPortrait()
        {
            return character.controller.getPortraitPane();
        }
    }
}
