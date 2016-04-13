using Character;
using System;
using System.Collections.Generic;
using System.Drawing;
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

        public GM_Player_Control(String gameMode, CharacterSheet new_character, int client_id)
            : base(client_id)
        {
            character = new Character_Form_Driver(gameMode, new_character);
        }

        public void updatePlayer(CharacterSheet sheet)
        {
            character.loadCharacterSheet(sheet);
        }

        override public Panel getPortrait()
        {
            return character.getPortraitPane(); 
        }

        override public void updatePortrait(Image new_portrait)
        {
            // todo: FIX THIS
            getPortrait().BeginInvoke((MethodInvoker)delegate
            {
                getPortrait().BackColor = Color.Transparent;
                getPortrait().BackgroundImage = new_portrait;
            });
        }
    }
}
