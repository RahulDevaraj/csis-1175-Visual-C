using System;
using static System.Console;

namespace MockMid
{
    class GPA
    {
        public static void GPAFunc()
        {
            string grade = " ";
            double hours = 0, sumHours = 0, quality = 0, sumQuality = 0;
            decimal finalGPA = 0;

            while (true)
            {
                Write("Enter your next grade or Z to end: ");
                grade = ReadLine();
                if (grade == "Z")
                    break;
                Write("Enter your credit hours: ");
                hours = double.Parse(ReadLine());
                if (grade == "A" || grade == "A+")
                    quality = 4;
                else if (grade == "A-")
                    quality = 3.7;
                else if (grade == "B+")
                    quality = 3.3;

                else if (grade == "B")
                    quality = 3;
                else if (grade == "B-")
                    quality = 2.7;
                else if (grade == "C+")
                    quality = 2.3;
                else if (grade == "C")
                    quality = 2;
                else if (grade == "C-")
                    quality = 1.7;
                else if (grade == "D+")
                    quality = 1.3;
                else if (grade == "D")
                    quality = 1;
                else if (grade == "D-")
                    quality = 0.7;
                else
                    quality = 0;





                quality *= hours;
                sumHours += hours;
                sumQuality += quality;






            }


            WriteLine("Your total credit hours earned: {0:0.##} ", sumHours);


            if (sumQuality == 0)
            {
                Write("Your GPA: {0:0.##} ", quality);
            }
            else
            {
                finalGPA = (decimal)(sumQuality / sumHours);

                Write("Your GPA: {0} ", Math.Round(finalGPA, 2, MidpointRounding.AwayFromZero));
            }


            ReadKey();
        }

        public static void TriangleFunction()
        {
            int size;
            bool status = false;

            Write("Enter Size of Triangle >> ");
            status = int.TryParse(ReadLine(), out size);
            if (status != true)
                size = 5;

            if (size > 10)
                size = 4;

            for(int i=0; i<size; i++)
            {
                for (int j = i; j < size - 1; j++)
                    Write(" ");

                for (int k = i + 1; k > 0; k--)
                    Write("*");

                WriteLine();

            }
            ReadKey();

        }
        static void Main(string[] args)
        {
            //GPAFunc();
            TriangleFunction();
        }

        
    }
}
