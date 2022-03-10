using System;

namespace Task10
{
    class Program
    {
        private static void ReverseOfCharactersInArray(char[] charStr)
        {
            if (1 <= charStr.Length && charStr.Length <= 105)
            {
                int i = 0;
                int j = charStr.Length - 1;

                while (i < j)
                {
                    (charStr[i], charStr[j]) = (charStr[j], charStr[i]);
                    i++;
                    j--;
                }
            }
        }

        static void Main(string[] args)
        {
            char[] s = new char[] { 'h', 'e', 'l', 'l', 'o' };

            ReverseOfCharactersInArray(s);
            Console.WriteLine(s);
        }
    }
}
