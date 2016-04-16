namespace TableTop.GUI.Portrait_Controls
{
    using System;
    using System.Collections.Generic;
    using System.Drawing;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.Windows.Forms;
    using TableTop.Misc;

    /// <summary>
    /// Template for Data on another Player
    /// Note: Probably doesn't need to be abstract, but whatever
    /// </summary>
    abstract public class Base_Other_Players
    {
        protected Panel otherPanel;

        /// <summary>
        /// This player's client ID assigned by the server
        /// </summary>
        public int client_id
        {
            get;
            private set;
        }

        public Base_Other_Players(int client_id)
        {
            this.client_id = client_id;

            otherPanel = new Panel();

            otherPanel.Width = 150;
            otherPanel.Height = 150;
            otherPanel.Margin = new Padding(16, 0, 0, 16);

            otherPanel.BackColor = Colors.ConvertColor(System.Configuration.ConfigurationManager.AppSettings["emptyPortraitColor"]);
        }

        /// <summary>
        /// Method used to return this player's Character Portrait
        /// </summary>
        /// <returns>Portrait Panel</returns>
        virtual public Panel getPortrait()
        {
            return otherPanel;
        }

        /// <summary>
        /// Used to update this player's portrait
        /// </summary>
        /// <param name="new_portrait">Image to update the portrait to</param>
        virtual public void updatePortrait(Image new_portrait)
        {
            if (new_portrait != null)
            {
                getPortrait().BeginInvoke((MethodInvoker)delegate
                {
                    getPortrait().BackColor = Color.Transparent;
                    if (new_portrait != null)
                    {
                        getPortrait().BackgroundImage = new_portrait; // breaks when null??
                    }
                });
            }
        }

    }
}
