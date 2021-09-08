using System;
using static System.Console;

namespace CSIS1175Demo08
{
    class Demo08
    {
        static void Main(string[] args)
        {
            int[] scores = new int[5];
            for( int i = 0;i<5;i++)
            {
                Write("Please Enter YOur SCore >> ");
                scores[i] = int.Parse(ReadLine());

            }
            foreach (int score in scores)
                WriteLine(score);
            ReadKey();

        }
    }
}
