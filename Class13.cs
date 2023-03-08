using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loops
{
    internal class Class13
    {
        public static void Task13()
        {
            Console.WriteLine("Please enter your PESEL number (11 digits)");
            String number1 = Program.GetStringFromUser();
            if (ValidPesel(number1) == true)
            {
                Console.WriteLine("The number is Valid");
            }
            else Console.WriteLine("It looks like a wrong number");
        }
        private static bool ValidPesel (String number)
        {
            int checkSum;
            //valid number must have 11 digits
            if (number.Length !=11) return false;

           //split the string to single characters and convert to numbers
            Char[] CharsArray = number.ToCharArray();
            int[] Aint = Array.ConvertAll(CharsArray, c => (int)Char.GetNumericValue(c));

            //for the next ten digits of the PESEL identifier, the product of the digit and its weight is calculated (Ik=ck·wk)
            int[] w_k = new int[] { 1, 3, 7, 9, 1, 3, 7, 9, 1, 3, 0 };
            int TheSum = 0;
            for (int i = 0; i < 10; i++)
            {
                w_k[i] = Aint[i] * w_k[i];
                //the sum of these products is calculated(S=? Ik),
                TheSum += w_k[i];
            }
            //the value M of the operation S modulo 10 is calculated,
            int M = TheSum % 10;
            //if the number M is equal to zero, the check number(digit) of the PESEL number is also equal to zero.
            if (M == 0) checkSum= 0;
            //the number M is subtracted from the number ten,
            else     checkSum = 10 - M;
            TheSum += checkSum;
            //If the last digit of the received sum is zero, then the PESEL number has the correct check digit, otherwise the number is incorrect.
           if(TheSum%10!=0) return false;

            foreach (int i in w_k)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("Suma: "+TheSum);
            return true;
        }

    }
}
