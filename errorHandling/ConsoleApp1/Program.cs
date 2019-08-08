using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //try
            //{
            //    Console.WriteLine("Pick a number");
            //    int numberOne = Convert.ToInt32(Console.ReadLine());
            //    Console.WriteLine("Pick a second number");
            //    int numberTwo = Convert.ToInt32(Console.ReadLine());
            //    Console.WriteLine("Dividing the two...");
            //    int numberThree = numberOne / numberTwo;
            //    Console.WriteLine(numberOne + " divided by " + numberTwo + " equals " + numberThree);
            //    Console.ReadLine();

            //}

            //catch (FormatException ex)
            //{
            //    Console.WriteLine("Please type a whole number.");
            //    return;
            //}
            //catch (DivideByZeroException ex)
            //{
            //    Console.WriteLine("Please Don't divide by zero");
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}
            //finally
            //{
            //    Console.ReadLine();
            //}



            List<int> numList = new List<int>();
            numList.Add(25);
            numList.Add(10);
            numList.Add(36);
            numList.Add(40);
            numList.Add(400);


            try
            {

                Console.WriteLine("Enter a number, will divide it within our list.");
                int userInput = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Processing...");

                foreach (int number in numList)
                {
                    float result = number / userInput;
                    Console.WriteLine(result);
                }
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("Please Try another number, We can not divide by zero");
            }
            catch (FormatException ex)
            {
                Console.WriteLine("Please enter numbers ONLY.");
            } 
            finally
            {
                Console.ReadLine();
            }

        }
    }
}
