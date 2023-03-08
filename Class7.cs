using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loops
{
    internal class Class7
    {
        //write out numbers divisible by 3 or 5 (in the range 1..100) (do not write out those divisible by 3 and 5 at the same time)
        public static void Task7()
        {
            for (int i = 1; i < 101; i++)
            {
                if ((i % 3 == 0) || (i % 5 == 0) && (i % 15 != 0)) Console.Write(i+", ");
                
            }
        }
    }
}
