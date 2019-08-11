using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
     public class Person
    {

        public string FirstName;
        public string LastName;
        public void SayName()
        {
            string fullName = FirstName + LastName;

             Console.WriteLine("Name: [" + fullName + "]");
            
            
        }
        
    }
}
