using System;
using System.Collections.Generic;
using System.Linq;
using static System.Console;

namespace MidTerm_Practice
{
    class Q2
    {
        public static int Least3(out int n1, out int n2, out int n3, out double avg)
        {
            int total = 0;
            n1 = 0;
            n2 = 0;
            n3 = 0;
            avg = 0;
            int number,count = 0;
            List<int> array = new List<int>();
            

            while (true)
            {
                Write("Enter an integer or 999 to end >> ");
                number = int.Parse(ReadLine());
                if (number == 999)
                    break;
                else
                {
                    array.Add(number);
                    count++; 
                }
                    

            }
            

            if(count > 2)
            {
                array.Sort();
                n1 = array[0];
                n2 = array[1];
                n3 = array[2];
                total = array.Sum();
                avg =  total/ (double)count;
            }
            return count;
        }

        static void Main(string[] args)
        {
            int n1, n2, n3, count;
            double avg;
            while(true)
            {
                count = Least3(out n1, out n2, out n3, out avg);
                if (count < 3)
                {
                    WriteLine("Please Enter more than 3 numbers. Restart!");
                }
                else
                {
                    WriteLine("The three least numbers are :{0}, {1} and {2}", n1, n2, n3);
                    WriteLine("The average of the numbers is "+ Math.Round(avg, 3).ToString("N3"));
                    break;
                }
            }

            ReadKey();
            
        }
    }
}
