using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Used to change gather and change user input
            string userInput;

            //Dimensions variables ==============
            int packageWeight;
            int packageWidth;
            int packageHeight;
            int packageLenght;

            Console.WriteLine("Welcome to the Package Express. Please follow the instructions below");
            Console.WriteLine("Please enter the package weight:");
            userInput = Console.ReadLine();
            packageWeight = Convert.ToInt32(userInput);

            if (packageWeight > 50)
            {
                Console.WriteLine("Package too heavy to be shipped via Package Express");
            }
            else
            {
                Console.WriteLine("Please enter the package width:");
                userInput = Console.ReadLine();
                packageWidth = Convert.ToInt32(userInput);

                Console.WriteLine("Please enter the package height:");
                userInput = Console.ReadLine();
                packageHeight = Convert.ToInt32(userInput);

                Console.WriteLine("Please enter the package lenght:");
                userInput = Console.ReadLine();
                packageLenght = Convert.ToInt32(userInput);

                //Dimensions all together====================
                int totalDimensions = packageWidth + packageHeight + packageLenght;

                if (totalDimensions > 50)
                {
                    Console.WriteLine("Package too big to be shipped via Package Express");
                }
                else
                {
                    //Over all price========================
                    int price = totalDimensions * packageWeight / 100;

                    Console.WriteLine("Your estimated total for shipping this package is: $" + price);
                    Console.WriteLine("Thank you.");
                    Console.ReadLine();
                }

            }
            Console.ReadLine();
        }
    }
}
