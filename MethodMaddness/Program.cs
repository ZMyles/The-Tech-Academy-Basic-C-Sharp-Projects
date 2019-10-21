using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodMaddness
{
    class Program 
    {
        static void Main(string[] args)
        {
            Class1 Cal = new Class1();

            Console.WriteLine("Give me any number.");
            int userInput = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Give me another number.");
            int userInput2 = Convert.ToInt32(Console.ReadLine());

            Cal.Calculations(userInput, userInput2);

            Cal.Calculations(userInput = 5, userInput2 = 7);
        }
    }
}
