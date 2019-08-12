using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Gathers user Inputs
            Console.WriteLine("Please enter a Number");
            int userInput1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("If you wish, you can add another number. If not don't type anything");
            string userInput2 = Console.ReadLine();

            // Pushes Inputs int Method
            int result = Class1.AdditonMethod(userInput1, userInput2);

            Console.WriteLine(result);
        }
    }
}
