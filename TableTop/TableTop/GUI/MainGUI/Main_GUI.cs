namespace TableTop
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Data;
    using System.Drawing;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.Windows.Forms;
    using Character;
    using TableTop.GUI;
    using TableTopServer.WCF_Service;
    using TableTop.GUI.GameField;
    using TableTop.GUI.Portrait_Controls;
    using TableTop.GUI.CharacterForms;
    using TableTop.GUI.MainGUI.BottomSection;

    public partial class Main_GUI : Form
    {
        public Main_GUI()
        {
            InitializeComponent();

            TopLevel = false;
            FormBorderStyle = FormBorderStyle.None;
            Dock = DockStyle.Fill;
        }

        public void AddPortraitGUI(Portraits_GUI input)
        {
            PortraitPane.Controls.Add(input);
            input.Show();
        }

        public void AddCharacterForm(Character_Form input)
        {
            Controls.Add(input);
        }

        public void AddGameField(Game_Field field)
        {
            GameGrid.Controls.Add(field);
            field.Show();
        }

        public void AddBottomPane(BottomSection_GUI bottomPane)
        {
            ChatPane.Controls.Add(bottomPane);
            bottomPane.Show();
        }
    }
}
