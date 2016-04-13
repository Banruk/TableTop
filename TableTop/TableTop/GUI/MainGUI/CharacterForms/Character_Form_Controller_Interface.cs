using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TableTop.GUI.CharacterForms
{
    public interface Character_Form_Controller_Interface
    {
        void loadCharacter(object sender, EventArgs e);
        void loadImage(object sender, EventArgs e);
        void portraitClick(object sender, EventArgs e);
        void closeWindow(object sender, EventArgs e);
        void load_XML(String path);
    }
}
