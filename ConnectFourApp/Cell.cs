using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConnectFourApp
{
    class Cell
    {
        public int row { get; set; }
        public int column { get; set; }
        //0:white 1:red 2:yellow
        public int color { get; set; }
        public Cell(int x, int y)
        {
            color = 0;
            row = y;
            column = x;
        }
    }
}
