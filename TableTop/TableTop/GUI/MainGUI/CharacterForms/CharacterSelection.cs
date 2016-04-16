using Shared_Resources;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TableTop.GUI.CharacterForms
{
    public partial class CharacterSelection : Form
    {
        /// <summary>
        /// Delegate to the method that loads a character's XML file
        /// </summary>
        public takes_string load_xml;
        /// <summary>
        /// Delegate to get the game mode
        /// </summary>
        public returns_string get_gameMode;

        public CharacterSelection()
        {
            InitializeComponent();

            TopLevel = false;

            CharacterSelectionBox.Padding = new Padding(10);

            LoadButton.Click += LoadButton_Click;
            CancelButton.Click += CloseButton_Click;
        }

        /// <summary>
        /// Fills the Selection screen's XML selection portion with file names
        /// </summary>
        public void LoadSelections()
        {
            String filePath = System.IO.Path.GetDirectoryName(Application.ExecutablePath) + @"\Characters\" + get_gameMode();

            if (!Directory.Exists(filePath))
            {
                Directory.CreateDirectory(filePath);
            }

            CharacterSelectionBox.DataSource = null;
            String reg = @"[^\\]*[.]xml$";

            List<MyListItem> selections = new List<MyListItem>();

            foreach (String t in System.IO.Directory.GetFiles(filePath, "*.xml"))
            {
                MyListItem list = new MyListItem();
                list.Text = Regex.Match(t, reg).Value;
                list.Tag = t;
                selections.Add(list);
            }

            CharacterSelectionBox.DataSource = selections;
        }

        /// <summary>
        /// Handles load button click
        /// </summary>
        /// <param name="sender">Yup</param>
        /// <param name="e">Whatever</param>
        protected void LoadButton_Click(object sender, EventArgs e)
        {
            String selected = ((MyListItem)CharacterSelectionBox.SelectedItem).Tag.ToString();
            load_xml(selected);
            Hide();
        }

        /// <summary>
        /// Handles close window button click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void CloseButton_Click(object sender, EventArgs e)
        {
            Hide();
        }

        /// <summary>
        /// Called to show the selection gui
        /// </summary>
        public new void Show()
        {
            LoadSelections();
            BringToFront();
            base.Show();
        }

        /// <summary>
        /// I think I needed to extend ListViewItem to force returning Text from ToString or something
        /// </summary>
        class MyListItem : ListViewItem
        {
            public override string ToString()
            {
                return Text;
            }
        }
    }
}
