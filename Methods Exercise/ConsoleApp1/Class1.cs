using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{

    //TAKES TWO USER INPUTS INTO ONE METHOD =======
    class Class1
    {
        //Multipy ========================================
        public static int AddMethod(int x, int y)
        {
            int result = x * y;
            return result;
        }

        //    //Used for decimals ======================================
        public static int AddMethod(decimal x, decimal y)
        {

            int result2 = Convert.ToInt32(x + y);
            return result2;

        }
        //Strings to int===============================
        public static int AddMethod(string x, string y)
        {
             
            int s1 = Convert.ToInt32(x);
            int s2 = Convert.ToInt32(y);

            int module = s1 % s2;

            return module;

        }

    }
}
