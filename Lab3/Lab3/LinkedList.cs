using System;

namespace Lab3
{
    public class Object<T>
    {
        public T Data;
        public Object<T> Next = null;

        public Object (T data)
        {
            Data = data;
        }
    }
    public struct LinkedList<T>
    {
        private Object<T> _head;

        public void AddToBeginning(T data)
        {
            Object<T> obj = new Object<T>(data);
            if (_head == null)
            {
                _head = obj;
            }
            else
            {
                obj.Next = _head;
                _head = obj;
            }
        }

        public void AddToTheEnd(T data)
        {
            Object<T> obj = new Object<T>(data);
            if (_head == null)
            {
                _head = obj;
            }
            else
            {
                Object<T> current = _head;
                while (current.Next != null)
                {
                    current = current.Next;
                }

                current.Next = obj;
            }
        }

        public void PrintElems()
        {
            Object<T> current = _head;
            while (current != null)
            {
                Console.WriteLine(current.Data.ToString());
                current = current.Next;
            }
        }
    }
}