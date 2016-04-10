using Character;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TableTop.GUI.CharacterForms
{
    public interface Character_Form_Interface
    {
        CharacterSheet UpdatedCharacterSheet(CharacterSheet tempSheet = null);

        void loadFromCharactersheet(CharacterSheet character);
        void UpdatePortrait(Image portrait);

        void Show();
        void Hide();
    }
}
