using System;

namespace Lab3
{
    public struct LinkedList<T>
    {
        private  int _pointer;
        private T[] values;

        public LinkedList(T[] values)
        {
            _pointer = 0;
            this.values = values;
        }

        public void Add(T el)
        {
            T[] temp = new T[values.Length+1];
            Array.Copy(values,temp,values.Length);
            temp[temp.Length - 1] = el;
            values = temp;
        }

        public T GetNext()
        {
            return values[_pointer++];
        }
    }
}