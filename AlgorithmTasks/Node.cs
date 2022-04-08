using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmTasks
{
    public class Node<T> where T : IComparable<T>
    {
        public Node() { }
        public Node(T value, Node<T> next = null)
        {
            Data = value;
            Next = next;
        }

        public T Data { get; set; }
        public Node<T> Next { get; set; }
    }
}
