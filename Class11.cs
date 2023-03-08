using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loops
{
    internal class Class11
    {
        public static void Task11()
        {
            //calculate the greatest common divisor of 2 numbers given as parameters
            Console.WriteLine("Please enter first number");
            int number1 = Program.GetNumberFromUser();
            Console.WriteLine("Thank You, Now we are waiting for another number");
            int number2 = Program.GetNumberFromUser();
            Console.WriteLine("NWD dla "+number1+" i "+number2+" wynosi: "+GreatestCommonDivisor(number1,number2));
        }
        private static int GreatestCommonDivisor(int number1, int number2)
        {

            if (number1 < number2)
            {
                int a=number1;
                number1 = number2;
                number2 = a;
            }
            int b = 0;
            do
            {
                b=number1%number2;
                number1= number2;
                number2 = b;

            } while (number2==0);
            
            return number1;
        }
    }
}
