namespace TableTop.GUI
{
    using Character;
    using Shared_Resources;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Configuration;
    using System.Data;
    using System.Drawing;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.Windows.Forms;
    using TableTop.GUI.Portrait_Controls;
    using TableTop.Misc;
    using TableTopServer.WCF_Service;

    public partial class Portraits_GUI : Form
    {

        public Portraits_GUI()
        {
            InitializeComponent();
            BackColor = Colors.ConvertColor(ConfigurationManager.AppSettings["backgroundColor"]);

            TopLevel = false;
            FormBorderStyle = FormBorderStyle.None;
            Dock = DockStyle.Fill;

            PortraitPane.AutoScroll = true;
            PortraitPane.FlowDirection = FlowDirection.TopDown;
            Show();
        }

        public void addPortrait(Panel new_portrait)
        {
            this.BeginInvoke((MethodInvoker)delegate
            {
                PortraitPane.Controls.Add(new_portrait);
                new_portrait.Show();
                new_portrait.BringToFront();
            });
        }

        public void removePortrait(Panel dead_portrait)
        {
            this.BeginInvoke((MethodInvoker)delegate
            {
                PortraitPane.Controls.Remove(dead_portrait);
                dead_portrait.Dispose();
            });
        }
    } // End Portraits_GUI
}
