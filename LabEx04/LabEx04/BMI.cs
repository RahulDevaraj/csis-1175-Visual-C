using System;
using static System.Console;


namespace LabEx04
{
    class BMI
    {
        public static double CalculateBMI(double W, double H)
        {
            return (Math.Round((W/(H*H)),2));
        }
        public static string GetBMIStatus(double BMI)
        {
            string status;
            if (BMI < 18.5)
                status = "Under Weight";
            else if (BMI >= 18.5 && BMI <= 24.9)
                status = "Normal";
            else if ((BMI >= 25 && BMI <= 29.9))
                status = "Over Weight";
            else
                status = "Obese";

            return status;
        }
        static void Main(string[] args)
        {
            double W, H;
            Write("Enter your weight in KG >> ");
            W = double.Parse(ReadLine());

            Write("Enter your height in Meter >> ");
            H = double.Parse(ReadLine());

            double BMI = CalculateBMI(W,H);

            WriteLine("Your BMI is {0}. Your BMI status is {1}.",BMI,GetBMIStatus(BMI));

            ReadKey();

        }
    }
}
