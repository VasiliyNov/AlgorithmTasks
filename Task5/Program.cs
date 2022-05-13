using System;
using System.Collections.Generic;
using System.Linq;

namespace Task5
{
    public class Program
    {
        public static List<int> GetDigitsFromNumber(int number)
        {
            if (number < 0)
            {
                throw new ArgumentException(
                    string.Format("Parameter '{0}' must be positive number.", nameof(number)));
            }

            string tmpStr = Convert.ToString(number);

            return tmpStr.Select(e => Convert.ToInt32(e.ToString())).ToList();
        }

        public static bool IsDividableByEveryDigit(int number, List<int> digits)
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

        public static List<int> CheckSelfDividingNumber(int left, int right)
        {
            if (left < 0 || right < 0 || right < left)
            {
                throw new ArgumentException(string.Format(
                    "Parameters '{0}' and '{1}' must be positive numbers. And '{1}' must be bigger than '{0}'.",
                    nameof(left), nameof(right)));
            }

            List<int> selfDividingNumbers = new();

            for (int i = left; i <= right; i++)
            {
                if (IsDividableByEveryDigit(i, GetDigitsFromNumber(i)))
                {
                    selfDividingNumbers.Add(i);
                }
            }

            return selfDividingNumbers;
        }

        static void Main(string[] args)
        {
            List<int> selfDividingNumbers = CheckSelfDividingNumber(0, 20);

            foreach (var item in selfDividingNumbers)
            {
                Console.WriteLine(item);
            }
        }
    }
}
