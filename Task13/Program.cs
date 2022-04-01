using System;
using System.Collections.Generic;
using System.Linq;

namespace Task13
{
    class Program
    {
        private static MyList<T> DeleteDuplicates<T>(MyList<T> inputList) where T : IComparable<T>
        {
            Node<T> currentNode = inputList.First;
            Dictionary<T, int> uniqueValues = new();

            while (currentNode != null)
            {
                if (uniqueValues.ContainsKey(currentNode.Data))
                {
                    uniqueValues[currentNode.Data]++;
                }
                else
                {
                    uniqueValues.Add(currentNode.Data, 1);
                }

                currentNode = currentNode.Next;
            }

            return new MyList<T>(uniqueValues.Where(x => x.Value == 1).Select(k => k.Key));
        }

        static void Main(string[] args)
        {
            MyList<int> list = new(new int[] { 1, 2, 2, 2, 3, 4, 4, 6, 8, 8 });

            foreach (var item in list)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("After DeleteDuplicates(list):");

            MyList<int> res = DeleteDuplicates(list);

            foreach (var item in res)
            {
                Console.WriteLine(item);
            }
        }
    }
}
