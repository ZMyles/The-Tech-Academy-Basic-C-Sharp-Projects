using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pg124
{
    abstract class Person
    {
        string FirstName { get; set; }
        string LastName { get; set; }


        public void SayName()
        {
            string fullName = FirstName + LastName;

            Console.WriteLine("Name: [" + fullName + "]");
        }
    }
}
