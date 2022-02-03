using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tictacoe
{
    public class Ttictactoe
    {
        public char[] CreateBoard()
        {
            char[] board = new char[10];
            for(int i = 0; i<board.Length; i++)
            {
                board[i] = ' ';
            }
            return board;
        }
    }
}
