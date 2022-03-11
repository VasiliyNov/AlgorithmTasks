using System;

namespace Task10
{
    class Program
    {
        private static char[] ReverseOfCharactersInArray(char[] charStr)
        {
            if (1 <= charStr.Length && charStr.Length <= 105)
            {
                var resultArr = new char[charStr.Length];
                int counter = 0;

                for (int i = charStr.Length - 1; i > -1; i--)
                {
                    resultArr[counter] = charStr[i];
                    counter++;
                }
                return resultArr;
            }
            return Array.Empty<char>();
        }

        static void Main(string[] args)
        {
            char[] s = new char[] { 'h', 'e', 'l', 'l', 'o' };
            
            Console.WriteLine(ReverseOfCharactersInArray(s));
        }
    }
}
