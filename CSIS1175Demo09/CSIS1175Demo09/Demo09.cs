using System;
using System.IO;
using static System.Console;

namespace CSIS1175Demo09
{
    class Demo09
    {
        const string inFileName = "../../NewText.txt";
        const string outFileName = "../../Output.txt";
        // const string inFileName = @"D:\Academics\Semester 1\Introduction to Programming CSIS-1175\CSIS1175Demo09\CSIS1175Demo09\NewText.txt";
        static void Main(string[] args)
        {
           

            Student[] students;
            students = new Student[3];
            for(int i=0; i< students.Length; i++)
            {
                students[i] = new Student();
            }

            try
            {
                StreamReader reader;
                reader = new StreamReader(inFileName);
                string line;
                string[] tokens;
                int count = 0;
                while((line = reader.ReadLine()) != null)
                {
                    //WriteLine(line);
                    tokens = line.Split(' ');
                    students[count].Name = tokens[0];
                    students[count].Id = tokens[1];
                    students[count].Age = tokens[2];
                    count++;

                }
                reader.Close();
            }
            catch(IOException e)
            {
                WriteLine(e.Message);
            }

            try
            {
                StreamWriter writer = new StreamWriter(outFileName);
                for (int i = 0; i < students.Length; i++)
                {
                    writer.WriteLine(students[i]);
                }
                writer.Close();

            }

            catch (IOException e)
            {
                WriteLine(e.Message);
            }

            /*students[0].Id = "123456";
            students[0].Name = "Li, KN";

            students[1].Id = "1234567";
            students[1].Name = "AA, BB";

            students[2].Id = "1234568";
            students[2].Name = "CC, DD";*/

            foreach (Student s in students)
            {
                WriteLine(s);
            }
            ReadKey();
        }
    }
}
