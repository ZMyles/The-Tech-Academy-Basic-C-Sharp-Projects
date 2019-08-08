using System;
using System.Collections.Generic;

namespace SimplyArrayPrograms
{
    class Program
    {
        static void Main()
        {



            // Part 1 ======================================
            Console.WriteLine("Words of Wisdom, pick a number through 5 and obtian my knowledge..");
            int num = Convert.ToInt32(Console.ReadLine());

            string[] myWisom = new string[5];
            myWisom[0] = "Eat you're greens.";
            myWisom[1] = "Brush you're teeth...Don't want..uh..Bad breath! or something...";
            myWisom[2] = "Smile more! You know who you are.";
            myWisom[3] = "Um, I guess go workout? nothing like fitness.";
            myWisom[4] = "Be Nice... Or something?";

            Console.WriteLine(myWisom[num]);
            Console.ReadLine();

            //Part 2 =======================================
            Console.WriteLine("Just Pick a number through 0-4, It's show display on screen.");
            int intVal = Convert.ToInt32(Console.ReadLine());


            int[] numberArray = new int[5];
            numberArray[0] = 0;
            numberArray[1] = 1;
            numberArray[2] = 2;
            numberArray[3] = 3;
            numberArray[4] = 4;

            if (intVal > 4)
            { 
               Console.WriteLine("That is not a number, Try again later"); 
            }
            else
            {
                Console.WriteLine(numberArray[intVal]);
                Console.ReadLine();
            }

            //List<int> intList = new List<int>();
            //intList.Add(4);
            //intList.Add(10);

            //Console.WriteLine(intList[0]);
            //Console.ReadLine();


            Console.WriteLine("Enter a number out 4, theirs a message if you pick the right on..");
            int num = Convert.ToInt32(Console.ReadLine());

            List<string> testList = new List<string>();
            testList.Add("Strings");
            testList.Add("Shout");
            testList.Add("Sing");
            testList.Add("Slow...");

            Console.WriteLine(testList[num]);
            Console.ReadLine();




        }
    }
}
