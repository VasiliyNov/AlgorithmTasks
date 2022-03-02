using System;
using System.Collections.Generic;
using System.Linq;

namespace Task5
{
    class Program
    {
        private static List<int> GetDigitsFromNumbers(int number)
        {
            string tmpStr = Convert.ToString(number);

            return tmpStr.Select(e => Convert.ToInt32(e.ToString())).ToList();
        }

        private static bool IsDividableByEveryDigit(int number, List<int> digits)
        {
            foreach (var item in digits)
            {
                if (item == 0 || number % item != 0)
                {
                    return false;
                }
            }
            return true;
        }

        private static void CheckSelfDividingNumber(int left, int right)
        {
            for (int i = left; i <= right; i++)
            {
                if (IsDividableByEveryDigit(i, GetDigitsFromNumbers(i)))
                {
                    Console.WriteLine(i);
                }
            }
        }

        static void Main(string[] args)
        {
            CheckSelfDividingNumber(0, 22);
        }
    }
}
