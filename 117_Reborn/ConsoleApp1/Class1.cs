using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace ConsoleApp1
{
     class Class1
    {
        public void DivideInt(int x)
        {
            int result = x / 2;
            Console.WriteLine(result);
        }

        //Second Method, OutPut
        public void OutPut(out int x, int y)
        {
            int temp = 5;
            x = temp;
        }

    }
}
