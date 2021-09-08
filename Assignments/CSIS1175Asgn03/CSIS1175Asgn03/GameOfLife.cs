using System;
using static System.Console;


namespace CSIS1175Asgn03
{
    class GameOfLife
    {
        public static void Main()
        {

            int height = 0, width = 0;

            Board.readBoardDimensions(ref height, ref width);   //Reading the array Dimensions from file and assigning to Variables

            Board board = new Board(height, width);     //Board init

            board.setBoard();   //Get initial Board Values from File
            board.Print();  

            board.Play();       

            ReadKey();
        }
    }
}
