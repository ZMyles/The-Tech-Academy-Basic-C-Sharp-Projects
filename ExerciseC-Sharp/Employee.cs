using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciseC_Sharp
{
    public class Employee : Person, IQuittable
    {
        public int ID { get; set; }

        public override void SayName()
        {
            base.SayName();
        }

        public static bool operator == (Employee employee, Employee employee1)
        {
            bool reuslt = employee == employee1;
            return reuslt;
        }

        public static bool operator != (Employee employee, Employee employee1)
        {
            bool reuslt = employee != employee1;
            return reuslt;
        }

        //public override void Test()
        //{

        //}

        //IQUITTABLE ============================================

        public void Quit()
        {
            Console.WriteLine("I quite...");
        }


       

    }
}
