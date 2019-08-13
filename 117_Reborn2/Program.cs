using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _117_Reborn2
{
    class Program
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



            //Static Overload ============================

            int blah = Class2.TestInt();
            
            Console.WriteLine("10 + 50 = " +blah);

            Console.WriteLine("Give me an Int...");
            int blah2 = Convert.ToInt32(Console.ReadLine());
            

            Console.WriteLine("Your number * ten equal: " + Class2.TestInt(blah2));
            Console.ReadLine();
           



        }
    }
}
