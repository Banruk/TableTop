using Character;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TableTop.GUI.CharacterForms;

namespace TableTop.GUI.Portrait_Controls
{
    class GM_Player_Control : Base_Other_Players
    {
        public Character_Form_Driver character
        {
            get;
            private set;
        }

        public GM_Player_Control(CharacterSheet new_character, int client_id)
            : base(client_id)
        {
            character = new Character_Form_Driver(MainGUI.gameMode, new_character);
        }

        public void updatePlayer(CharacterSheet sheet)
        {
            character.loadCharacterSheet(sheet);
        }

        override public Panel getPortrait()
        {
            return character.getPortraitPane();
        }
    }
}
