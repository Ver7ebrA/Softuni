using System;
using System.Text;


namespace GenericBox
{
    public class Box<T> : IComparable<T>
        where T : IComparable<T>
    {
        private T value;

        public Box(T value)
        {
            this.value = value;
        }

        public T Value
        {
            get { return this.value; }
        }

        public int CompareTo(T other)
        {
            return this.value.CompareTo(other);
        }

        public override string ToString()
        {
            var result = $"{this.Value.GetType().FullName}: {this.Value}";
            return result;
        }
    }
}
