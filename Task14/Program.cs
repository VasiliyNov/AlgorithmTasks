using System;

namespace Task14
{
    class Program
    {
        private static void SelectionSort<T>(MyList<T> list) where T : IComparable<T>
        {
            for (Node<T> iNode = list.First; iNode != null; iNode = iNode.Next)
            {
                T min = iNode.Data;
                Node<T> indexMin = iNode;

                for (Node<T> jNode = iNode.Next; jNode != null; jNode = jNode.Next)
                {
                    if (jNode.Data.CompareTo(min) < 0)
                    {
                        min = jNode.Data;
                        indexMin = jNode;
                    }
                }

                (iNode.Data, indexMin.Data) = (indexMin.Data, iNode.Data);
            }
        }

        static void Main(string[] args)
        {
            MyList<int> list1 = new(new int[] { 4, 2, 1, 3 });
            MyList<string> list2 = new(new string[] { "2", "1", "B", "A" });

            foreach (var item in list2)
            {
                Console.WriteLine(item);
            }

            SelectionSort(list2);
            Console.WriteLine("After sorting:");

            foreach (var item in list2)
            {
                Console.WriteLine(item);
            }
        }
    }
}
