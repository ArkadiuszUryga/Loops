using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loops
{
    internal class Class9
    {
        public static void Task9()
        {
            //check, that the number given as a parameter is even
            Console.WriteLine("Please, enter a number, then you'll know if it's even!");
            int numberFromUser=Program.GetNumberFromUser();
            
            Console.WriteLine("Wybrałeś "+numberFromUser);
            if (numberFromUser%2==0)
            {
                Console.WriteLine("Your choosen number is even");
            }
            else { Console.WriteLine("Your choosen number is not even"); }
        }
    }
}
