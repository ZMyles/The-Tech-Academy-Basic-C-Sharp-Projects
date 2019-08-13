using System;

namespace ConsoleApp1
{
    static class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Give me a number, let's divide it by two.");
            int userInput = Convert.ToInt32(Console.ReadLine());

            int result;

            Class1 test = new Class1();
            test.DivideInt(userInput, out result);
            Console.WriteLine("Your number divided by two: " + result);
            Console.ReadLine();



            //Output Parameters ============================
            int localVar = 20;

            //test.OutPut(out localVar);

            Console.WriteLine("The magic number is... {0}", localVar);
        }
    }
}
