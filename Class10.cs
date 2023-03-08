using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace Loops
{
    internal class Class10
    {
        public static void Task10()
        {
            // sprawdź czy podana jako parametr liczba jest liczbą pierwszą. (podzielna tylko przez 1 i przez samą siebie)
            Console.WriteLine("Please, enter a number, then you'll know if it's prime!");
            int numberFromUser = Program.GetNumberFromUser();
            if (IsPrimeNumber(numberFromUser)==true)
            {
                Console.WriteLine("Number "+numberFromUser+" is a prime number!");
            }
            else
            {
                Console.WriteLine("Number " + numberFromUser + " is not a prime number!");
            }
        }
        public static bool IsPrimeNumber(int n)
        {
            
            if (n <=2) return true;
            for (int i = 2; i < n; i++)
            {
                if (n % i == 0) return false;
            }
            return true;
        }
    }
}
