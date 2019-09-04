using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace DateAndTime
{
    class Program
    {
        static void Main(string[] args)
        {
            //DateTime yearOfBirth = new DateTime(1995, 5, 23, 8, 32, 45);
            //DateTime yearOfGraduation = new DateTime(2013, 6, 1, 16, 34, 22);

            //TimeSpan ageAtGraduation = yearOfBirth - yearOfGraduation;
            //Console.WriteLine(ageAtGraduation);
            //Console.ReadLine();


            // CURRENT TIME +++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
            DateTime aDate = DateTime.Now;
           string theDate = aDate.ToString("MM/dd/yyyy");
           string theTime = aDate.ToString("hh:mm");

            Console.WriteLine("Today is: "+ theDate + "\nAnd the time is: " + theTime);
            Console.ReadLine();

            // USER INPUT +++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++

            Console.WriteLine("Please enter any number.");
            int userInput = Convert.ToInt32(Console.ReadLine());

            //Converts the String of time into an int
            string hoursOnly = aDate.ToString("hh");
            int test = Convert.ToInt32(hoursOnly);

            //Calculates the Time.
            int expectedTime = test + userInput;

            Console.WriteLine("The time will be: " + expectedTime + " in: " + userInput +" hours.");
            Console.ReadLine();



        }
    }
}
