using System;

namespace ConsoleApp_Test
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("What number would you like to multipy with 2?");
            int userInput = MathOp.Mutiply(Convert.ToInt32(Console.ReadLine()));

            Console.WriteLine("The number was: " + userInput);




            Console.WriteLine("What number would you like to find the remainder of from 100?");
            int userInput2 = MathOp.Modules(Convert.ToInt32(Console.ReadLine()));

            Console.WriteLine("The number was: " + userInput2);



            Console.WriteLine("What number would you like to subtract 100 from?");
            int userInput3 = MathOp.Subtract(Convert.ToInt32(Console.ReadLine()));

            Console.WriteLine("The number was: " + userInput3);


            // TEST CODE=================
            //int answer = MathOp.Add(10);
            //Console.WriteLine("Our number is: " + answer);


        }
    }
    }
