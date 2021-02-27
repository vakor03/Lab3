using System;

namespace Lab3
{
    public struct LinkedList<T>
    {
        private  int _pointer;
        private T[] _values;
        public LinkedList(T[] values)
        {
            _pointer = 0;
            this._values = values;
        }
        public void Add(T el)
        {
            T[] temp = new T[_values.Length+1];
            Array.Copy(_values,temp,_values.Length);
            temp[temp.Length - 1] = el;
            _values = temp;
        }
        public int GetLength()
        {
            return _values.Length;
        }
        public void PointerToNull()
        {
            _pointer = 0;
        }
        public T GetNext()
        {
            return _values[_pointer++];
        }
    }
}