using System;
using System.Linq;

namespace Task7
{
    class Program
    {
        private static int[] ReplacElementsInArray(int[] masOrigin)
        {
            int[] mas = (int[])masOrigin.Clone();
            int[] resultMas = new int[mas.Length];

            for (int i = 0; i < mas.Length - 1; i++)
            {
                mas[i] = 0;
                resultMas[i] = mas.Max();
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
