﻿using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Give me a number, let's divide it by two.");
            int userInput = Convert.ToInt32(Console.ReadLine());

            Class1 test = new Class1();
            test.DivideInt(userInput);



            //Output Parameters ============================
            int localVar = 20;

            test.OutPut(out localVar);

            Console.WriteLine("The magic number is... {0}", localVar);
        }
    }
}