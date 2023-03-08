using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loops
{
    internal class Class8
    {
        public static void Task8()
        {
            //Write the largest number that is not divisible by 2,3,5,7 but less than 1000

            int b=0;

            for (int i = 1000; i>0 ; i--)
            {
                b = i;
                if ((i % 2 != 0)&&(i%3!=0) && (i % 5 != 0) && (i % 5 != 0)) break;

            }
            Console.WriteLine(b);
            
        }
    }
}
