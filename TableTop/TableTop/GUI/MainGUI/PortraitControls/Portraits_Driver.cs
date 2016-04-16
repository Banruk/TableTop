namespace TableTop.GUI.Portrait_Controls
{
    using Character;
    using Shared_Resources;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.Windows.Forms;
    using TableTop.GUI.CharacterForms;
    using TableTop.GUI.Portrait_Controls.GM_Portraits;
    using TableTop.GUI.Portrait_Controls.Player_Portraits;

    public class Portraits_Driver
    {
        Portraits_GUI gui;
        Portraits_Controller controller;

        /// <summary>
        /// Removes the portrait belonging to the passed Client ID
        /// </summary>
        public takes_int removePortrait
        {
            get;
            private set;
        }
        /// <summary>
        /// Adds an empty portraits for another character, and link it to the passed Client ID
        /// Called externally.
        /// </summary>
        public takes_int addPortrait
        {
            get;
            private set;
        }
        /// <summary>
        /// Updates a user's portrait based on client ID
        /// Called externally.
        /// </summary>
        public takes_int_and_CharacterSheet updateCharacter
        {
            get;
            private set;
        }

        /// <summary>
        /// Driver that builds, links, and manages the portrait container UI
        /// </summary>
        /// <param name="is_gm">Is the current user the GM</param>
        public Portraits_Driver(Boolean is_gm)
        {
            if (is_gm)
            {
                // todo
                gui = new GM_Portraits_GUI();
                controller = new GM_Portraits_Controller();
            }
            else
            {
                gui = new PlayerPortrait_GUI();
                controller = new PlayerPortrait_Controller();

            }

            // Link controller with GUI
            controller.add_portrait += gui.addPortrait;
            controller.remove_portrait += gui.removePortrait;

            // Provided links from Controller to outside the module.
            removePortrait += controller.removePortrait;
            addPortrait += controller.addPortrait;
            updateCharacter += controller.updateCharacter;

            gui.Show();
        }

        /// <summary>
        /// Used to get the Portraits UI
        /// </summary>
        /// <returns></returns>
        public Portraits_GUI GetPortraitGUI()
        {
            return gui;
        }

        /// <summary>
        /// Used to add the current user's portrait
        /// </summary>
        /// <param name="input_panel"></param>
        public void AddMyPortrait(Panel input_panel)
        {
            gui.addPortrait(input_panel);
        }
    }
}
