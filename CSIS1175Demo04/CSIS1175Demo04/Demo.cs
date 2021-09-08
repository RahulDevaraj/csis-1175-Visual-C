using System;
using static System.Console;


namespace CSIS1175Demo04
{
    class Demo
    {

        public static void TestDefault(int aValue)

        {

            aValue = 111;

            WriteLine("In TestDefault - Value: {0}", aValue);

        }
        public static void TestRef(ref int aValue)

        {

            aValue = 333;

            WriteLine("In TestRef - Value: {0}", aValue);

        }

        public static void TestOut(out int aValue) // If ouput parameter, value must be asigned inside the function

        {

            aValue = 222;

            WriteLine("In TestOut - Value: {0}", aValue);

        }

        public static void DoSomething(string name, int age = 21,

          bool currentStudent = true, string major = "CS")

        {

            WriteLine("Name: {0}\nAge: {1}\nCurrent Student: {2}\nMajor: {3}", name, age, currentStudent, major);

        }


        static void Main(string[] args)
        {
            /*int a = 12;
            TestRef(ref a);
            WriteLine("Afeter TestRef {0}", a);
            

            int anotherint;
            TestOut(out anotherint);
            WriteLine("After Test Out  {0}", a);

            string name = "Kannan";
            DoSomething(name);

            */

            string stateAbbrev;

            WriteLine("Enter the state abbreviation. ");

            WriteLine("Its full name will be displayed");

            WriteLine();

            stateAbbrev = ReadLine();



            switch (stateAbbrev)

            {

                case "AL":

                    WriteLine("Alabama");

                    break; 
      


        case "FL":

                    WriteLine("Florida");

                    break;

                case "TX":

                    WriteLine("Texas");

                    break;

                default:

                    WriteLine("No match");

                    break;

            }   // End switch    

            WriteLine("Thank you!");
            ReadKey();




        }
    }
}
