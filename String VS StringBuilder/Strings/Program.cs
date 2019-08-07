using System;
using System.Text;

namespace Strings
{
    class Program
    {
        static void Main()
        {
            //Robot story time...(Concatination)====================================
            string myName = "Tom Curise";
            string myPurpose = "To make awesome movies";
            string myHomeworld = "Mars...I Mean, Earth! Just like the rest of us humans!";

            Console.WriteLine("Greetings Earthling, I'm " + myName + ". My Goals are simply... I just want to " + myPurpose + ".");
            Console.WriteLine("Orignally, I was born in "+ myHomeworld);
            Console.ReadLine();

            //Convert strings to UPPERCASE ====================================
            Console.WriteLine("Can you give me a name?");
            string name = Console.ReadLine();

            Console.WriteLine(name.ToUpper());

            //StringBuilder, What does it really do?=================================

            StringBuilder sb = new StringBuilder("Test my stringbuilder", 50);
            sb.Append("TEST IS IT WORKING?!");

            Console.WriteLine(sb);




        }
    }
}
