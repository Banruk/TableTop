using Character;
using Shared_Resources;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;
using TableTop;
using TableTop.GUI.Portrait_Controls;
using TableTop.Misc;
using TableTopServer.WCF_Service;

namespace CharacterTableTop.GUI.Portrait_Controls
{
    public partial class Character_Form : Form
    {
        public Character_Form_Controller controller;

        protected Panel portrait_pane = null;
        protected CharacterSheet character_sheet = null;
        protected CharacterSelection character_selection;

        public Character_Form()
        {
            InitializeComponent();
            Hide();
        }

        public void initialize()
        {
            TopLevel = false;

            character_selection = new CharacterSelection(this);
            Controls.Add(character_selection);
            character_selection.Hide();

            CloseButton.Click += this.controller.closeWindow;
            LoadCharacterButton.Click += this.controller.loadCharacter;

            LoadPortraitButton.Click += controller.loadImage;
            LoadSpriteButton.Click += controller.loadImage;
        }

        virtual public void buildPortraitPane()
        {
            portrait_pane = new Panel();
            portrait_pane.Width = 150;
            portrait_pane.Height = 150;

            portrait_pane.BackColor = Colors.ConvertColor(System.Configuration.ConfigurationManager.AppSettings["emptyPortraitColor"]);
            portrait_pane.Margin = new Padding(16);
            portrait_pane.Click += controller.portraitClick;
        }

        virtual public void loadFromCharactersheet(CharacterSheet character)
        {
            character_sheet.FirstName = character.FirstName;
            character_sheet.LastName = character.LastName;
            character_sheet.Age = character.Age;
            character_sheet.Race = character.Race;
            character_sheet.Gender = character.Gender;
            character_sheet.Weight = character.Weight;
            character_sheet.Height = character.Height;
            character_sheet.Description = character.Weight;
            character_sheet.portrait_bytes = character.portrait_bytes;
            character_sheet.sprite_bytes = character.sprite_bytes;

            FirstName.Text = character_sheet.FirstName;
            LastName.Text = character_sheet.LastName;
            Age.Text = character_sheet.Age;
            Race.Text = character_sheet.Race;
            Gender.Text = character_sheet.Gender;
            Weight.Text = character_sheet.Weight;
            Height.Text = character_sheet.Height;
            Description.Text = character_sheet.Description;

            if (character_sheet.portrait != null)
            {
                portrait_pane.BackColor = Color.Transparent;
                portrait_pane.BackgroundImage = character_sheet.portrait;

                PortraitWindow.BackColor = Color.Transparent;
                PortraitWindow.BackgroundImage = character_sheet.portrait;
            }

        }

        public class Player_Controller : PlayerController
        {
            Character_Form gui;

            public Player_Controller(Character_Form gui)
            {
                this.gui = gui;
            }

            public Image getSprite()
            {
                return gui.character_sheet.sprite;
            }
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

            /******************************
             * Load Methods
             ******************************/

