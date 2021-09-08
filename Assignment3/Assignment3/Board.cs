using System;
using static System.Console;
namespace Assignment3
{
    class Board
    {
        // Default height and width of the board
        private const int LENGTH = 20;

        // Width property
        public int Width { get; set; }

        // Height property
        public int Height { get; set; }

        // Cells property
        public char[,] Cells { get; set; }

        static DateTime now = DateTime.Now;
        static int s = now.Second;

        private void Init()
        {
            /*
             * Init method to create a 2-D array of characters, 
             * set all cells to space characters
             */
            Console.Clear();
            Cells = new char[Height, Width];
            for (int i = 0; i < Height; i++)
            {
                for (int j = 0; j < Width; j++)
                {
                    Cells[i, j] = ' ';
                }
            }
        }

        
        public Board(int height, int width)
        {
            /*
             * Constructor to create a board with height and width
             */
            Width = width;
            Height = height;
            Init();
        }

        public Board()
        {
            /*
             * Constructor to create a board with default height(20) and width(20)
             */
            Width = LENGTH;
            Height = LENGTH;
            Init();
        }

        public void Clear()
        {
            /*
             * Set all cells to space characters
             */
            for (int i = 0; i < Height; i++)
            {
                for (int j = 0; j < Width; j++)
                {
                    Cells[i, j] = ' ';
                }
            }
        }

        public void Print()
        {
            /*
             * Print all cells of the board
             */

            SetCursorPosition(0, 0);
            for (int i = 0; i < Height; i++)
            {
                for (int j = 0; j < Width; j++)
                {
                    Write(Cells[i, j]);
                }
                WriteLine();
            }
        }

        private static Boolean eachSecond()                     //function that returns true for each second that passed
        {
            DateTime currentTime = DateTime.Now;

            int newNow = currentTime.Second;
            Boolean status = false;
            if (newNow != s)                           // if time updated
            {
                s = newNow;                                //updated second value stored
                status = true;
            }
            return status;
        }

        public static char[,] createTemp(char[,] array)
        {
            int A = array.GetLength(0);
            int B = array.GetLength(1);

            char[,] temp = new char[A, B];
            for(int i=0; i<A; i++)
            {
                for(int j=0; j<B; j++)
                {
                    temp[i, j] = array[i, j];
                }
            }

            return temp;

        }
        public static int calcNeighbour( char[,] temp,int A, int B)
        {
            int row = temp.GetLength(0);
            int col = temp.GetLength(1);
            int score = 0;
            int tempA, tempB;
            
            for(int i = -1; i<2; i++)
            {
                for(int j=-1; j<2; j++)
                {
                    if (i == 0 && j == 0)
                        continue;

                    tempA = (A + i) % 10;
                    tempB = (B + j) % 10;
                    if (tempA < 0)
                        tempA = row - 1;
                    if(tempB < 0)
                        tempB = col - 1;

                    if (temp[tempA, tempB] == '#')
                        score++;

                }
            }
            
            return score;
        }

        public static void Main()
        {
            

            Board board = new Board(10, 10);
            board.Cells[0, 2] = '#';
            board.Cells[1, 3] = '#';
            board.Cells[2, 1] = '#';
            board.Cells[2, 2] = '#';
            board.Cells[2, 3] = '#';



            board.Print();

           while(true)
            {
                if(eachSecond())
                {
                    char[,] temp = new char[board.Cells.GetLength(0), board.Cells.GetLength(1)];
                    for(int i=0; i<board.Cells.GetLength(0); i++)
                    {
                        for (int j = 0; j < board.Cells.GetLength(1); j++)
                        {
                            temp[i, j] = ' ';
                            if (board.Cells[i, j] == ' ')
                            {
                                if (calcNeighbour(board.Cells, i, j) == 3)
                                {
                                    temp[i, j] = '#';
                                }
                                else
                                    temp[i, j] = ' ';

                            }
                            else if (board.Cells[i, j] == '#')
                            {
                                if ((calcNeighbour(board.Cells, i, j) == 3) || (calcNeighbour(board.Cells, i, j) == 2))
                                {
                                    temp[i, j] = '#';
                                }
                                else
                                    temp[i, j] = ' ';
                            }
                            
                        }
                    }
                    board.Cells = createTemp(temp);
                    board.Print();

                  
                }
            }
            

            ReadKey();
        }

    }
}
