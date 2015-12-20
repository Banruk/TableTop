using Character;
using CharacterTableTop.GUI.Portrait_Controls;
using CharacterTableTop.GUI.Portrait_Controls.GameSpecificCharacterSheets;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TableTop.GUI.Portrait_Controls.GameSpecificCharacterSheets
{
    public class CharacterFormFactory
    {
        public static Character_Form formFactory(String gameMode, CharacterSheet sheet = null)
        {
            if (gameMode == "Mistborn" && sheet == null)
            {
                return new Mistborn();
            }
            else if (gameMode == "Mistborn" && sheet != null)
            {
                return new Mistborn(sheet);
            }
            return null;
        }
    }
}
