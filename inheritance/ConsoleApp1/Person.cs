using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
     public class Person 
    {

        public string FirstName {get; set; }
        public string LastName {get; set; }

        public void SayName()
        {
            string fullName = FirstName + LastName;

             Console.WriteLine("Name: [" + fullName + "]");
            
            
        }
        
    }
}
