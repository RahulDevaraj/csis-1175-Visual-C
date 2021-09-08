using System;
using static System.Console;

namespace LabEx03
{
    class Time
    {
        static int ToMinutes(int seconds)   //Function to calculate number of Minutes
        { 
            int minutes;
            minutes = (seconds / 60) % 60;
            return minutes;
        }
        static int ToHours(int seconds)    //Function to calculate number of Hours
        {
            int hours;
            hours = seconds/3600;
            //hours = (int) Math.Floor(toHours);
            return hours; 
        }
        static void Main(string[] args)
        {
            int seconds,hours,minutes, secondsleft;

            Write("Please input the number of seconds >> ");   
            seconds = int.Parse(ReadLine());                            //getting the inputs

            hours = ToHours(seconds);                                   //Calculating Hours
            minutes = ToMinutes(seconds);                               //Calculating Minutes
            secondsleft = seconds - ((hours * 3600) + (minutes * 60));  //Calculating Remaining Seconds (total - seconds calculated in Hours and Minutes)

            WriteLine("{0} Seconds is equivalent to {1} Hours {2} Minutes {3} Seconds.",seconds,hours,minutes, secondsleft);   //Display Results
           
            ReadKey();

        }
    }
}
