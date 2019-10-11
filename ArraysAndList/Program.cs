using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Linq;

namespace ArraysAndList
{
    class Program
    {
        static void Main()
        {
            //Array =================================
            Console.WriteLine("User, Lets play Magic number... ");
            Console.WriteLine("Pick anynumber through, 1-5 and Lets see how much money you get.");

            int userInput = Convert.ToInt32(Console.ReadLine());

            if (userInput > 6)
            {
                Console.WriteLine("That number isn't on the list");
                Console.ReadLine();
            }
            else
            {

                int[] numArray = new int[6];
                numArray[1] = 2;
                numArray[2] = 12;
                numArray[3] = 200;
                numArray[4] = 10;
                numArray[5] = 10;

                int test = numArray[userInput];

                Console.WriteLine("You got: ${0} !!!", test);
                Console.ReadLine();
            }

            //String Array ====================================

            Console.WriteLine("User, Lets guess your fortune... ");
            Console.WriteLine("Pick anynumber through, 1-5 and Lets see your fortune.");

            int userInput2 = Convert.ToInt32(Console.ReadLine());

            if (userInput2 > 6)
            {
                Console.WriteLine("That number isn't on the list");
                Console.ReadLine();
            }
            else
            {

                string[] stringArray = new string[6];
                stringArray[1] = "You will wake up in the morning";
                stringArray[2] = "You will eat food later";
                stringArray[3] = "You will get a phone call within the next 24 hours";
                stringArray[4] = "You will sneeze at some point";
                stringArray[5] = "You will stub your toe at somepoint";

                string test2 = stringArray[userInput2];

                Console.WriteLine("Your fortune is: {0}...!", test2);
                Console.ReadLine();
            }

            //List ==================================



            Console.WriteLine("User, Let's see if you can read my mind... ");
            Console.WriteLine("Enter a number between 1-3 and lets see what I was thinking of. ");
            int userInput3 = Convert.ToInt32(Console.ReadLine());


            List<string> stringList = new List<string>();

            stringList.Add("I left the oven on...");
            stringList.Add("I can't escape the sadness...");
            stringList.Add("How many licks does it take to get to the center of a Tootsie Pop...?");
            var firstItem = stringList.ElementAt(userInput3);

            Console.WriteLine(firstItem);
            Console.ReadLine();



        }
    }
}
