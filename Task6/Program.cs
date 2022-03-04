using System;
using System.Linq;

namespace Task6
{
    class Program
    {
        private static int CheckConsistentStrings(string allowed, string[] masWords)
        {
            int accumulate = 0;

            for (int i = 0; i < masWords.Length; i++)
            {
                if (masWords[i].All((el) => allowed.Contains(el)))
                {
                    accumulate++;
                }
            }
            return accumulate;
        }

        static void Main(string[] args)
        {
            string allowed = "ab";
            string[] words = new[] { "a", "b", "c", "ab", "ac", "bc", "abc" };

            Console.WriteLine(CheckConsistentStrings(allowed, words)); 
        }
    }
}