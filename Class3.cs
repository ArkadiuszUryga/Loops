using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loops
{
    internal class Class3
    {
        public static void Task3() {
            for (int i = 2; i <= 50; i++)
            {
                if (i % 2 == 0) Console.Write(i+", ");
            }
        }
    }
}
