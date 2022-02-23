using System;

namespace Task2
{
    class Program
    {
        private static void CheckingDivisionBy3And5(int n)
        {
            if (n % 3 == 0 && n % 5 == 0)
            {
                Console.WriteLine("FizzBuzz");
            }
            else if (n % 3 == 0)
            {
                Console.WriteLine("Fizz");
            }
            else if (n % 5 == 0)
            {
                Console.WriteLine("Buzz");
            }
            else
            {
                Console.WriteLine(Convert.ToString(n));
            }
        }

        static void Main(string[] args)
        {
            int n;

            while (true)
            {
                Console.Write("Enter the integer:");
                n = Convert.ToInt32(Console.ReadLine());
                CheckingDivisionBy3And5(n);
            }
        }
    }
}
