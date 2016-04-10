using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace TableTop.GUI.GameField.Tiles
{
    public class BaseTile
    {
        public Boolean enterable_left;
        public Boolean enterable_right;
        public Boolean enterable_top;
        public Boolean enterable_bottom;
        public Boolean can_go_up;
        public Boolean can_go_down;
        [XmlIgnore]
        public Image background_image
        {
            get;
            private set;
        }
        public byte[] background
        {
            get
            {
                ImageConverter converter = new ImageConverter();
                return (byte[])converter.ConvertTo(background_image, typeof(byte[]));
            }
            set
            {
                ImageConverter converter = new ImageConverter();
                if(!String.IsNullOrEmpty(value.ToString()) && value.Count() > 1)
                    background_image = (Image)converter.ConvertFrom(value);
            }
        }

        [XmlIgnore]
        public Tile tile
        {
            get;
            private set;
        }

        public BaseTile()
        {
            tile = new Tile(this);
            tile.BackColor = Color.Transparent;
            enterable_bottom = true;
            enterable_left = true;
            enterable_right = true;
            enterable_top = true;
            can_go_down = false;
            can_go_up = false;
            tile.Refresh();
        }

        public void imageToPaint(Image i)
        {
            background_image = i;
            tile.paintImage();
        }

        public Tile getTile()
        {
            return tile;
        }

        public void buildTile()
        {
            tile = new Tile(this);
        }


        public class Tile : Panel
        {
            BaseTile gui;

            public Tile(BaseTile above)
            {
                gui = above;
                Width = 100;
                Height = 100;
                BackColor = Color.ForestGreen;
                Margin = new Padding(0);

                Show();
            }

            protected override void OnPaint(PaintEventArgs e)
            {
                base.OnPaint(e);

                if (gui.background_image != null)
                {
                    BackgroundImage = gui.background_image;
                }
                else
                {
                    BackColor = Color.SkyBlue;
                }
                //e.Graphics.DrawImage(gui.image, new Point(0, 0));
                using (SolidBrush brush = new SolidBrush(Color.Transparent))
                    e.Graphics.FillRectangle(brush, ClientRectangle);
                e.Graphics.DrawRectangle(Pens.Black, 0, 0, ClientSize.Width - 1, ClientSize.Height - 1);
            }

            public void paintImage()
            {
                Refresh();
            }

            public BaseTile getBaseTile()
            {
                return gui;
            }

        } // End Tile
    }
}
