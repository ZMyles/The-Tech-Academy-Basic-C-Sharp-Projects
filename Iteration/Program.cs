using System;
using System.Collections.Generic;

namespace Iteration
{
    class Program
    {
        static void Main(string[] args)
        {
            //int[] testScores = { 98, 99, 85, 70, 82, 34, 90, 91, 94 };

            //for (int i = 0; i < testScores.Length; i++)
            //{
            //    if (testScores[i] > 85)
            //    {
            //        Console.WriteLine("Passing test score: " + testScores[i]);
            //    }
            //}
            //Console.ReadLine();


            //======================================================
            //Strings !!!!!!!!!!!!!!!!!!!!!!!!!
            //======================================================

            //string[] names = { "Jesse", "Erik", "Daniel", "Adam" };

            //for(int j = 0; j < names.Length; j++)
            //{
            //    Console.WriteLine(names[j]);
            //}
            //Console.ReadLine();



            //+++++++++++++++++++++++++++++++++++++++++++++++++
            //LIST!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
            //+++++++++++++++++++++++++++++++++++++++++++++++++
            //List<int> testScores = new List<int>();
            //testScores.Add(98);
            //testScores.Add(18);
            //testScores.Add(80);
            //testScores.Add(100);
            //testScores.Add(98);

            //foreach(int score in testScores) {
            //    if (score > 85)
            //    {
            //        Console.WriteLine("Passing test score:" + score);
            //    }

            //}
            //Console.ReadLine();


            //=================================================================

            //List<string> names = new List<string>() { "Jesse", "Erik", "Adam", "Daniel" };

            //foreach(string name in names)
            //{
            //    Console.WriteLine(name);
            //}
            //Console.ReadLine();



            //=================================================================
            //HOW TO TRANSFER DATA FROM ONE LIST TO ANOTHER!!!!!!!!!!
            //=================================================================

            List<int> testScores = new List<int>() { 98, 99, 12, 74, 23, 99 };
            List<int> passingScores = new List<int>();

            foreach(int score in testScores)
            {
                if(score > 85)
                {
                    passingScores.Add(score);
                }
            }

            Console.WriteLine(passingScores.Count);
            Console.ReadLine();



        }
    }
}
