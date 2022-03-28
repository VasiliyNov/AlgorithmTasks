using System;

namespace Task14
{
    class Program
    {
        private static T[] QuickSort<T>(T[] array, int minIndex, int maxIndex) where T : IComparable<T>
        {
            if (minIndex >= maxIndex)
            {
                return array;
            }

            int pivotIndex = GetPivotIndex(array, minIndex, maxIndex);

            QuickSort(array, minIndex, pivotIndex - 1);

            QuickSort(array, pivotIndex + 1, maxIndex);

            return array;
        }

        private static int GetPivotIndex<T>(T[] array, int minIndex, int maxIndex) where T : IComparable<T>
        {
            int pivot = minIndex - 1;

            for (int i = minIndex; i <= maxIndex; i++)
            {
                if (array[i].CompareTo(array[maxIndex]) < 0)
                {
                    pivot++;
                    (array[pivot], array[i]) = (array[i], array[pivot]); // swap
                }
            }

            pivot++;
            (array[pivot], array[maxIndex]) = (array[maxIndex], array[pivot]); // swap

            return pivot;
        }

        private static MyList<T> MySort<T>(MyList<T> list) where T : IComparable<T>
        {
            return new MyList<T>(QuickSort(list.ToArray(), 0, list.Count - 1));
        }

        static void Main(string[] args)
        {
            MyList<int> list1 = new(new int[] { 4, 2, 1, 3 });
            MyList<string> list2 = new(new string[] { "2", "1", "B", "A" });

            foreach (var item in list1)
            {
                Console.WriteLine(item);
            }

            MyList<int> resultList = MySort(list1);

            Console.WriteLine("After sorting:");

            foreach (var item in resultList)
            {
                Console.WriteLine(item);
            }
        }
    }
}
