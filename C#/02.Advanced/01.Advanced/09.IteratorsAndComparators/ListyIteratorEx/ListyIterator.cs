using System;
using System.Collections;
using System.Collections.Generic;

namespace ListyIteratorEx
{
    public class ListyIterator<T> : IEnumerable<T>
    {
        private List<T> elements;
        int index;

        public ListyIterator(params T[] elements)
        {
            this.elements = new List<T>(elements);
        }

        public bool Move()
        {
            if (index < elements.Count - 1)
            {
                index++;
                return true;
            }

            return false;
        }

        public bool HasNext()
        {
            if (index + 1 < elements.Count)
            {
                return true;
            }

            return false;
        }

        public void Print()
        {
            if (elements.Count == 0)
            {
                Console.WriteLine("Invalid Operation!");
            }
            else
            {
                Console.WriteLine(elements[index]);
            }           
        }

        public IEnumerator<T> GetEnumerator()
        {
            foreach (T item in elements)
            {
                yield return item;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
    }
}
