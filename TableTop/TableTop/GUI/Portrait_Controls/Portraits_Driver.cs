using Character;
using Shared_Resources;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TableTop.GUI.CharacterForms;
using TableTop.GUI.Portrait_Controls.Player_Portraits;

namespace TableTop.GUI.Portrait_Controls
{
    public class Portraits_Driver
    {
        Portraits_GUI gui;
        Portraits_Controller controller;

        public takes_int removePortrait
        {
            get;
            private set;
        }
        public takes_int_and_CharacterSheet addPortrait
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
                gui = new PlayerPortrait_GUI();
                controller = new PlayerPortrait_Controller();
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

            //controller.FinalizeInitialize();

            gui.Show();
        }

        public Portraits_GUI GetPortraitGUI()
        {
            return gui;
        }

        public void AddPlayersPortrait(Panel input_panel)
        {
            gui.addPortrait(input_panel);
        }
    }
}
