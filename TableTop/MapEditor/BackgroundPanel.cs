using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MapEditor
{
    class BackgroundPanel : Panel
    {
        public Image background;

        public BackgroundPanel(Image background) 
            : base()
        {
            Width = 100;
            Height = 100;
            this.background = background;
            BackgroundImage = background;
            Show();
        }

    }
}
