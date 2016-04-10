using Shared_Resources;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TableTop.GUI.GameField.Tiles;

namespace MapEditor
{
    public partial class MapEditor : Form
    {
        EditController tileController;
        TableLayoutPanel [] layout;
        TileEditor tileEditor;

        public MapEditor()
        {
            InitializeComponent();
            tileEditor = new TileEditor(this);
            tileController = new EditController(tileEditor);

            createMapButton.Click += createMapButton_click;
            saveMapButton.Click += saveMapButton_Click;
            loadMapButton.Click += loadMapButton_Click;
            
            rotateRight.Click += tileEditor.rotateRight;
            rotateLeft.Click += tileEditor.rotateLeft;

            enterableTop.Click += tileEditor.enterable_click;
            enterableBottom.Click += tileEditor.enterable_click;
            enterableLeft.Click += tileEditor.enterable_click;
            enterableRight.Click += tileEditor.enterable_click;
            canGoUp.Click += tileEditor.enterable_click;
            canGoDown.Click += tileEditor.enterable_click;

            String t = Path.GetDirectoryName(Application.ExecutablePath) + @"\Tiles\";

            if (Directory.Exists(Path.GetDirectoryName(Application.ExecutablePath) + @"\Tiles\"))
            {
                foreach (String file in Directory.GetFiles(Path.GetDirectoryName(Application.ExecutablePath) + @"\Tiles\"))
                {
                    BackgroundPanel pane = new BackgroundPanel(Image.FromFile(file));
                    pane.Click += tileEditor.backgroundImageClick;
                    BackgroundPanel.Controls.Add(pane);
                }
            }
            else
            {
                BackgroundPanel.BackColor = Color.Red;
            }

        }

        public void setUpLayout(int X, int Y, int Z)
        {
            mapTabPanel.SuspendLayout();

            if (mapTabPanel.TabPages.Count > 0)
            {
                for (int i = mapTabPanel.Controls.Count-1; i >= 0; i--)
                {
                    mapTabPanel.Controls.RemoveAt(i);
                }
            }

            layout = new TableLayoutPanel[Z];

            for (int k = 0; k < Z; k++)
            {
                layout[k] = new TableLayoutPanel();
                layout[k].SuspendLayout();
                layout[k].RowCount = Y;
                layout[k].ColumnCount = X;

                layout[k].Width = 100 * X;
                layout[k].Height = 100 * Y;

                for (int i = 0; i < Y; i++)
                    layout[k].RowStyles.Add(new RowStyle(SizeType.Absolute, 100));

                for (int i = 0; i < X; i++)
                    layout[k].ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 100));

                for (int i = 0; i < Y; ++i) //y
                {
                    for (int j = 0; j < X; ++j) //x
                    {
                        layout[k].Controls.Add(tileController.tiles.tiles[k][i][j].getTile());
                    }
                }

                layout[k].Show();
                layout[k].ResumeLayout();

                TabPage tempPage = new TabPage();
                tempPage.SuspendLayout();
                tempPage.Text = k.ToString();
                tempPage.Controls.Add(layout[k]);
                tempPage.Show();
                tempPage.ResumeLayout();

                mapTabPanel.TabPages.Add(tempPage);
            }
            mapTabPanel.ResumeLayout();
        } // End setUpLayout

        public void createMapButton_click(object sender, EventArgs e)
        {
            int X;
            int Y;
            int Z;

            if (Int32.TryParse(sizeXInput.Text.ToString(), out X))
            {
                sizeXInput.BackColor = Color.White;
            }
            else
            {
                sizeXInput.BackColor = Color.Orange;
                return;
            }

            if (Int32.TryParse(sizeYInput.Text.ToString(), out Y))
            {
                sizeYInput.BackColor = Color.White;
            }
            else
            {
                sizeYInput.BackColor = Color.Orange;
                return;
            }

            if (Int32.TryParse(sizeZInput.Text.ToString(), out Z))
            {
                sizeYInput.BackColor = Color.White;
            }
            else
            {
                sizeYInput.BackColor = Color.Orange;
                return;
            }

            tileController.newMap(X, Y, Z);

            setUpLayout(X, Y, Z);

        } // End createMapButton_click

        public void saveMapButton_Click(object sender, EventArgs e)
        {
            SaveFileDialog save = new SaveFileDialog();

            save.Filter = "XML File|*.xml";
            save.Title = "Save Map";
            save.InitialDirectory = System.IO.Path.GetDirectoryName(Application.ExecutablePath);
            save.ShowDialog();

            if (save.FileName != "")
            {
                Serialization.xml_serialize(tileController.tiles, typeof(TileController), save.FileName);
            }
        }

        public void loadMapButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();

            dialog.Title = "Portrait Selection";
            dialog.Filter = "XML Files (*.xml) | *.xml";

            dialog.InitialDirectory = System.IO.Path.GetDirectoryName(Application.ExecutablePath);

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                String filename = dialog.FileName;

                tileController.tiles = (TileController)Serialization.xml_deserialize(typeof(TileController), filename);

                tileController.setEditor();

                setUpLayout(tileController.tiles.X, tileController.tiles.Y, tileController.tiles.Z);
            }

        }

        public class TileEditor 
        {
            public BaseTile last_clicked;
            MapEditor map;

            public TileEditor(MapEditor map)
            {
                this.map = map;
            }

            public void tileClick(object sender, EventArgs e)
            {
                last_clicked = ((BaseTile.Tile)sender).getBaseTile();
                map.enterableTop.Checked = last_clicked.enterable_top;
                map.enterableBottom.Checked = last_clicked.enterable_bottom;
                map.enterableLeft.Checked = last_clicked.enterable_left;
                map.enterableRight.Checked = last_clicked.enterable_right;
                map.canGoUp.Checked = last_clicked.can_go_up;
                map.canGoDown.Checked = last_clicked.can_go_down;

                map.selectedTile.BackgroundImage = last_clicked.background_image;
            }

            public void backgroundImageClick(object sender, EventArgs e)
            {
                if (last_clicked != null)
                {
                    
                    last_clicked.imageToPaint((Image)((BackgroundPanel)sender).background.Clone());
                }
            }

            public void rotateRight(object sender, EventArgs e)
            {
                if (last_clicked != null)
                {
                    last_clicked.background_image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    last_clicked.imageToPaint((Image)last_clicked.background_image.Clone());
                    map.selectedTile.BackgroundImage = last_clicked.background_image;
                }
            }

            public void rotateLeft(object sender, EventArgs e)
            {
                if (last_clicked != null)
                {
                    last_clicked.background_image.RotateFlip(RotateFlipType.Rotate270FlipNone);
                    last_clicked.imageToPaint((Image)last_clicked.background_image.Clone());
                    map.selectedTile.BackgroundImage = last_clicked.background_image;
                }
            }

            public void enterable_click(object sender, EventArgs e)
            {
                if (last_clicked != null)
                {
                    last_clicked.enterable_top = map.enterableTop.Checked;
                    last_clicked.enterable_bottom = map.enterableBottom.Checked;
                    last_clicked.enterable_left = map.enterableLeft.Checked;
                    last_clicked.enterable_right = map.enterableRight.Checked;
                    last_clicked.can_go_down = map.canGoDown.Checked;
                    last_clicked.can_go_up = map.canGoUp.Checked;
                }
            }
        }
    } // End MapEditor
}
