namespace TableTop.GUI.CharacterForms
{
    using Character;
    using Shared_Resources;
    using System;
    using System.Collections.Generic;
    using System.Drawing;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.Windows.Forms;

    /// <summary>
    /// Controls the Character Details GUI
    /// </summary>
   class Character_Form_Controller : Character_Form_Controller_Interface
    {
        /// <summary>
        /// Interface reference for the Character Details GUI
        /// </summary>
        protected Character_Form_Interface gui;
        /// <summary>
        /// low level reference of character_sheet, should not be a stand alone object
        /// </summary>
        public CharacterSheet character_sheet;
        public takes_nothing showLoadScreen;

        public returns_string get_UserName;
        public returns_boolean GM_eh;

        /// <summary>
        /// Initialize the Controller
        /// </summary>
        /// <param name="gui">Interface reference for the Character Details GUI</param>
        public Character_Form_Controller(Character_Form_Interface gui)
        {
            this.gui = gui;
            if (character_sheet == null)
                character_sheet = new CharacterSheet();
        }

       /// <summary>
       /// Simply makes the Character Details window visible when clicked.
       /// </summary>
       /// <param name="sender"></param>
       /// <param name="e"></param>
        public void portraitClick(object sender, EventArgs e)
        {
            gui.Show();
        }
       
       /// <summary>
       /// Spawns a dialog box to select a image from the hard drive.  It is then loaded into the CharacterSheet
       /// </summary>
       /// <param name="sender">Button text is used to determine which kind of image we're loading</param>
       /// <param name="e">N/A</param>
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

                if (((Button)sender).Text == "Load Portrait")
                {
                    character_sheet.portrait = temp_image;
                    updatePortrait();
                }
                else if (((Button)sender).Text == "Load Sprite")
                {
                    character_sheet.sprite = temp_image;
                    //gui.SpriteLoaded.Text = "Sprite Loaded"; // todo: fix dis shit
                }
            }
        } // End loadImage

       /// <summary>
       /// Triggers all the portrait updating stuff
       /// </summary>
        protected void updatePortrait() 
        {
            gui.UpdatePortrait(character_sheet.portrait);

            // Send the image for update to all other clients
            if (!GM_eh()) //todo: Decouple this section
                GUI_Frame_Driver.server.updateUserProfile(GUI_Frame.client_id, character_sheet);
        }

       /// <summary>
       /// Tells the GUI to display it's Select Character file window.
       /// </summary>
       /// <param name="sender">n/a</param>
       /// <param name="e">n/a</param>
        public void loadCharacter(object sender, EventArgs e)
        {
            showLoadScreen();
        } // End loadCharacter

       /// <summary>
       /// Loads a CharacterSheet from its local XML file.
       /// </summary>
       /// <param name="path">The path to the XML file to be loaded.</param>
        public void load_XML(String path)
        {
            character_sheet = (CharacterSheet)Serialization.xml_deserialize(character_sheet.GetType(), path);
            updateProfile();

        }

       /// <summary>
       /// Updates the GUI using data contained in the character_sheet
       /// </summary>
        protected void updateProfile()
        {
            gui.loadFromCharactersheet(character_sheet);

            updatePortrait();
        }

       /// <summary>
       /// Updates the currently held driver_character sheet's.
       /// CharacterSheet trickles down from a higher level.
       /// </summary>
        public virtual void saveCharacter(CharacterSheet tmpChar)
        {
            if (tmpChar == null)
                tmpChar = gui.UpdatedCharacterSheet();

            character_sheet.FirstName = tmpChar.FirstName;
            character_sheet.LastName = tmpChar.LastName;
            character_sheet.Age = tmpChar.Age;
            character_sheet.Race = tmpChar.Race;
            character_sheet.Gender = tmpChar.Gender;
            character_sheet.Weight = tmpChar.Weight;
            character_sheet.Height = tmpChar.Height;
            character_sheet.Description = tmpChar.Description;
        }

       /// <summary>
       /// Saves the XML file to the local directory
       /// </summary>
        public void save_XML()
        {
            if (!System.IO.Directory.Exists(System.IO.Path.GetDirectoryName(Application.ExecutablePath) + @"\Characters\" + get_UserName() + @"\"))
            {
                System.IO.Directory.CreateDirectory(System.IO.Path.GetDirectoryName(Application.ExecutablePath) + @"\Characters\" + get_UserName() + @"\");
            }

            String file_path = System.IO.Path.GetDirectoryName(Application.ExecutablePath) + @"\Characters\" + get_UserName() + @"\" + character_sheet.FirstName + "_" + character_sheet.LastName + ".xml";
            Serialization.xml_serialize(character_sheet, character_sheet.GetType(), file_path);
        }

       /// <summary>
       /// Closes the Character Detals window when select buttons are clicked
       /// </summary>
       /// <param name="sender">Some button</param>
       /// <param name="e">N/A</param>
        public void closeWindow(object sender, EventArgs e)
        {
            saveCharacter(gui.UpdatedCharacterSheet());
            save_XML();
            gui.Hide();
        }

       /// <summary>
       /// Used to load a character from a character sheet.  Updates both the backend and front end.
       /// </summary>
       /// <param name="input_sheet">Character sheet to load</param>
        virtual public void loadCharacterFromSheet(CharacterSheet input_sheet)
        {
            saveCharacter(input_sheet);
            updateProfile();
        }

    }
}
