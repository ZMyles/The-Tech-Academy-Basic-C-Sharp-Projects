using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodMaddness
{
    class Program : Class1
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Give me any number.");
            int userInput = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Give me another number.");
            int userInput2 = Convert.ToInt32(Console.ReadLine());

            Calculations(userInput, userInput2);
        }
    }
}
