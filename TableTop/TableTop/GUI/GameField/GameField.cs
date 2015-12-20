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
using TableTop.GUI.GameField.Tiles;
using TableTop.GUI.Portrait_Controls;

namespace TableTop.GUI.GameField
{
    public partial class GameField : Form
    {
        //BaseTile [][] tiles;
        TileController tiles;
        MainGUI main;
        PlayerController player;

        public GameField(MainGUI main, PlayerController player)
        {
            this.main = main;
            this.player = player;

            InitializeComponent();
            TopLevel = false;
            Dock = DockStyle.Fill;
            AutoScroll = true;
            SuspendLayout();

            int columns = 50;
            int rows = 50;
            int squareSize = 100;

            tiles = new TileController(rows, columns);

            TableLayoutPanel layout = new TableLayoutPanel();
            layout.RowCount = rows;
            layout.ColumnCount = columns;

            layout.Width = squareSize * columns;
            layout.Height = squareSize * rows;

            for (int i = 0; i < rows; i++)
                layout.RowStyles.Add(new RowStyle(SizeType.Absolute, squareSize));

            for (int i = 0; i < columns; i++)
                layout.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, squareSize));

            for (int i = 0; i < rows; ++i) //y
            {
                for (int j = 0; j < columns; ++j) //x
                {
                    layout.Controls.Add(tiles.tiles[i][j].getTile()); 
                }
            }

            Image im = Image.FromFile(@"C:\Users\Outsider\Desktop\TableTop\Images\Sprites\Rydia.png");
            
            tiles.tiles[0][1].imageToPaint(im);

            Point t = tiles.tiles[0][1].getTile().Location;
            FlowLayoutPanel tempP = new FlowLayoutPanel();

            tempP.FlowDirection = FlowDirection.TopDown;
            tempP.MinimumSize = new Size(200, 100);
            tempP.MaximumSize = new Size(200, 600);
            tempP.AutoSize = true;
            tempP.Location = new Point(t.X + squareSize, t.Y + squareSize);
            tempP.Width = 200;
            tempP.BackColor = Color.Red;

            Label lbl = new Label();
            lbl.Text = "Hurp";
            tempP.Controls.Add(lbl);

            lbl = new Label();
            lbl.Text = "Derp";
            tempP.Controls.Add(lbl);

            lbl = new Label();
            lbl.Text = "Xert";
            tempP.Controls.Add(lbl);

            lbl = new Label();
            lbl.Text = "Meh";
            tempP.Controls.Add(lbl);

            tempP.Show();
            Controls.Add(tempP);
            lbl = new Label();
            lbl.Text = "Derp";
            tempP.Controls.Add(lbl);

            lbl = new Label();
            lbl.Text = "Xert";
            tempP.Controls.Add(lbl);

            lbl = new Label();
            lbl.Text = "Meh";
            tempP.Controls.Add(lbl);

            tempP.Show();
            Controls.Add(tempP);
            lbl = new Label();
            lbl.Text = "Derp";
            tempP.Controls.Add(lbl);

            lbl = new Label();
            lbl.Text = "Xert";
            tempP.Controls.Add(lbl);

            lbl = new Label();
            lbl.Text = "Meh";
            tempP.Controls.Add(lbl);

            tempP.Hide();
            Controls.Add(tempP);

            Controls.Add(layout);
            layout.Show();
            ResumeLayout();

            Serialization.xml_serialize(tiles, typeof(TileController), @"C:\Users\Outsider\Documents\GitHub\TableTop\TableTop\TableTopServer\bin\Debug\Maps\my_map.xml");
        }
    }
}
