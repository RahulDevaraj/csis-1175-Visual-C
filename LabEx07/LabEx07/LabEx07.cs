using System;
using static System.Console;

namespace LabEx07
{
    class LabEx07
    {
        static void Main(string[] args)
        {
            string[] test = new string[100];            //Array Declaring
            int index = test.Length;                    //initialising
            
            for(int i=0;i<test.Length;i++)              //Adding names to array
            {
                Write("Enter a name to add to array for sorting else enter Z to Stop >> ");
                string temp = ReadLine();
                if (temp == "Z" || temp == "z")
                {
                    index = i;                          //Used to find number of elements in array
                    break;
                }
                else
                    test[i] = temp;

            }
            
                
            Array.Sort(test);                            //Sorting
            WriteLine("Sorted Array is Displayed Below :");
            
            for(int i=(test.Length)-index; i < test.Length; i++)    //Display only Valid Elements
            {
                WriteLine(test[i]);
            }


            ReadKey();
        }
    }
}
