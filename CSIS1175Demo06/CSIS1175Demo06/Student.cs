using System;
using static System.Console;

namespace CSIS1175Demo06
{
    class Student
    {
        private string name;
        private int yearOfStudy;
        public string Id { get; set; }

        public int YearOfStudy { get => yearOfStudy; set => yearOfStudy = value; }
        public string Name { get => name; set => name = value; }

        public Student()
        {
            WriteLine("Default COnstructor");
        }

        public Student(string name, int yearOfStudy,string id)
        {
            Name = name;
            YearOfStudy = yearOfStudy;
            Id = id;
        }

        public static void Recruit()
        {
            WriteLine("Hey ALl");
        }

        public void ShowMsg()
        {
            WriteLine(Name, YearOfStudy);
        }
    }
}
