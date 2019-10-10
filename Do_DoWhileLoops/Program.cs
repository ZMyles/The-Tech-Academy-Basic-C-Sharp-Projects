using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Do_DoWhileLoops
{
    class Program
    {
        static void Main(string[] args)
        {
            //Do Loop ==========
            Console.WriteLine("Thinking between 1 & 10...What's my number?");
            int number = Convert.ToInt32(Console.ReadLine());
            bool numberGuessed = number == 7;

            do
            {
                switch (number)
                {
                    case 1:
                        Console.WriteLine("Nope!");
                        Console.WriteLine("Try again...");
                        number = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 4:
                        Console.WriteLine("Not Even!");
                        Console.WriteLine("Try again...");
                        number = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 10:
                        Console.WriteLine("You Even trying..?");
                        Console.WriteLine("Try again...");
                        number = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 6:
                        Console.WriteLine("Almost...");
                        Console.WriteLine("could be better.");
                        number = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 7:
                        Console.WriteLine("Winner, winner!");
                        numberGuessed = true;
                        break;
                    default:
                        Console.WriteLine("Keep at it!");
                        number = Convert.ToInt32(Console.ReadLine());
                        break;
                }
            }
            while (!numberGuessed);

            Console.ReadLine();

            //While Loop =================================

            int i = 1;
            while(i <= 10)
            {
                Console.WriteLine("I Value: {0}", i);
                i++;
            }
            Console.WriteLine("Press Enter Key to Exit..");

            Console.ReadLine();

        }
    }
}
