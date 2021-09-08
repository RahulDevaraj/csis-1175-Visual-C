using System;
using static System.Console;

namespace CSIS1175Demo06
{
    class Demo06
    {
        static void Main()
        {
            Student aStudent;
            aStudent = new Student("ASD",2002,"123");
            aStudent.Name = "ASD";
            aStudent.YearOfStudy = 2002;
            aStudent.Id = "123";

            Student anotherStudent;
            anotherStudent = new Student("XXX",4,"001");
            //anotherStudent = aStudent;
            anotherStudent.Name = "XXX";
            anotherStudent.YearOfStudy = 4;
            anotherStudent.Id = "001";


            aStudent.ShowMsg();
            anotherStudent.ShowMsg();

            Student.Recruit();
/*            WriteLine(aStudent.YearOfStudy);
            WriteLine(anotherStudent.YearOfStudy);*/

            ReadKey();
        }
    }
}
