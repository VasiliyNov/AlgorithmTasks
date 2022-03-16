using System;
using System.Collections.Generic;
using System.Linq;

namespace Task11
{
    class Program
    {
        private static int GetLuckyInteger(int[] arr)
        {
            Dictionary<int, int> luckyIntegers = new();

            for (int i = 0; i < arr.Length; i++)
            {
                if (!luckyIntegers.ContainsKey(arr[i]))
                {
                    luckyIntegers.Add(arr[i], 1);
                }
                else
                {
                    luckyIntegers[arr[i]]++;
                }
            }

            luckyIntegers = new Dictionary<int, int>(luckyIntegers.Where(l => l.Key == l.Value));

            if (luckyIntegers.Count > 0)
            {
                return luckyIntegers.Values.Max();
            }
            else
            {
                return -1;
            }
        }

        static void Main(string[] args)
        {
            int[] arr1 = new[] { 1, 2, 2, 3, 3, 3 };// 3
            Console.WriteLine(GetLuckyInteger(arr1));

            int[] arr2 = new[] { 2, 2, 3, 4 };// 2
            Console.WriteLine(GetLuckyInteger(arr2));

            int[] arr3 = new[] { 2, 2, 2, 3, 3 };// -1, there are no lucky numbers
            Console.WriteLine(GetLuckyInteger(arr3));
        }
    }
}
