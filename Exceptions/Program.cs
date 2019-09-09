using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Exceptions
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime aDate = DateTime.Now;

            try
            {
                Console.WriteLine("Please enter your age.");
                int userAge = Convert.ToInt32(Console.ReadLine());

                string birthYear = aDate.ToString("yyyy");
                int change = Convert.ToInt32(birthYear);


                //Result
                int birthday = change - userAge;


                Console.WriteLine("Please enter a number.");


                Console.WriteLine("You were born in: {0}", birthday);
                Console.ReadLine();
            }
            catch (FormatException ex)
            {
                Console.WriteLine("Loading...");
                Console.WriteLine("Please enter a positive number");
                Console.ReadLine();
            }

            catch (Exception)
            {
                Console.WriteLine("Loading...");
                Console.WriteLine("Please enter a Number");
                Console.ReadLine();
            };
        }
           
            
             
        
    }
}
