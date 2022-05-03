using System;
using System.Collections.Generic;
using System.Linq;

namespace Task4
{
    public class Program
    {
        public static bool CheckUniqueOccurrencesInArray(int[] arr)
        {
            if (arr == null)
            {
                throw new ArgumentNullException(nameof(arr));
            }

            if (arr.Length == 0)
            {
                throw new ArgumentException("Array cannot be empty.", nameof(arr));
            }

            Dictionary<int, int> uniqueOccurrences = new();

            for (int i = 0; i < arr.Length; i++)
            {
                if (!uniqueOccurrences.ContainsKey(arr[i]))
                {
                    uniqueOccurrences.Add(arr[i], 1);
                }
                else
                {
                    uniqueOccurrences[arr[i]]++;
                }
            }

            return !uniqueOccurrences.GroupBy(x => x.Value).Any(v => v.Count() > 1);
        }

        static void Main(string[] args)
        {
            int[] numbers = new int[] { 1, 2, 3, 3, 3, 5, 5, 5, 5, 2 };

            Console.WriteLine(CheckUniqueOccurrencesInArray(numbers));
        }
    }
}
