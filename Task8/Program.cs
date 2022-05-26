using System;
using System.Linq;

namespace Task8
{
    public class Program
    {
        public static int GetMountainPeakIndex(int[] array)
        {
            if (array is null)
            {
                throw new ArgumentNullException(nameof(array));
            }

            if (array.Length > 0)
            {
                return Array.IndexOf(array, array.Max());
            }
            else
            {
                throw new ArgumentException("Array cannot be empty", nameof(array));
            }
        }

        static void Main(string[] args)
        {
            int[] arr = new[] { 24, 69, 100, 99, 79, 78, 67, 36, 26, 19 };

            Console.WriteLine(GetMountainPeakIndex(arr));
        }
    }
}
