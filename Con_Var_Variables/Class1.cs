using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Con_Var_Variables
{
    class Class1
    {

        public string first;
        public string last;
        public int id;

        public Class1(string s1):this(s1,"-",0)
        {

        }

        public Class1(string s1, string s2):this(s1,s2,0)
        {
           
        }

        public Class1(string s1, string s2, int number)
        {
            first = s1;
            last = s2;
            id = number;
        }

        public void Print()
        {
            Console.WriteLine(id + ":" + first + " " + last);
        }


        static void Main(string[] args) {

            Class1 cust = new Class1("roberts", "Marks");
            cust.Print();
        }
    }
}
