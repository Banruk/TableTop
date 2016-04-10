﻿namespace TableTop.GUI.CharacterForms
{
    using Character;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.Windows.Forms;
    using TableTop.GUI.CharacterForms.Mistborn;

    /// <summary>
    /// Main Driver for the Character Details section
    /// </summary>
    public class Character_Form_Driver
    {
        /// <summary>
        /// Low level reference to the GUI
        /// </summary>
        private Character_Form character_form;
        /// <summary>
        /// Low level reference to the GUI controller
        /// </summary>
        private Character_Form_Controller controller;

        /// <summary>
        /// Initialization
        /// </summary>
        /// <param name="game_mode">Determines which derived classes we're using</param>
        public Character_Form_Driver(String game_mode)
        {
            build(game_mode);
        }

        /// <summary>
        /// Initialization
        /// </summary>
        /// <param name="game_mode">Determines which derived classes we're using</param>
        /// <param name="input_form">Create Character Details from an input character sheet (GM uses this)</param>
        public Character_Form_Driver(String game_mode, CharacterSheet input_form)
        {
            build(game_mode);
            loadCharacterSheet(input_form);
        }

        /// <summary>
        /// Used for adding the Character Details UI to the program
        /// </summary>
        /// <returns>The Character Details UI</returns>
        public Form getCharacterForm()
        {
            return character_form;
        }

        /// <summary>
        /// Used to add the character's portrait to the portait panel
        /// </summary>
        /// <returns>Portrait Panel</returns>
        public Panel getPortraitPane()
        {
            return character_form.getPortraitPane();
        }

        /// <summary>
        /// Update the character based on a new character sheet.  Typically sent from server
        /// </summary>
        /// <param name="sheet">Character sheet to update to.</param>
        public void loadCharacterSheet(CharacterSheet sheet)
        {
            controller.loadCharacterFromSheet(sheet);
        }

        /// <summary>
        /// Initialize and connect the GUI and its Controller
        /// </summary>
        /// <param name="game_mode">Determines which derived classes we're using</param>
        private void build(String game_mode)
        {
            switch (game_mode)
            {
                case "Mistborn":
                    character_form = new Mistborn_Form();
                    controller = new Mistborn_Controller(character_form);
                    break;
                default: // SHOULD NEVER HAPPEN
                    character_form = new Character_Form();
                    controller = new Character_Form_Controller(character_form);
                    break;
            }

            character_form.initialize(controller);
        }
    }
}
