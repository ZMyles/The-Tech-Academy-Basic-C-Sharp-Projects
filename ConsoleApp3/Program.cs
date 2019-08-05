using System;

namespace ConsoleApp3
{
    class Program
    {
        static void Main()
        {
            string hourlyRate1;
            string hourlyRate2;

            string hoursWorked1;
            string hoursWorked2;

            int intVal1;
            int intVal2;
            int intVal3;
            int intVal4;

            // ---------- Person 1 ---------------------------------
            Console.WriteLine("Anonymous Income Comparison Program");
            Console.WriteLine("Person 1");

            Console.WriteLine("Hourly rate?");
            hourlyRate1 = Console.ReadLine();
            intVal1 = Convert.ToInt32(hourlyRate1);

            Console.WriteLine("Hours worked per week?");
            hoursWorked1 = Console.ReadLine();
            intVal2 = Convert.ToInt32(hoursWorked1);

            //------------Person 2 --------------------------------
            Console.WriteLine("Person 2");

            Console.WriteLine("Hourly rate?");
            hourlyRate2 = Console.ReadLine();
            intVal3 = Convert.ToInt32(hourlyRate2);

            Console.WriteLine("Hours worked per week?");
            hoursWorked2 = Console.ReadLine();
            intVal4 = Convert.ToInt32(hoursWorked2);

            int Person1 = intVal1 * intVal2;
            int Person2 = intVal3 * intVal4;


            Console.WriteLine("Weekly Salary for Person 1:");
            Console.WriteLine(Person1);
            Console.WriteLine("Weekly Salary for Person 2:");
            Console.WriteLine(Person2);

            Console.WriteLine("Does Person1 make more money then Person2 ?");

            bool trueValue = Person1 > Person2;

            if (trueValue)
            {
                Console.WriteLine("True");
            }
            else
            {
                Console.WriteLine("False");
            }


            Console.ReadLine();
        }
    }
}
