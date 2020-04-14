using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace StackEx
{
    class Stack<T> : IEnumerable<T>
    {
        private List<T> elements;
        private int index = - 1;

        public Stack()
        {
            this.elements = new List<T>();
        }
        public IEnumerator<T> GetEnumerator()
        {
            for (int i = index; i >= 0; i--)
            {
                yield return elements[i];
            }
        }

        public void Push(params T[] items)
        {
            foreach (var item in items)
            {
                elements.Insert(++index, item);
            }
        }

        public void Pop()
        {
            if (index < 0)
            {
                Console.WriteLine("No elements");
            }
            else
            {
                elements.RemoveAt(index);
                index--;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
    }
}
