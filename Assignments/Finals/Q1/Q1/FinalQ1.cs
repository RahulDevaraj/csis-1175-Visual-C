using System;
using static System.Console;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q1
{
    class FinalQ1
    {
        static void Main(string[] args)
        {
            int score=0,tempScore,num=0;    //Variables to store result
            for(int i=500; i<=1000; i++)    // Loop for 500 to 1000
            {
                tempScore = ComputeThreeNPlusOne(i);
                if (tempScore > score)      //Finding the number
                {
                    score = tempScore;
                    num = i;
                }
            }
            WriteLine("The number is {0} and the number of steps are {1}", num, ComputeThreeNPlusOne(num)); //Printing Result
            ReadKey();
        }
        static int ComputeThreeNPlusOne(int n)
        {
            int steps = 0;  //For steps

            while(true)
            {
                if (n % 2 == 0)     //Condition 1
                    n /= 2;
                else
                    n = (3 * n) + 1;    //Condition 2

                steps++;
                if (n == 1)
                    return steps;   //Return
            }
        }
    }
}
