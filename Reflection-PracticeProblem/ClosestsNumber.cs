using System;
using System.Collections.Generic;
using System.Text;

namespace Reflection_PracticeProblem
{
    public class ClosestsNumber
    {
        public static void FindClosestsNumber()
        {
            Console.WriteLine("Enter the Number");
            int number = Convert.ToInt32(Console.ReadLine());

            int CloseNumber = number;

            if (number < 0)
            {
                CloseNumber = -CloseNumber;
            }
            while (true)
            {
                CloseNumber++;

                if (CheckEvenDigitsNumber(CloseNumber))
                {
                    break;
                }
            }

            Console.WriteLine("The Closest Even Digit Number of the given input number is : " + CloseNumber);
        }

        private static bool CheckEvenDigitsNumber(int number)
        {
            foreach (char digit in number.ToString())
            {
                int Value = (int)char.GetNumericValue(digit);
                if (Value % 2 != 0)
                {
                    return false;
                }
            }
            return true;
        }
    }
}
