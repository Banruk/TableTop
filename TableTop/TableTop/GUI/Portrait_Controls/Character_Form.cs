using Character;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TableTop;
using TableTopServer.WCF_Service;

namespace CharacterTableTop.GUI.Portrait_Controls
{
    public partial class Character_Form : Form
    {
        public Character_Form_Controller controller;

        protected Panel portrait_pane = null;
        protected CharacterSheet character_sheet = null;

        public Character_Form()
        {
            InitializeComponent();
            Hide();
        }

        public void initialize()
        {
            TopLevel = false;
            CloseButton.Click += this.controller.closeWindow;
            LoadPortraitButton.Click += controller.loadPortrait;
        }

        virtual public void buildPortraitPane()
        {
            portrait_pane = new Panel();
            portrait_pane.Width = 150;
            portrait_pane.Height = 150;
            portrait_pane.BackColor = Color.Red;
            portrait_pane.Margin = new Padding(18);
            portrait_pane.Click += controller.portraitClick;
        }

        public class Character_Form_Controller
        {
            protected Character_Form gui;

            public Character_Form_Controller(Character_Form gui)
            {
                this.gui = gui;
            }

            public void portraitClick(object sender, EventArgs e)
            {
                gui.BringToFront();
                gui.Show();
            }

            public void loadPortrait(object sender, EventArgs e)
            {
                OpenFileDialog dialog = new OpenFileDialog();
                dialog.Title = "Portrait Selection";
                dialog.Filter = "Image files (*.jpg, *.jpeg, *.jpe, *.jfif, *.png) | *.jpg; *.jpeg; *.jpe; *.jfif; *.png";
                dialog.Multiselect = false;

                if (System.IO.Directory.Exists(System.IO.Path.GetDirectoryName(Application.ExecutablePath) + @"Characters\"))
                {
                    dialog.InitialDirectory = System.IO.Path.GetDirectoryName(Application.ExecutablePath) + @"Characters\";
                }
                else
                {
                    dialog.InitialDirectory = System.IO.Path.GetDirectoryName(Application.ExecutablePath);
                }

                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    String fileName = dialog.FileName.ToString();
                    Image temp_image = Image.FromFile(fileName);
                    gui.character_sheet.SetPortrait(temp_image);

                    gui.portrait_pane.BackColor = Color.Transparent;
                    gui.portrait_pane.BackgroundImage = gui.character_sheet.GetPortrait();

                    gui.PortraitWindow.BackColor = Color.Transparent;
                    gui.PortraitWindow.BackgroundImage = gui.character_sheet.GetPortrait();

                    ImageConverter converter = new ImageConverter();

                    GUI_Frame.server.updateUserProfile(GUI_Frame.client_id, (byte[])converter.ConvertTo(gui.character_sheet.GetPortrait(), typeof(byte[])));

                    // todo: save image to directory
                }
            } // End loadPortrait

            public Panel getPortraitPane()
            {
                return gui.portrait_pane;
            }

            public void closeWindow(object sender, EventArgs e)
            {
                gui.Hide();
            }
        }
    }
}
