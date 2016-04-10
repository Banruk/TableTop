namespace Shared_Resources
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.Drawing;
    using System.Windows.Forms;
    using Character;
    /*
     *  Just a set of delegates to be used throught the project
     */
    public delegate void takes_int(int input_int);
    public delegate void takes_string(String input_string);
    public delegate void takes_nothing();
    public delegate void takes_image(Image input_image);
    public delegate void takes_panel(Panel input_image);

    public delegate void takes_int_and_CharacterSheet(int input_int, CharacterSheet input_sheet);
}
