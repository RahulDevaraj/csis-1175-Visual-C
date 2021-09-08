using static System.Console;
using System.IO;
using System;


namespace Test
{
    class Consecutive
    {
        private const string PATH = @"../../Input.txt";
        static void Main(string[] args)
        {
            
            try
            {
                StreamReader reader = new StreamReader(PATH);
                string line;
                int count = 0;
                while((line = reader.ReadLine()) != null)   //Find number of Lines
                {
                    count++;
                }
                reader.Close();

                StreamReader newReader = new StreamReader(PATH);
                int[] intArray = new int[count];
                
                for (int i = 0; (line = newReader.ReadLine()) != null; i++)  //To array
                {
                    intArray[i] = int.Parse(line);
                    
                }
                Array.Sort(intArray);       //Sorting

                Boolean status = true;
                for(int j=0; j<count - 1;  j++)
                {
                    if((intArray[j]+1) != intArray[j+1])        //Consecutive or Not
                    {
                        status = false;
                        break;
                    }
                }

                Write("The numbers are: ");
                for(int j=0;j<count;j++)
                {
                    Write(intArray[j] + " ");
                }
                if(status ==  true)     //Display  Message
                {
                    WriteLine("\nThe numbers of the said array are consecutive.");
                }
                else
                    WriteLine("\nThe numbers of the said array are not consecutive.");
                newReader.Close();
            }
            catch(IOException e)
            {
                WriteLine(e.Message);
            }
            ReadKey();
        }
    }
}
