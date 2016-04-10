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

namespace TableTop.GUI
{
    public partial class Portraits : Form
    {
        protected Portraits_Controller controller;
        protected MainGUI main;

        public Portraits() { InitializeComponent(); }

        public Portraits(MainGUI mainGUI)
        {
            InitializeComponent();
            main = mainGUI;
            BackColor = Colors.ConvertColor(ConfigurationManager.AppSettings["backgroundColor"]);

            TopLevel = false;
            FormBorderStyle = FormBorderStyle.None;
            Dock = DockStyle.Fill;

            PortraitPane.AutoScroll = true;
        }

        public Portraits_Controller getController()
        {
            return controller;
        }

        abstract public class Portraits_Controller
        {
            abstract public void addPortrait(int client_id, CharacterSheet sheet);

            abstract public void updateCharacter(int client_id, CharacterSheet updateCharacter);

            abstract public void removePortrait(int client_id);
        } // End Portraits_Controller
    } // End Portraits
}
