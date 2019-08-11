using System;

namespace OneMethodOnePower
{
    class Program
    {
        static void Main(string[] args)
        {

            //TAKES TWO USER INPUTS INTO ONE METHOD =======
            Console.WriteLine("Give me a number...");
            int x = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Give me a another number.....");
            int y = Convert.ToInt32(Console.ReadLine());

            int userResult = Class1.AddMethod(x, y);

            Console.WriteLine(x + " * " + y + " = " + userResult);

            //TAKES DECIMALS AND TURNS THEM INTO INTEGERS ===========

            Console.WriteLine("Give me a decimal...");
            decimal x1 = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine("Give me a another decimal.....");
            decimal y2 = Convert.ToDecimal(Console.ReadLine());

            int userResult2 = Class1.AddMethod(x, y);

            Console.WriteLine(userResult2);

            //Takes STRINGS INTO INTEgers ==========================
            Console.WriteLine("Give me a number, lets turn it into a interger.");
            string userInput = Console.ReadLine();

            Console.WriteLine("Give me another interger.");
            string userInput2 = Console.ReadLine();

            int stringAnswer = Class1.AddMethod(userInput, userInput2);

            Console.WriteLine(stringAnswer);

        }
    }
}
