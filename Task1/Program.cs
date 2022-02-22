using System;

namespace Task1
{
    class Program
    {
        private static int FindFrequentElement1(int[] nums)
        {
            int number = 0;
            int maxFrequent = 0;
            int frequent = 1;

            for (int i = 1; i < nums.Length; i++)
            {
                if (nums[i] == nums[i - 1])
                {
                    frequent++;
                }
                else
                {
                    frequent = 1;
                }

                if (frequent > maxFrequent)
                {
                    maxFrequent = frequent;
                    number = nums[i-1];
                }
            }

            return number;
        }

        private static int FindFrequentElement2(int[] nums)
        {
            int number = 0;
            int maxFrequent = 0;
            
            for (int i = 0; i < nums.Length; i++)
            {
                int frequent = 0;
                for (int j = 0; j < nums.Length; j++)
                {
                    if (nums[i] == nums[j])
                    {
                        frequent++;
                    }

                    if (frequent > maxFrequent)
                    {
                        maxFrequent = frequent;
                        number = nums[i];
                    }
                }
            }
                return number;
        }
        static void Main(string[] args)
        {
            int[] numbers = new int[] { 1, 2, 2, 2, 2, 5, 5, 6, 7, 8 };
            

            Console.WriteLine(FindFrequentElement2(numbers));
        }
    }
}
