using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
        
            //---------------------------------------------------------------
            string userInput;// Used to gather and change inputs into correct value
            int intVal;

            Console.WriteLine("Enter a number, Let's multiply it by 50.");
            userInput = Console.ReadLine();
            intVal = Convert.ToInt32(userInput);

            int result = intVal * 50;

            Console.WriteLine(result);

            //----------------------------------------------------------------
            Console.WriteLine("Enter a number, let's add 25 to it.");
            userInput = Console.ReadLine();
            intVal = Convert.ToInt32(userInput);

            int result2 = intVal + 25;

            Console.WriteLine(result2);
            //----------------------------------------------------------------
            Console.WriteLine("Enter a number, let's divide it by 12.5.");
            userInput = Console.ReadLine();
            double decimalVal = Convert.ToInt32(userInput);

            double result3 = decimalVal / 12.5d;

            Console.WriteLine(result3);
            //---------------------------------------------------------------

            Console.WriteLine("Enter a number, let's see if its greater than 50.");
            userInput = Console.ReadLine();
            int greaterOrLess = Convert.ToInt32(userInput);

            bool trueValue = 50 > greaterOrLess;

            if (trueValue)
            {
                Console.WriteLine("50 is greater then " + userInput);
            }
            else
            {
                Console.WriteLine(userInput + " is greater than 50.");
            }
            //---------------------------------------------------------------
            Console.WriteLine("Enter a number, let's divided it by 7 and see the remainder.");
            userInput = Console.ReadLine();
            int divideby = Convert.ToInt32(userInput);

            int result4 = divideby % 7;

            Console.WriteLine(result4);




            
        }
    }
}
