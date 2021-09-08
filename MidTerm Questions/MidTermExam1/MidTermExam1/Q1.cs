using System;
using static System.Console;

namespace MidTermExam1
{
    class Q1
    {
        public static void PrintSolidTriangle(int size)          //Funcction to print Solid Triangle
        {
            for(int i=0;i<size;i++)
            {
                for(int j=0;j<size-i-1;j++)                     //Print Spaces
                {
                    Write(" ");
                }

                for(int k=0;k<(2*i)+1;k++)                      //Print #
                {
                    Write("#");
                }

                WriteLine(" ");
            }

        }

        public static void PrintEmptyTriangle(int size)          //Funcction to print Empty Triangle
        {
            for(int i=0;i<size;i++)
            {
                for (int j = 0; j < size - i - 1; j++)              //Print Spaces
                {
                    Write(" ");
                }
                if(i != size-1)                                      //If in last line print fully
                {
                    for (int k = 0; k < (2 * i) + 1; k++)
                    {
                        if (k == 0 || k == (2 * i))
                            Write("#");
                        else
                            Write(" ");
                    }
                }
                else
                {
                    for (int k = 0; k < (2 * i) + 1; k++)
                    {
                        Write("#");
                    }
                }
                
                WriteLine(" ");

            }
        }
        static void Main(string[] args)
        {
            int choice,size;
            WriteLine("Please choose:");
            WriteLine("1) Solid Triangle");
            WriteLine("2) Empty Triangle");

            choice = int.Parse(ReadLine());                //Choosing between Solid and Empty Traingles
            Write("Please enter the size >> ");
            size = int.Parse(ReadLine());                  //Number of ros of Triangle 

            if (choice == 1)
                PrintSolidTriangle(size);                  //Printing Solid Triangle
            else if (choice == 2)
                PrintEmptyTriangle(size);                   //Printing Empty Triangle

            ReadKey();
        }
    }
}
