using Character;
using CharacterTableTop.GUI.Portrait_Controls;
using CharacterTableTop.GUI.Portrait_Controls.GameSpecificCharacterSheets;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TableTop.GUI.Portrait_Controls.GameSpecificCharacterSheets;

namespace TableTop.GUI.Portrait_Controls
{
    class GM_Player_Control : Base_Other_Players
    {
        public Character_Form character
        {
            get;
            private set;
        }

        public GM_Player_Control(CharacterSheet new_character, int client_id)
            : base(client_id)
        {
            character = CharacterFormFactory.formFactory(MainGUI.gameMode, new_character);
        }

        public void updatePlayer(CharacterSheet sheet)
        {
            character.loadFromCharactersheet(sheet);
        }

        override public Panel getPortrait()
        {
            return character.controller.getPortraitPane();
        }
    }
}
