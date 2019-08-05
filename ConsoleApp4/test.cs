using System;

namespace ConsoleExercise
{
    class Program
    {
        static void Main()
        {
            string userInput;

            int userAge;
            bool DUI;
            int speedingTickets;




            Console.WriteLine("What is your age?");
               userInput = Console.ReadLine();
               userAge = Convert.ToInt32(userInput);


           Console.WriteLine("Have you ever had a DUI, True or False?");
                userInput = Console.ReadLine();
                DUI = Convert.ToBoolean(userInput);
                
            

            Console.WriteLine("How many speeding tickets do have you? ");
                userInput = Console.ReadLine();
                speedingTickets = Convert.ToInt32(userInput);



            Console.WriteLine("Qualified?");

            if(userAge > 15 && DUI == false && speedingTickets < 3)
            {
                Console.WriteLine("You qualify");
            } 
            else
            {
                Console.WriteLine("You do not qualify");
            }

            Console.ReadLine();
        }
    }
}
