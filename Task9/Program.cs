using System;
using System.Linq;

namespace Task9
{
    public class Program
    {
        public static string ReverseOrderOfCharactersInWords(string str)
        {
            if (str is null)
            {
                throw new ArgumentNullException(nameof(str));
            }

            return string.Join(" ", str.Split().Select(s => new string(s.Reverse().ToArray())));
        }

        static void Main(string[] args)
        {
            string s = "Let's take LeetCode contest";

            Console.WriteLine(ReverseOrderOfCharactersInWords(s));
        }
    }
}
