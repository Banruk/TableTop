namespace TableTop.GUI.CharacterForms
{
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
    using TableTop.Misc;

    /// <summary>
    /// The baseline for all Character Detail windows.  This is meant to be extended.
    /// </summary>
    public partial class Character_Form : Form, Character_Form_Interface
    {
        /*
         * Todo: consider pulling out the base details section into it's own class so it can be reused.
         */

        /// <summary>
        /// A display of this character's portrait.  This pane serves as the button for making the character details window visible on the main GUI
        /// </summary>
        protected Panel portrait_pane = null;

        /// <summary>
        /// Begin initialization
        /// </summary>
        public Character_Form()
        {
            TopLevel = false;
            InitializeComponent();
            buildPortraitPane();
            Hide();
        }

        /// <summary>
        /// Initializes components, linking the controller's methods to the events.
        /// </summary>
        /// <param name="controller">An interfaced reference to the GUI's controller</param>
        public void initialize(Character_Form_Controller_Interface controller)
        {
            TopLevel = false;
            TabStop();
            buildPortraitPane();

            CloseButton.Click += controller.closeWindow;
            LoadCharacterButton.Click += controller.loadCharacter;

            LoadPortraitButton.Click += controller.loadImage;
            LoadSpriteButton.Click += controller.loadImage;
            portrait_pane.Click += controller.portraitClick;

        }

        /// <summary>
        /// Build's the portrait_pane
        /// </summary>
        protected void buildPortraitPane()
        {
            portrait_pane = new Panel();
            portrait_pane.Width = 150;
            portrait_pane.Height = 150;

            portrait_pane.BackColor = Colors.ConvertColor(System.Configuration.ConfigurationManager.AppSettings["emptyPortraitColor"]);
            portrait_pane.Margin = new Padding(16);
        }

        /// <summary>
        /// Loads data from a character sheet into the character detail GUI components.
        /// </summary>
        /// <param name="character">CharacterSheet to load character data from</param>
        virtual public void loadFromCharactersheet(CharacterSheet character)
        {
            FirstName.Text = character.FirstName;
            LastName.Text = character.LastName;
            Age.Text = character.Age;
            Race.Text = character.Race;
            Gender.Text = character.Gender;
            Weight.Text = character.Weight;
            Height.Text = character.Height;
            Description.Text = character.Description;

            if (character.portrait != null)
            {
                portrait_pane.BackColor = Color.Transparent;
                portrait_pane.BackgroundImage = character.portrait;

                PortraitWindow.BackColor = Color.Transparent;
                PortraitWindow.BackgroundImage = character.portrait;
            }
        }

        /// <summary>
        /// Constructs a CharacterSheet containing the updated UI infromation
        /// </summary>
        /// <param name="tempSheet">A CharacterSheet started at a higher level (if not null)</param>
        /// <returns>Updated CharacterSheet information</returns>
        virtual public CharacterSheet UpdatedCharacterSheet(CharacterSheet tempSheet = null)
        {
            if (tempSheet == null)// Should never happen at the this level
                tempSheet = new CharacterSheet();

            tempSheet.FirstName = FirstName.Text;
            tempSheet.LastName = LastName.Text;
            tempSheet.Age = Age.Text;
            tempSheet.Race = Race.Text;
            tempSheet.Gender = Gender.Text;
            tempSheet.Weight = Weight.Text;
            tempSheet.Height = Height.Text;
            tempSheet.Description = Description.Text;
            return tempSheet;
        }

        /// <summary>
        /// Makes the character details window visible
        /// </summary>
        public new void Show()
        {
            this.BringToFront();
            base.Show();
        }

        /// <summary>
        /// Updates the portrait for this character.
        /// </summary>
        /// <param name="portrait">portrait to update to</param>
        public void UpdatePortrait(Image portrait)
        {
            portrait_pane.BackColor = Color.Transparent;
            portrait_pane.BackgroundImage = portrait;

            PortraitWindow.BackColor = Color.Transparent;
            PortraitWindow.BackgroundImage = portrait;
        }

        /// <summary>
        /// Does exactly what's on the tin: returns the portrait_pane
        /// </summary>
        /// <returns></returns>
        public Panel getPortraitPane()
        {
            return portrait_pane;
        }

        /// <summary>
        /// Prevents Labels and Panels from become focusable when the user presses the Tab key
        /// </summary>
        public new void TabStop()
        {
            foreach (Control control in Controls)
            {
                if (control.GetType() == typeof(Label) || control.GetType() == typeof(Panel))
                {
                    control.TabStop = false;
                }
            }
        }
    }
}
