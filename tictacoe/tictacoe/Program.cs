// See https://aka.ms/new-console-template for more information
using Tictacoe;

Console.WriteLine("Hello, World!");
Ttictactoe game = new Ttictactoe();
char[] board = game.CreateBoard();
game.Letter();
game.ViewBoard(board);