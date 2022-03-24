using System;

namespace Task12
{
    class Program
    {
        private static Node<T> GetMiddleNode<T>(MyList<T> list)
        {
            Node<T> stepX1 = list.First;
            Node<T> stepX2 = list.First;

            while (stepX2 != null && stepX2.Next != null)
            {
                stepX1 = stepX1.Next;
                stepX2 = stepX2.Next.Next;
            }

            return stepX1;
        }

        static void Main(string[] args)
        {
            MyList<int> myList = new(new int[] { 1, 2, 3, 4, 5, 6 });

            Node<int> middleNode = GetMiddleNode(myList);

            Console.WriteLine($"middleNode.Value = {middleNode.Data}");

            while (middleNode.Next != null)
            {
                middleNode = middleNode.Next;
                Console.WriteLine(middleNode.Data);
            }
        }
    }
}
