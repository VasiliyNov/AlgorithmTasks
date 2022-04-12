using System;
using AlgorithmTasks;

namespace Task17
{
    class Program
    {
        static void Main(string[] args)
        {
            MyList<int> list = new(new int[] { 1, 2, 3, 4, 5 });

            foreach (var item in list)
            {
                Console.Write(item);
            }

            list.RemoveFromEnd(2);
            Console.WriteLine("\nAfter RemoveFromEnd()");

            foreach (var item in list)
            {
                Console.Write(item);
            }
        }
    }
}
