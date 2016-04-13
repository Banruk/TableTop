namespace TableTop.GUI.CharacterForms.Mistborn
{
    using Character;
    using Character.GameSpecificCharacterSheets.Mistborn;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    /// <summary>
    /// Extends control of the Character Details GUI
    /// </summary>
    class Mistborn_Controller : Character_Form_Controller
    {
        /// <summary>
        /// Mistborn Character sheet
        /// </summary>
        Mistborn_CharacterSheet mistborn_character_sheet;

        /// <summary>
        /// Initialize a new Mistborn Character Details Conroller
        /// </summary>
        /// <param name="gui">Interface reference for the Character Details GUI</param>
        public Mistborn_Controller(Character_Form_Interface gui) : base(gui)
        {
            mistborn_character_sheet = new Mistborn_CharacterSheet();
            character_sheet = mistborn_character_sheet; // character_sheet is a lower level reference to our Mistborn character sheet
        }

        /// <summary>
        /// Updates the currently held driver_character sheet's.
        /// CharacterSheet may trickle down from a higher level.
        /// </summary>
        override public void saveCharacter(CharacterSheet tmpChar)
        {
            Mistborn_CharacterSheet tmp;
            if (tmpChar == null)
                tmp = (Mistborn_CharacterSheet)gui.UpdatedCharacterSheet();
            else
                tmp = (Mistborn_CharacterSheet)tmpChar;

            // set any new values that need to be taken from tmp
            // ex.
            // character_sheet.strength = tmp.stength;

            base.saveCharacter(tmp); // Pass it down the line for processing
        }
    }
}
