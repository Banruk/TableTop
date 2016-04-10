using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TableTop.Misc;

namespace TableTop.GUI.Portrait_Controls.Player_Portraits
{
    public class Other_Player_Portraits : Base_Other_Players
    {
        Panel otherPanel;

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

        override public void updatePortrait(Image new_portrait)
        {
            getPortrait().BeginInvoke((MethodInvoker)delegate
            {
                getPortrait().BackColor = Color.Transparent;
                getPortrait().BackgroundImage = new_portrait;
            });
        }
    }
}
