using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciseC_Sharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee();
            employee.FirstName = "Sample";
            employee.LastName = "Student";
            employee.ID = 25;

            Employee employee1 = new Employee();
            employee1.ID = 25;

            employee.SayName();

            //IQuittable =====================================
            IQuittable person = new Employee();
            person.Quit();


            if (employee.ID == employee1.ID)
            {
                Console.WriteLine("If he quits, Then I Quit!!");
                Console.ReadLine();
            }

        }
    }
}
