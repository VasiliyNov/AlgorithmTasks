using System;

namespace Task2
{
    class Program
    {
        private static string[] CheckingDivisionBy3And5(int n)
        {
            string[] result = new string[n + 1];

            for (int i = 0; i <= n; i++)
            {
                if (i % 3 == 0 && i % 5 == 0)
                {
                    result[i] = "FizzBuzz";
                }
                else if (i % 3 == 0)
                {
                    result[i] = "Fizz";
                }
                else if (i % 5 == 0)
                {
                    result[i] = "Buzz";
                }
                else
                {
                    result[i] = Convert.ToString(i);
                }
            }
            return result;
        }

        static void Main(string[] args)
        {
            string[] answer = CheckingDivisionBy3And5(15);
            for (int i = 0; i < answer.Length; i++)
            {
                Console.WriteLine($"answer[{i}] == {answer[i]}");
            }
        }
    }
}
