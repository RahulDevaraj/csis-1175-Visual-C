using System;
using System.IO;
using static System.Console;

namespace LabEx08
{
    class LabEx
    {
        const string path = "../../Input.txt";          //Input File Path
        static void Main(string[] args)
        {
            try
            {
                StreamReader reader = new StreamReader(path);
                string line;
                string[] elements;         // To store each element
                int iteration = 0;
                while ((line = reader.ReadLine()) != null)
                {
                    double avg = 0.0;
                    elements = line.Split(' ');         //seperating each element in the line
                    int count = elements.Length;
                    int[] intArray = new int[count];
                    for (int i=0; i<count; i++)
                    {
                        intArray[i] = int.Parse(elements[i]);       //conv string array to int array
                        avg += int.Parse(elements[i]);          
                    }
                    avg /= count;       //Avg calc

                    Array.Sort(intArray);           //Sorting


                    WriteLine("In Line {0}, the number of values processed is {1}, the Average is {2:F2}, Smallest element is {3} and Largest is {4}", iteration,count,Math.Round(avg,2),intArray[0],intArray[count-1]);


                    iteration++;
                }
                reader.Close();
            }
            catch(IOException e) 
            { WriteLine(e.Message); }

            ReadKey();
           

        }
    }
}
