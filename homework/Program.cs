using System;

namespace homework
{  
    class Program
    {
        static void Main(string[] args)
        {
            Salary salary = new Salary();

            salary.AddLesson(3, 4);
            salary.AddLesson(8, 2);
            salary.AddLesson(11, 3);
            salary.RemoveLesson(8);

            Console.WriteLine( " Salary:"+salary.GetSalary());

            salary.Report();
            


        }
    }
}
