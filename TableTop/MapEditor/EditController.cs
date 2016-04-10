using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TableTop.GUI.GameField.Tiles;

namespace MapEditor
{
    public class EditController 
    {
        public TileController tiles;
        MapEditor.TileEditor editor;

        public EditController(MapEditor.TileEditor editor)
        {
            this.editor = editor;
        }

        public void newMap(int X, int Y, int Z)
        {
            destroyTiles();

            tiles = new TileController(X, Y, Z);
            setEditor();

        } // End newMap

        public void setEditor()
        {
            for (int k = 0; k < tiles.Z; k++)
            {
                for (int i = 0; i < tiles.Y; i++)
                {
                    for (int j = 0; j < tiles.X; ++j)
                    {
                        tiles.tiles[k][i][j].getTile().Click += editor.tileClick;
                    }
                }
            }
        } // End setEditor

        protected void destroyTiles()
        {
            editor.last_clicked = null;

            if (tiles == null)
                return;
            for (int k = 0; k < tiles.Z; k++)
            {
                for (int i = 0; i < tiles.Y; ++i)
                {
                    for (int j = 0; j < tiles.X; ++j)
                    {
                        tiles.tiles[k][i][j].getTile().Dispose();
                        tiles.tiles[k][i][j] = null;
                    }
                }
            }

            tiles = null;
        } // End destroyTiles
    }
}
