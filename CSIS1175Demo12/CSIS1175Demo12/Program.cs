using System;
using static System.Console;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSIS1175Demo12
{
   
    class Program
    {
        public static void SimpleCounting(int n)
        {
            for (int i = 0; i <= n; i++)
            {
                WriteLine(i);
            }
        }

        static void Recursive(int n)
        {
            WriteLine(n);

            if(n>1) //Stop Cnndition
            Recursive(n - 1);
            //Change order to reverse the sequence
            
        }

        static void DisplayArray(int[] array, int n)
        {
            WriteLine(array[n]);
            if(n < array.Length-1)
            DisplayArray(array, n + 1);
        }

        static int fact(int n)
        {
            if (n == 0)
                return 1;
            else
                return (n * fact(n - 1));
        }
        static void ArrayListExample() //Use a.Count for length of arrayList
        {
            ArrayList a = new ArrayList();
            a.Add("Hai");
            a.Add("Aug");
            a.Add(9);
            a.Add(10);

            a.RemoveAt(1);
            a.Insert(0, 3.14);
            a.Insert(0, 100m);
           

            for (int i = 0; i < a.Count; i++)
            {
                WriteLine(a[i]);
            }

        }
        static void Main(string[] args)
        {
            //Recursive(10);

            /*int[] array = { 1, 2, 3, 4, 5, 6, 7 };
            DisplayArray(array,0);*/

            //WriteLine(fact(5));
            ArrayListExample();

            ReadKey();
        }
    }
}
