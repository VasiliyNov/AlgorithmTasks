using System;

namespace Task12
{
    class Program
    {
        private static Node<T> GetMiddleNode<T>(MyList<T> list)
        {
            Node<T> current = list.First;

            for (int i = 0; i < list.Count / 2; i++)
            {
                current = current.Next;
            }

            return current;
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
