using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TableTop.GUI
{
    public partial class Portraits : Form
    {
        List<Panel> portraits;

        public Portraits()
        {
            InitializeComponent();

            TopLevel = false;
            FormBorderStyle = FormBorderStyle.None;
            Dock = DockStyle.Fill;
            portraits = new List<Panel>();

            PortraitPane.AutoScroll = true;
            PortraitPane.WrapContents = false;
        }

        public void addPortrait()
        {
            Panel newPanel = new Panel();

            newPanel.Width = 150;
            newPanel.Height = 150;
            newPanel.BackColor = Color.Red;
            newPanel.Margin = new Padding(18);

            portraits.Add(newPanel);
            PortraitPane.Controls.Add(newPanel);
            newPanel.Show();
        }


    }
}
