using System;
using System.Linq;

namespace Task9
{
    class Program
    {
        private static string ReverseOrderOfCharactersInWords(string str)
        {
            return string.Join(" ", str.Split().Select(s => new string(s.Reverse().ToArray())));
        }

        static void Main(string[] args)
        {
            string s = "Let's take LeetCode contest";

            Console.WriteLine(ReverseOrderOfCharactersInWords(s));
        }
    }
}
