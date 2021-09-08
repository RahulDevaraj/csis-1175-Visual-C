using System;
using System.IO;
using static System.Console;

namespace Quiz02
{
    class Quiz02
    {
        const string PATH = @"../../Input.txt";
        static void Main(string[] args)
        {
            try 
            {
                StreamReader reader = new StreamReader(PATH);
                String line = "";
                String[] elements;
                while((line = reader.ReadLine()) !=null)        //Reading input file untill end
                {
                    Boolean status = true;
                    elements = line.Split(' ');                 //Each element in line is taken 
                    Write("Numbers: ");
                    for(int i=0;i<elements.Length;i++)          //Printing each Element
                    {
                        Write(elements[i] + " ");
                    }
                    WriteLine();

                    for(int i=0;i<elements.Length/2;i++)        //Checking for Palindrome
                    {
                        if(elements[i] != elements[elements.Length -1 -i])
                        {
                            status = false;
                            break;
                        }
                    }

                    if(status == true)                  //Printing Result if Palindrome or Not
                    WriteLine("It is a parlindrom."); 

                    else

                        WriteLine("It is not a parlindrom.");
                }

                reader.Close();

            }
            catch(IOException e)
            {
                WriteLine(e.Message);
            }

            ReadKey();
        }
    }
}
