using System;

namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {
            // PART 1=================================================
            //=======================================================

            //string[] phrases = { "Is cool", "Doesn't like brownies", "Is not a fan of heights" };

            //Console.WriteLine("Tell me you're name");
            //string name = Console.ReadLine();

            //for (int i = 0; i < phrases.Length; i++)
            //{
            //    Console.WriteLine(name + " " + phrases[i]);
            //}
            //Console.ReadLine();

            // PART 2 ================================================
            //========================================================

            //INIFINTE LOOP!!

            //for ( int a = 0; a < 50; a--)
            //{
            //    Console.WriteLine("value : {0}", a);
            //}
            //Console.ReadLine();



            //PART 3 =================================================
            //==========================================================

            //THE FIX...

            //for (int a = 0; a < 50; a++)//Now it will add up and end
            //{
            //    Console.WriteLine("value : {0}", a);
            //}
            //Console.ReadLine();

            //PART 4 ====================================================
            //============================================================

            //for (int j = 1; j < 50; j++){
            //    Console.WriteLine(j);
            //}

            // PART 5 ======================================================
            //==============================================================

            //for (int k = 1; k <= 50; k++)
            //{
            //    Console.WriteLine(k);
            //}

            //PART 6 =======================================================
            //=========================================================

            //List<string> names = new List<string>() { "Jesse", "Erik", "Adam", "Daniel" };

            //foreach(string name in names)
            //{
            //    Console.WriteLine(name);
            //}
            //Console.ReadLine();

            List<string> animalList = new List<string>() { "Lions", "Tigers", "Bears", "Alligators" };

            foreach(string beast in animalList)
            {
                Console.WriteLine(beast);
            }

            Console.WriteLine("Are you a fan of Fine furs or Scaly Skin? ")

        }
    }
}
