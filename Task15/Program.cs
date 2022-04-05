using System;

namespace Task15
{
    class Program
    {
        private static MyList<T> MergeSortedLists<T>(MyList<T>[] inputArrList) where T : IComparable<T>
        {
            MyList<T> resultList = new(inputArrList[0]);

            for (int i = 1; i < inputArrList.Length; i++)
            {
                Node<T> resultNode = resultList.First;
                Node<T> inputNode = inputArrList[i].First;
                MyList<T> tmpList = new();

                while (resultNode != null && inputNode != null)
                {
                    if (resultNode.Data.CompareTo(inputNode.Data) < 0)
                    {
                        tmpList.AddLast(resultNode.Data);
                        resultNode = resultNode.Next;
                    }
                    else
                    {
                        tmpList.AddLast(inputNode.Data);
                        inputNode = inputNode.Next;
                    }
                }

                while (resultNode != null)
                {
                    tmpList.AddLast(resultNode.Data);
                    resultNode = resultNode.Next;
                }

                while (inputNode != null)
                {
                    tmpList.AddLast(inputNode.Data);
                    inputNode = inputNode.Next;
                }

                resultList = new(tmpList);
            }

            return resultList;
        }

        static void Main(string[] args)
        {
            MyList<int>[] arrList =
            {
                new(new int[] { 1, 4 }),
                new(new int[] { 3, 5, 6, 8 }),
                new(new int[] { 2, 5, 6, 9 }),
                new(new int[] { 7, 10, 11, 12, 13 })
            };

            MyList<int> res = MergeSortedLists(arrList);

            foreach (var item in res)
            {
                Console.WriteLine(item);
            }
        }
    }
}
