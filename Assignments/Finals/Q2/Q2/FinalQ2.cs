using System;
using static System.Console;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q2
{
    class FinalQ2
    {
        private const string PATH = @"../../Input.txt";
        int choice;
        string size = "";
        int numberTypes = 0;
        string[] pizzaTypes;
        double[,] pizzaPrices;
        double total=0.0;
        static void Main(string[] args)
        {
            FinalQ2 q = new FinalQ2();
            q.ReadData();   //Reading from text file
            q.Run();        //Main prgrm
            
            ReadKey();
        }
        public void ReadData()
        {
            try
            {
                StreamReader reader = new StreamReader(PATH);
                numberTypes = int.Parse(reader.ReadLine());

                pizzaTypes = new string[numberTypes];       //for string pizza types
                pizzaPrices = new double[numberTypes, 3];   //for storing prices of each variant

                string line = "";
                int i = 0;
                while((line =  reader.ReadLine())!=null)    //Reading from file and stroring data to variables
                {
                    string[] token = line.Split(',');
                    pizzaTypes[i] = token[0];
                    pizzaPrices[i, 0] = double.Parse(token[1]);
                    pizzaPrices[i, 1] = double.Parse(token[2]);
                    pizzaPrices[i, 2] = double.Parse(token[3]);
                    
                    i++;
                }

                reader.Close();

            }
            catch(IOException e)
            {
                WriteLine(e.Message);
            }
        }

        public void Run()
        {
            string ch;
            int forTotal = 0;
            do
            {
                PrintMenu();        //Menu Printing
                Write("Confirm you order (Y/N): ");
                ch = ReadLine();    //Confirm?

            } while (ch == "N" || ch =="n");

            WriteLine("Thank you for your purchase!");
            WriteLine("Your {0} {1} is ready to serve.",size,pizzaTypes[choice]);

            if (size == "9\"")  //Converting size string to a total index variable
                forTotal = 0;
            else
                if (size == "12\"")
                forTotal = 1;
            else
                if (size == "14\"")
                forTotal = 2;

            total = 1.05 * pizzaPrices[choice, forTotal];   //Calc Final price

            WriteLine("Total cost: {0:F2}",total);          //Print Final Price
        }

        public void PrintMenu()     //Printing Menu
        {
            
            WriteLine("Welcome to N&I Pizza\nPlease choose your pizza");
            for(int i=0;i<numberTypes;i++)
            {
                WriteLine("Pizza {0}: {1}",i,pizzaTypes[i]);
            }

            Write("Enter the pizza number >> ");
            choice = int.Parse(ReadLine());
            
            WriteLine("Please choose the size (9\"/ 12\"/14\"):");
            Write("9\": ${0:F2} / 12\": ${1:F2} / 14\": ${2:F2} >> ",pizzaPrices[choice,0], pizzaPrices[choice, 1], pizzaPrices[choice, 2]);
            size = ReadLine();
            
        }
    }
}
