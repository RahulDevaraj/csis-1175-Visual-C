using System;
using static System.Console;

namespace CSIS1175Demo05
{
    class Demo05
    {
        static void Main(string[] args)
        {

            int n;
            n = int.Parse(ReadLine());
            

            for(int i=n;i>0;i--)
            {
                for(int j = i-1;j>0;j--)
                {
                    Write(" ");
                }
                for(int k = n-(i-1);k>0;k--)
                {
                    Write("#");
                }
                WriteLine();

            }
            ReadKey();
        }
        
    }
}
