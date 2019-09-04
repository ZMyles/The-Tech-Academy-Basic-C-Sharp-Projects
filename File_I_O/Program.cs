using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace File_I_O
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
