using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task15
{
    class MyList<T> : IEnumerable where T : IComparable<T>
    {
        public MyList() { }

        public MyList(MyList<T> inputList)
        {
            if (inputList != null)
            {
                Node<T> inputNode = inputList.First;

                while (inputNode != null)
                {
                    this.AddLast(inputNode.Data);
                    _count++;
                    inputNode = inputNode.Next;
                }
            }
        }

        public MyList(IEnumerable<T> collection)
        {
            if (collection.Any())
            {
                Node<T> current = _head = new Node<T>(collection.First());
                _count++;

                for (int i = 1; i < collection.Count(); i++)
                {
                    current.Next = new Node<T>(collection.ElementAt(i));
                    _count++;
                    current = current.Next;
                }
            }
        }

        private int _count = 0;
        private Node<T> _head;

        public int Count => _count;
        public Node<T> First => _head;

        public void AddLast(T value)
        {
            if (_head == null)
            {
                _head = new Node<T>(value);
                _count++;
            }
            else
            {
                Node<T> current = _head;

                while (current.Next != null)
                {
                    current = current.Next;
                }

                current.Next = new Node<T>(value);
                _count++;
            }
        }

        public T[] ToArray()
        {
            T[] arr = new T[this._count];
            Node<T> current = _head;
            int i = 0;

            while (current != null)
            {
                arr[i++] = current.Data;
                current = current.Next;
            }

            return arr;
        }

        public IEnumerator GetEnumerator()
        {
            Node<T> current = _head;

            while (current != null)
            {
                yield return current.Data;
                current = current.Next;
            }
        }
    }
}
