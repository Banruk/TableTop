using Shared_Resources;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TableTop.GUI.CharacterForms
{
    public partial class CharacterSelection : Form
    {
        public takes_string load_xml;

        public CharacterSelection()
        {
            InitializeComponent();

            TopLevel = false;

            CharacterSelectionBox.Padding = new Padding(10);

            LoadButton.Click += LoadButton_Click;
            CancelButton.Click += CloseButton_Click;
        }

        public void LoadSelections()
        {
            String filePath = System.IO.Path.GetDirectoryName(Application.ExecutablePath) + @"\Characters\" + MainGUI.gameMode;

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

        protected void LoadButton_Click(object sender, EventArgs e)
        {
            String selected = ((MyListItem)CharacterSelectionBox.SelectedItem).Tag.ToString();
            load_xml(selected);
            Hide();
        }

        protected void CloseButton_Click(object sender, EventArgs e)
        {
            Hide();
        }

        public new void Show()
        {
            LoadSelections();
            BringToFront();
            base.Show();
        }

        class MyListItem : ListViewItem
        {
            public override string ToString()
            {
                return Text;
            }
        }
    }
}
