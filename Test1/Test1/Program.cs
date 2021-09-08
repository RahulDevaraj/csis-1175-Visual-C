using System;
using static System.Console;


namespace Test1
{
    class Program
    {
        public static void Print1()
        {
            double b = 12.1234567;
            decimal d = 1.123456789123456789m;
            int a = 4;
            Write("{0,-8:F4}",b);
            Write("aaa"+d);
        }

        static void Main(string[] args)
        {
            Print1();
            ReadKey();
        }
    }
}
