using System;

class Program
{
	static void Main()
	{

        try
        {
            Console.WriteLine("Pick a number");
            int numberOne = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Pick a second number");
            int numberTwo = Convert.toInt32(Console.ReadLine());
            Console.WriteLine("Dividing the two...");
            int numberThree = numberOne / numberTwo;
            Console.WriteLine(numberOne + "divided by" + numberTwo + " equals " + numberThree);
            Console.ReadLine();

        }

        catch (FormatException ex)
        {
            Console.WriteLine("Please type a whole number.");
        }
        Console.ReadLine();
    }

}