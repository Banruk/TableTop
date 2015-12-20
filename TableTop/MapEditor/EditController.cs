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

        public void newMap(int X, int Y)
        {
            destroyTiles();

            tiles = new TileController(X, Y);
            setEditor();

        } // End newMap

        public void setEditor()
        {
            for (int i = 0; i < tiles.Y; i++)
            {
                for (int j = 0; j < tiles.X; ++j)
                {
                    tiles.tiles[i][j].getTile().Click += editor.tileClick;
                }
            }
        }

        protected void destroyTiles()
        {
            editor.last_clicked = null;

            if (tiles == null)
                return;

            for (int i = 0; i < tiles.Y; ++i)
            {
                for (int j = 0; j < tiles.X; ++j)
                {
                    tiles.tiles[i][j].getTile().Dispose();
                    tiles.tiles[i][j] = null;
                }
            }

            tiles = null;
        } // End destroyTiles
    }
}
