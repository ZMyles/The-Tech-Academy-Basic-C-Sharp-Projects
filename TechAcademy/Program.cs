using System;

namespace TechAcademy
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("The Tech Academy");
            Console.WriteLine("Student Daily Report \n");
            

            Console.WriteLine("What course are you on?");
            string userCourse = Console.ReadLine();

            Console.WriteLine("What page number? ");
            int num = Convert.ToInt32(Console.ReadLine());


            Console.WriteLine("Do you need help with anything? Please answer 'True' or 'False' ");
            string needHelp = Console.ReadLine();

            Console.WriteLine("Were there any positive experiences you'd like to share? Please give specifices.");
            string userExperience = Console.ReadLine();

            Console.WriteLine("Is there any other feedback you'd like to provide? Please be specific.");
            string feedBack = Console.ReadLine();

            Console.WriteLine("How many hours did you study today?");
            int studyTime = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Thank you for your answers. An instructor will respond to this shortly. Have a great day!");

            Console.ReadLine();

        }
    }
}
