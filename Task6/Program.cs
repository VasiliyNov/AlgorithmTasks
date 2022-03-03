using System;
using System.Linq;

namespace Task6
{
    class Program
    {
        private static void CheckConsistentStrings(string allowed, string[] masWords)
        {
            for (int i = 0; i < masWords.Length; i++)
            {
                if (!masWords[i].Any((el) => !allowed.Contains(el)))
                {
                    Console.WriteLine(masWords[i]);
                }
            }
        }

        static void Main(string[] args)
        {
            string allowed = "ab";
            string[] words = new[] { "a", "b", "c", "ab", "ac", "bc", "abc" };

            CheckConsistentStrings(allowed, words);
        }
    }
}