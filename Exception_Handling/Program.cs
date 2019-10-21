using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exception_Handling
{
    class Program
    {
        static void Main(string[] args)
        {

            //DateTime aDate = DateTime.Now;
            try
            {
                Console.WriteLine("Please enter your age.");
                int userAge = Convert.ToInt32(Console.ReadLine());
                int birthYear = DateTime.Now.Year - userAge; 
                

                //Result ========================================================
                Console.WriteLine("You were born in: {0}", birthYear);
                Console.ReadLine();
            }

            catch (FormatException)
            {
                Console.WriteLine("Loading...");
                Console.WriteLine("Incorrect Input: Please enter a Number");
                Console.ReadLine();
            }

            catch(OverflowException)
            {
                Console.WriteLine("Loading...");
                Console.WriteLine("Incorrect Input: please input a positive number");
                Console.ReadLine();
            };
        }
    }
}
