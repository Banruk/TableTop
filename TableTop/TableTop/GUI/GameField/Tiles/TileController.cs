using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TableTop.GUI.GameField.Tiles
{
    public class TileController
    {
        public BaseTile[][][] tiles;
        public int X;
        public int Y;
        public int Z;

        public TileController()
        {

        }

        public TileController(int x, int y, int z)
        {
            X = x;
            Y = y;
            Z = z;
            constructTiles();
        }

        public void constructTiles()
        {
            tiles = new BaseTile[Z][][];

            for (int k = 0; k < Z; k++)
            {
                tiles[k] = new BaseTile[Y][];
                for (int i = 0; i < Y; ++i)
                {
                    tiles[k][i] = new BaseTile[X];
                    for (int j = 0; j < X; ++j)
                    {
                        tiles[k][i][j] = new BaseTile();
                    }
                }
            }
            for (int k = 0; k < tiles.Count(); k++)
            {
                for (int i = 0; i < tiles[k].Count(); ++i)
                {
                    for (int j = 0; j < tiles[k][i].Count(); ++j)
                    {
                        tiles[k][i][j].buildTile();
                    }
                }
            }
        } // End constructTiles
    }
}
