using System;
using static System.Console;


namespace MidTermExam2
{
    class Q2
    {
        static bool ValidateUPC(string upc)           //Function to Validate UPC
        {

            int len = 12,sum = 0, rem;
            int checkDigit = upc[11] - '0';         //Conv a single  char to digit
            int derivedCheckDigit;
            for(int i = 0; i< len; i++)                 //Sum of Odd Positions
            {
                
                if(i %2 == 0)
                {
                    sum += (upc[i] - '0');
                }
            }

            sum *= 3;                                   //Sum multiplied by 3

            for(int i = 0; i < len - 1; i++)            //Sum of even excluding CheckDigit
            {
                if (i % 2 != 0)
                {
                    sum += (upc[i] - '0');
                }
            }

            rem = sum % 10;                 

            if (rem == 0)
                derivedCheckDigit = 0;
            else
                derivedCheckDigit = 10 - rem;


            if (derivedCheckDigit == checkDigit)            //Comparing both checkDigits
                return true;
            else
                return false;

           
        }
        static void Main(string[] args)
        {
            string upc;                         //To store input string
            while (true)
            {
                Write("Enter an UPC >> ");
                upc = ReadLine();
                if(ValidateUPC(upc))        //To check if valid
                {
                    WriteLine("The UPC is valid.");
                    break;
                }
                else
                {
                    WriteLine("The UPC is invalid.");
                }
            }
            ReadKey();
        }
    }
}
