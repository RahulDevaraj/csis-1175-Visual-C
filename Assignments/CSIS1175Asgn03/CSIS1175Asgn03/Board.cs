using System;
using System.IO;
using static System.Console;

namespace CSIS1175Asgn03
{
    class Board
    {
        // Default height and width of the board
        private const int LENGTH = 20;
        private const string PATH = "../../Input.txt";

        // Width property
        public int Width { get; set; }

        // Height property
        public int Height { get; set; }

        // Cells property
        public char[,] Cells { get; set; }


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
            int s = currentTime.Second;
            int newNow = 0;
            Boolean status = false;

            do
            {
                DateTime instaTime = DateTime.Now;
                newNow = instaTime.Second;

            } while (s == newNow);


            if (newNow != s)                           // if time updated
            {
                
                status = true;
               
            }
            return status;
        }
        public static void readBoardDimensions(ref int A , ref int B)   //For getting the board dimensions
        {
            try
            {
                StreamReader read = new StreamReader(PATH);
                
                A = int.Parse(read.ReadLine());
                B = int.Parse(read.ReadLine());

                read.Close();

            }
            catch(IOException e)
            {
                WriteLine(e.Message);
            }

        }

        public void setBoard()    //for setting the cells initially
        {
            try
            {
                StreamReader read = new StreamReader(PATH);
                string line;
                string[] elements;

                read.ReadLine();            //skipping first 2 lines
                read.ReadLine();

                while((line = read.ReadLine()) != null)     //Read through the file and set the cells
                {
                    elements = line.Split(' ');
                    int A = int.Parse(elements[0]);
                    int B = int.Parse(elements[1]);

                    Cells[A, B] = '#';


                }
              

                read.Close();

            }
            catch (IOException e)
            {
                WriteLine(e.Message);
            }

        }

        public static int calcNeighbour(char[,] temp, int A, int B)     //For calculating how many neighbors are having # value
        {
            int row = temp.GetLength(0);
            int col = temp.GetLength(1);
            int score = 0;                      //this denotes number of neighboring #
            int tempA, tempB;

            for (int i = -1; i < 2; i++)
            {
                for (int j = -1; j < 2; j++)
                {
                    if (i == 0 && j == 0)       //Ignoring the element itself
                        continue;

                    tempA = (A + i) % row;      // Condition for overshoot
                    tempB = (B + j) % col;      // Condition for overshoot
                    if (tempA < 0)              // Condition for overshoot
                        tempA = row - 1;
                    if (tempB < 0)              // Condition for undershoot
                        tempB = col - 1;

                    if (temp[tempA, tempB] == '#')
                        score++;

                }
            }

            return score;
        }
        public void Play()      //Fn for generating the ScreenSaver
        {
            while (true)
            {
                if (eachSecond())       //In each Second
                {
                    char[,] temp = new char[Cells.GetLength(0), Cells.GetLength(1)];        //To store generated neighbours
                    for (int i = 0; i < Cells.GetLength(0); i++)
                    {
                        for (int j = 0; j < Cells.GetLength(1); j++)
                        {
                            
                            if (Cells[i, j] == ' ')
                            {
                                if (calcNeighbour(Cells, i, j) == 3)        //Condition for new neighbour
                                {
                                    temp[i, j] = '#';
                                }
                                else
                                    temp[i, j] = ' ';

                            }
                            else if (Cells[i, j] == '#')
                            {
                                if ((calcNeighbour(Cells, i, j) == 3) || (calcNeighbour(Cells, i, j) == 2))     //Condition for new neighbour
                                {
                                    temp[i, j] = '#';
                                }
                                else
                                    temp[i, j] = ' ';
                            }

                        }
                    }

                    Cells = temp;       //Update Cells

                    Print();


                }
            }
        }


    }
}
