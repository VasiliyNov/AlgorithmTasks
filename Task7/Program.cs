using System;
using System.Collections.Generic;
using System.Linq;

namespace Task7
{
    public class Program
    {
        public static void ReplacElementsInArray(int[] array)
        {
            if (array is null)
            {
                throw new ArgumentNullException(nameof(array));
            }

            if (array.Length > 0)
            {
                List<int> tmpList = new List<int>(array);

                for (int i = 0; i < array.Length - 1; i++)
                {
                    array[i] = tmpList.GetRange(i + 1, tmpList.Count - i - 1).Max();
                }

                array[^1] = -1;
            }
        }

        static void Main(string[] args)
        {
            int[] arr = new[] { 17, 18, 5, 4, 6, 1 };

            ReplacElementsInArray(arr);

            foreach (var item in arr)
            {
                Console.Write(item + " ");
            }
        }
    }
}
