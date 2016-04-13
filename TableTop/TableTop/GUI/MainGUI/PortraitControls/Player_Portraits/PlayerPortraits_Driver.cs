using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TableTop.GUI.Portrait_Controls.Player_Portraits
{
    class PlayerPortraits_Driver
    {
        PlayerPortrait_GUI gui;
        PlayerPortrait_Controller controller;

        public PlayerPortraits_Driver()
        {
            gui = new PlayerPortrait_GUI();
            controller = new PlayerPortrait_Controller();

            controller.add_portrait += gui.addPortrait;
        }

        public Form getPortraitPanel()
        {
            return gui;
        }
    }
}
