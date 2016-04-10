namespace TableTop.GUI.CharacterForms.Mistborn
{
    using Character;
    using Character.GameSpecificCharacterSheets.Mistborn;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Data;
    using System.Drawing;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.Windows.Forms;
    using TableTop.GUI.CharacterForms;
    using TableTopServer.WCF_Service;

    /// <summary>
    /// Mistborn Character Details.  All Mistborn specific stuff goes in here.
    /// </summary>
    public partial class Mistborn_Form : Character_Form
    {
        /// <summary>
        /// Initialize any new Mistborn stuff
        /// </summary>
        public Mistborn_Form()
            :base()
        {
            // Do Mistborn specific initialization here
        }

        /// <summary>
        /// Load a character's data from a CharacterSheet
        /// </summary>
        /// <param name="character">Character data to load</param>
        override public void loadFromCharactersheet(CharacterSheet character)
        {
            Mistborn_CharacterSheet tmpSheet = (Mistborn_CharacterSheet)character;

            // Update whatever needs to be updated

            base.loadFromCharactersheet(character); // Pass the sheet to a lower level of the class for processing.
        }

        /// <summary>
        /// Constructs a CharacterSheet containing the updated UI infromation
        /// </summary>
        /// <param name="tempSheet">A CharacterSheet started at a higher level (if not null)</param>
        /// <returns>Updated CharacterSheet information</returns>
        override public CharacterSheet UpdatedCharacterSheet(CharacterSheet tempSheet = null)
        {
            Mistborn_CharacterSheet tmp;
            if (tempSheet == null)// Should never happen at the this level
                tmp = new Mistborn_CharacterSheet();
            else
                tmp = (Mistborn_CharacterSheet)tempSheet;

            // stuff to return here

            return base.UpdatedCharacterSheet(tmp); // Return the results from all levels of updating
        }
    }
}
