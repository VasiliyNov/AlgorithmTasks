using System;
using System.Linq;
using AlgorithmTasks;

namespace Task16
{
    class Program
    {
        private static int GetReversedNumberAsInt(MyList<int> inputList)
        {
            Node<int> node = inputList.First;
            string strNumber = string.Empty;

            while (node != null)
            {
                strNumber += node.Data;
                node = node.Next;
            }

            return int.Parse(strNumber.Reverse().ToArray());
        }

        private static MyList<int> SumOfTwoLists(MyList<int> inputList1, MyList<int> inputList2)
        {
            string sum = (GetReversedNumberAsInt(inputList1) + GetReversedNumberAsInt(inputList2)).ToString();

            MyList<int> sumList = new();

            for (int i = sum.Length - 1; i >= 0; i--)
            {
                sumList.AddLast(int.Parse(sum[i].ToString()));
            }

            return sumList;
        }

        static void Main(string[] args)
        {
            MyList<int> l1 = new(new int[] { 3, 2, 1 });
            MyList<int> l2 = new(new int[] { 8, 9, 1 });

            MyList<int> res = SumOfTwoLists(l1, l2); // 321(reversed 123)

            foreach (var item in res)
            {
                Console.Write(item);
            }
        }
    }
}
