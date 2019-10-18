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
            string lines;
            string path = @"C:\Users\Zavier Myles\Desktop\Number_Storage\UserNumber.txt";

            Console.WriteLine("Please enter any number.");
            string userInput = Console.ReadLine();

            File.WriteAllText(@"C:\Users\Zavier Myles\Desktop\Number_Storage\UserNumber.txt", userInput);

            lines = File.ReadAllText(path);

            Console.WriteLine("Returning Value: {0}", lines);
            Console.ReadLine();

        }
    }
}
