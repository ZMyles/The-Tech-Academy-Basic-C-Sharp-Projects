using System;
using System.Collections.Generic;
using System.Text;

namespace MultiMethod
{
    class Class1
    {

        public static int AdditonMethod(int j, string i)
        {
            //Code figure outs where they entered a number or didn't add anything
            if (i == "")
            {
                int noInput = 10;
                int result = j + noInput;
                return result;
            }
            else
            {
                int realNumber = Convert.ToInt32(i);
                int result = j + realNumber;
                return result;
            }
        }
    }
 }
