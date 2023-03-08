using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loops
{
    internal class Class12
    {
        public static void Task12()
        {
            //how many prime numbers are there in the range a through b given as parameters
            Console.WriteLine("Please enter first number");
            int number1 = Program.GetNumberFromUser();
            Console.WriteLine("Thank You, Now we are waiting for another number");
            int number2 = Program.GetNumberFromUser();
            Console.WriteLine("There are "+HowManyPrimeNumbers(number1,number2)+" prime numbers in th egiven range");
        }
        private static int HowManyPrimeNumbers(int number1, int number2)
        {
            int result = 0;
            for (int i = number1; i <=number2; i++)
            {
                if (Class10.IsPrimeNumber(i)==true) result++;

            }
            return result;
        }
    }
}
