using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task12
{
    class Node<T>
    {
        public Node(T value, Node<T> next = null)
        {
            Data = value;
            Next = next;
        }
        public Node() { }

        public T Data { get; set; }
        public Node<T> Next { get; set; }
    }
}
