using System;
using System.Linq;

namespace Task6
{
    public class Program
    {
        public static int CheckConsistentStrings(string allowed, string[] masWords)
        {
            if (masWords is null || allowed is null)
            {
                throw new ArgumentNullException(
                    string.Format("{0}, {1}", nameof(allowed), nameof(masWords)));
            }

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