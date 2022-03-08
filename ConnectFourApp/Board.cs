using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConnectFourApp
{
    class Board
    {
        public int SizeW { get; set; }
        public int SizeH { get; set; }

        public Cell[,] table { get; set; }

        public Board(int size1, int size2)
        {
            SizeW = size1;
            SizeH = size2;

            table = new Cell[SizeW, SizeH];

            for (int i = 0; i < SizeW; i++)
            {
                for (int j = 0; j < SizeH; j++)
                {
                    table[i, j] = new Cell(i, j);
                }
            }
        }
    }
}
