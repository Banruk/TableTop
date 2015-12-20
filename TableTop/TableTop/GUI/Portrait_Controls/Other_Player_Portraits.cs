using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TableTop.Misc;

namespace TableTop.GUI.Portrait_Controls
{
    public class Other_Player_Portraits : Base_Other_Players
    {
        public int client_id
        {
            get;
            private set;
        }
        Panel otherPanel;
        Image portrait;

        public Other_Player_Portraits(int client_id)
            : base(client_id)
        {
            otherPanel = new Panel();

            otherPanel.Width = 150;
            otherPanel.Height = 150;
            otherPanel.Margin = new Padding(16, 0, 0, 16);

            otherPanel.BackColor = Colors.ConvertColor(System.Configuration.ConfigurationManager.AppSettings["emptyPortraitColor"]);
        }

        override public Panel getPortrait()
        {
            return otherPanel;
        }
    }
}
