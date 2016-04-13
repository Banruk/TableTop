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

        public takes_int removePortrait
        {
            get;
            private set;
        }
        public takes_int addPortrait
        {
            get;
            private set;
        }
        public takes_int_and_CharacterSheet updateCharacter
        {
            get;
            private set;
        }

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

        public Portraits_GUI GetPortraitGUI()
        {
            return gui;
        }

        public void AddMyPortrait(Panel input_panel)
        {
            gui.addPortrait(input_panel);
        }
    }
}