            public void loadImage(object sender, EventArgs e)
            {
                OpenFileDialog dialog = new OpenFileDialog();
                dialog.Title = "Portrait Selection";
                dialog.Filter = "Image files (*.jpg, *.jpeg, *.jpe, *.jfif, *.png) | *.jpg; *.jpeg; *.jpe; *.jfif; *.png";
                dialog.Multiselect = false;

                if (System.IO.Directory.Exists(System.IO.Path.GetDirectoryName(Application.ExecutablePath) + @"\Characters\"))
                {
                    dialog.InitialDirectory = System.IO.Path.GetDirectoryName(Application.ExecutablePath) + @"\Characters\";
                }
                else
                {
                    dialog.InitialDirectory = System.IO.Path.GetDirectoryName(Application.ExecutablePath);
                }

                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    String fileName = dialog.FileName.ToString();
                    Image temp_image = Image.FromFile(fileName);
                    if (sender == gui.LoadPortraitButton)
                    {
                        gui.character_sheet.portrait = temp_image;
                        updatePortrait();
                    }
                    else if (sender == gui.LoadSpriteButton)
                    {
                        gui.character_sheet.sprite = temp_image;
                        gui.SpriteLoaded.Text = "Sprite Loaded";
                    }
                }
            } // End loadImage

            protected void updatePortrait()
            {
                gui.portrait_pane.BackColor = Color.Transparent;
                gui.portrait_pane.BackgroundImage = gui.character_sheet.portrait;

                gui.PortraitWindow.BackColor = Color.Transparent;
                gui.PortraitWindow.BackgroundImage = gui.character_sheet.portrait;

                // Send the image for update to all other clients
                if(!MainGUI.is_gm)
                    GUI_Frame.server.updateUserProfile(GUI_Frame.client_id, gui.character_sheet);
            }

            public virtual void loadCharacter(object sender, EventArgs e)
            {
                // XML Needs to occur in overriding method before call this this class
                gui.character_selection.LoadSelections();
                gui.character_selection.BringToFront();
                gui.character_selection.Show();


            } // End loadCharacter

            public void loadXML(String path)
            {
                gui.character_sheet = (CharacterSheet)Serialization.xml_deserialize(gui.character_sheet.GetType(), path);
                updateProfile();

            }

            protected virtual void updateProfile()
            {
                gui.FirstName.Text = gui.character_sheet.FirstName;
                gui.LastName.Text = gui.character_sheet.LastName;
                gui.Age.Text = gui.character_sheet.Age;
                gui.Race.Text = gui.character_sheet.Race;
                gui.Gender.Text = gui.character_sheet.Gender;
                gui.Weight.Text = gui.character_sheet.Weight;
                gui.Height.Text = gui.character_sheet.Height;
                gui.Description.Text = gui.character_sheet.Description;

                if (gui.character_sheet.sprite != null)
                    gui.SpriteLoaded.Text = "Sprite Loaded";
                else
                    gui.SpriteLoaded.Text = "No Sprite Loaded";

                updatePortrait();
            }

            /******************************
             * Save Methods
             ******************************/
            public virtual void saveCharacter()
            {
                gui.character_sheet.FirstName = gui.FirstName.Text;
                gui.character_sheet.LastName = gui.LastName.Text;
                gui.character_sheet.Age = gui.Age.Text;
                gui.character_sheet.Race = gui.Race.Text;
                gui.character_sheet.Gender = gui.Gender.Text;
                gui.character_sheet.Weight = gui.Weight.Text;
                gui.character_sheet.Height = gui.Height.Text;
                gui.character_sheet.Description = gui.Description.Text;
            }

            public virtual void save_XML()
            {
                if (!System.IO.Directory.Exists(System.IO.Path.GetDirectoryName(Application.ExecutablePath) + @"\Characters\"  + MainGUI.gameMode + @"\"))
                {
                    System.IO.Directory.CreateDirectory(System.IO.Path.GetDirectoryName(Application.ExecutablePath) + @"\Characters\"  + MainGUI.gameMode + @"\");
                }

                String file_path = System.IO.Path.GetDirectoryName(Application.ExecutablePath) + @"\Characters\"  + MainGUI.gameMode + @"\" + gui.character_sheet.FirstName + "_" + gui.character_sheet.LastName + ".xml";
                Serialization.xml_serialize(gui.character_sheet, gui.character_sheet.GetType(), file_path);
            }

            public void TabStop()
            {
                foreach (Control control in gui.Controls)
                {
                    if (control.GetType() == typeof(Label) || control.GetType() == typeof(Panel))
                    {
                        control.TabStop = false;
                    }
                }
            }

            public Panel getPortraitPane()
            {
                return gui.portrait_pane;
            }

            public void closeWindow(object sender, EventArgs e)
            {
                saveCharacter();
                save_XML();
                gui.Hide();
            }
        }
    }
}
