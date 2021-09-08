using System;
using static System.Console;


namespace LabEx05
{
    class Traingle
    {
        static void Main(string[] args)
        {
            int size;                      // FOr Size
            char character;
            Boolean status = false;        // For invalid input status

            Write("Enter Character >> ");
            status = char.TryParse(ReadLine(), out char result);   //Getting a valid character
            if (status == true)
                character = result;
            else
                character = '*';

            status = false;
            Write("Enter Triangle Peak Size >> ");
            status = int.TryParse(ReadLine(), out int bufferSize);        //Getting valid integer
            if (status == true)
            {
                if (bufferSize > 10)
                    size = 3;
                else
                    size = bufferSize;
            }
            else
                size = 3;

            for(int i=0;i<size;i++)                                //Print Upper Traingle
            {   
                for (int j = 0; j < i + 1; j++)
                    Write(character);
                   
                WriteLine("");
            }

            for (int i = size-1; i > 0; i--)           //Print Lower Traingle
            {
                for (int j = i; j >0 ; j--)
                    Write(character);

                WriteLine("");
            }

            ReadKey();

        }
    }
}
