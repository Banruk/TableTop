using Character;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using TableTop.GUI;

namespace TableTop
{
    class Main_Driver
    {


        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            GUI_Frame_Driver gui_driver = new GUI_Frame_Driver();


            Application.Run(gui_driver.getFrame());
        }
    }
}
