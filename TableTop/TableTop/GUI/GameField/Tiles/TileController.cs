using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TableTop.GUI.GameField.Tiles
{
    public class TileController
    {
        public BaseTile[][] tiles;
        public int X;
        public int Y;

        public TileController()
        {

        }

        public TileController(int x, int y)
        {
            X = x;
            Y = y;
            constructTiles();
        }

        public void constructTiles()
        {
            tiles = new BaseTile[Y][];

            for (int i = 0; i < Y; ++i)
            {
                tiles[i] = new BaseTile[X];
                for (int j = 0; j < X; ++j)
                {
                    tiles[i][j] = new BaseTile();
                }
            }

            for (int i = 0; i < tiles.Count(); ++i)
            {
                for (int j = 0; j < tiles[i].Count(); ++j)
                {
                    tiles[i][j].buildTile();
                }
            }
        }
    }
}
