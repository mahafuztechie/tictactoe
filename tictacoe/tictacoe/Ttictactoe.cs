using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tictacoe
{
    public class Ttictactoe
    {
        char playerLetter, compLetter;
        public char[] CreateBoard()
        {
            char[] board = new char[10];
            for(int i = 0; i<board.Length; i++)
            {
                board[i] = ' ';
            }
            return board;
        }

        public char Letter()
        {
            // asking user for char
            Console.WriteLine("choose your letter either x or o");
            char playerLetter = Convert.ToChar(Console.ReadLine()[0]);
            if(playerLetter.Equals('x')|| playerLetter.Equals('o'))
            {
                //if user x assign o to computer
                if (playerLetter.Equals('x'))
                {
                    compLetter = 'o';
                }
                else
                {
                    compLetter = 'x';
                }
            }
            else
            {
                Console.WriteLine("enter valid charracter either x or o");
                //recursive call if its other letter
                Letter();
            }
            return playerLetter;
        }
    }
}
