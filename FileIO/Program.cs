using System;

namespace FileIO
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter any number.");
            string userInput = Console.ReadLine();

            File.WriteAllText(@"C:\Users\Zavier Myles\Desktop\Number_Storage\UserNumber.txt", userInput);

            Console.WriteLine("Thanks for the: ", userInput);
            Console.ReadLine();

        }
    }
}
