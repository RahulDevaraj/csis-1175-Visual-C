using System;
using static System.Console;


namespace Exam01
{
    class Ccbycs
    {
        public static decimal GetCCB(int age, decimal netIncome) //Function for CCB calculation
        {
            decimal result = 0m;
            if (age < 6 && netIncome <= 120000)
                result = 300m;
            if (age < 6 && netIncome > 120000)
                result = 150m;

            return result;
        }
        static void Main(string[] args)
        {
            int age;
            decimal netIncome;
            Write("Enter the age >> ");
            age = int.Parse(ReadLine());           //Getting Age
            Write("Enter the net income >> ");
            netIncome = decimal.Parse(ReadLine());   //Getting Income
            WriteLine("Your CCBYCS is ${0}.", GetCCB(age, netIncome));   //Printing Results
            ReadKey();
        }
    }
}
