using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loops
{
    internal class Class5
    {
        public static void Task5()
        {
            //write numbers divisible by 8 (in the range 1..100)

            for (int i = 1; i <=100; i++)
            {
                if (i%8==0)
                {
                    Console.Write(i+", ");
                }
            }
        }
    }
}
