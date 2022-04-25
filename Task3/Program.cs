using System;
using System.Collections.Generic;
using System.Linq;

namespace Task3
{
    public class Program
    {
        public static void SortPairedUnpairedNumbers(int[] mas)
        {
            if (mas == null)
            {
                throw new ArgumentNullException(nameof(mas));
            }

            if (mas.Length > 1)
            {
                Stack<int> paired = new();
                Stack<int> unpaired = new();

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

                int j = 0;

                while (unpaired.Any())
                {
                    mas[j++] = paired.Pop();
                    mas[j++] = unpaired.Pop();
                }
            }
        }
        static void Main(string[] args)
        {
            int[] numbers1 = new int[] { 0, 1, 3, 5, 7, 4, 6, 8, 10, 11, 12, 12, 12, 12, 0, 0, 1, 1, 2, 2, 7, 7, 7, 7, 7, 7 };

            SortPairedUnpairedNumbers(numbers1);

            for (int i = 0; i < numbers1.Length; i++)
            {
                Console.WriteLine($"nums[{i}]: {numbers1[i]}");
            }
        }
    }
}
