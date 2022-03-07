using System;
using System.Linq;

namespace Task8
{
    class Program
    {
        private static int GetMountainPeakIndex(int[] array)
        {
            return Array.IndexOf(array, array.Max());
        }

        static void Main(string[] args)
        {
            int[] arr = new[] { 24, 69, 100, 99, 79, 78, 67, 36, 26, 19 };

            Console.WriteLine(GetMountainPeakIndex(arr));
        }
    }
}
