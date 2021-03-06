using System;
using System.Collections.Generic;
using System.Linq;

namespace Task1
{
    public class Program
    {
        public static int FindFrequentElement(int[] nums)
        {
            if (nums == null)
            {
                throw new ArgumentNullException(nameof(nums));
            }

            if (nums.Length == 0)
            {
                throw new ArgumentException("Array cannot be empty", nameof(nums));
            }

            Dictionary<int, int> frequentNumbers = new Dictionary<int, int>();

            for (int i = 0; i < nums.Length; i++)
            {
                if (frequentNumbers.ContainsKey(nums[i]))
                {
                    frequentNumbers[nums[i]]++;
                }
                else
                {
                    frequentNumbers.Add(nums[i], 1);
                }
            }

            return frequentNumbers.SingleOrDefault(pair => pair.Value == frequentNumbers.Values.Max()).Key;
        }

        static void Main(string[] args)
        {
            int[] numbers = new int[] { 1, 2, 2, 2, 2, 5, 5, 6, 7, 8 };

            Console.WriteLine(FindFrequentElement(numbers));
        }
    }
}
