using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TableTop
{
    public partial class MainGUI : Form
    {
        public MainGUI()
        {
            InitializeComponent();
            setUp();
        }

        private void setUp()
        {
            TopLevel = false;
            FormBorderStyle = FormBorderStyle.None;
            Dock = DockStyle.Fill;
            BackColor = Color.Red;
        }
    }
}
