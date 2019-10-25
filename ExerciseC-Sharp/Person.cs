using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciseC_Sharp
{
    abstract class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public abstract void Test();

        public void SayName()
        {
            string fullName = FirstName + LastName;

            Console.WriteLine("Name: [" + fullName + "]");
        }
    }
}
