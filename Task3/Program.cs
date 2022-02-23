using System;
using System.Collections.Generic;
using System.Linq;

namespace Task3
{
    class Program
    {
        private static void SortPairedUnpairedNumbers(int[] mas)
        {
            Stack<int> paired = new();
            Stack<int> unpaired = new();
            List<int> result = new();

            for (int i = 0; i < mas.Length; i++)
            {
                if (mas[i] % 2 == 0)
                {
                    paired.Push(mas[i]);
                }
                else
                {
                    unpaired.Push(mas[i]);
                }
            }
            while (unpaired.Any())
            {
                result.Add(paired.Pop());
                result.Add(unpaired.Pop());
            }
            for (int i = 0; i < result.Count; i++)
            {
                Console.WriteLine($"nums[{i}]: {result[i]}");
            }
        }
        static void Main(string[] args)
        {
            int[] numbers1 = new int[] { 0, 1, 3, 5, 7, 4, 6, 8, 10, 11, 12, 12, 12, 12, 0, 0, 1, 1, 2, 2, 7, 7, 7, 7, 7, 7 };
            SortPairedUnpairedNumbers(numbers1);
        }
    }
}
