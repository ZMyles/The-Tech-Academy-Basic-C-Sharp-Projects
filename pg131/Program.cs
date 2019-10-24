using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pg131
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee<string> employee = new Employee<string>();
            employee.Things = new List<string>();

            employee.Things.Add("Kevin");
            employee.Things.Add("Alex");
            employee.Things.Add("Mark");

            Employee<int> age = new Employee<int>();
            age.Things = new List<int>();

            age.Things = new List<int>();
            age.Things.Add(12);
            age.Things.Add(30);
            age.Things.Add(19);

            
            // Loops ======================================================
            foreach(string name in employee.Things)
            {
                Console.WriteLine(name);
            }

            foreach(int howOld in age.Things)
            { 
                Console.WriteLine(howOld);
            }

            Console.ReadLine();
        }
    }
}
