using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loops
{
    internal class Class6
    {
        public static void Task6()
        {
            //write numbers divisible by 3 or 5 (in the range of 1..100)
            
            for (int i = 1; i < 101; i++)
            {
                if ((i % 3 == 0) || (i%5==0)) {
                    Console.Write(i+", ");
                }
            }
        }
    }
}
