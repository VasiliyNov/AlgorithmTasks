using System;

namespace Task7_way_2
{
    class Program
    {
        private static int MaxValueStartingFromIndex(int index, int[] mas)
        {
            int max = mas[index];

            for (int i = index; i < mas.Length; ++i)
            {
                if (mas[i] > max)
                {
                    max = mas[i];
                }
            }
            return Array.IndexOf(mas, max);
        }

        private static int[] ReplacElementsInArray(int[] mas)
        {
            int[] resultMas = new int[mas.Length];
            int ind;

            for (int i = 0; i < mas.Length - 1; i = ind)
            {
                ind = MaxValueStartingFromIndex(i + 1, mas);

                for (int j = i; j < ind; j++)
                {
                    resultMas[j] = mas[ind];
                }
            }
            resultMas[^1] = -1;

            return resultMas;
        }
        static void Main(string[] args)
        {
            int[] arr = new[] { 17, 18, 5, 4, 6, 1 };

            int[] arrResult = ReplacElementsInArray(arr);

            foreach (var item in arrResult)
            {
                Console.Write(item + " ");
            }
        }
    }
}
