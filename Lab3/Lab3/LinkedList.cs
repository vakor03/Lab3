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
        public Object<T> Head;
        
        public void AddToBeginning(T data)
        {
            Object<T> obj = new Object<T>(data);
            if (Head == null)
            {
                Head = obj;
            }
            else
            {
                obj.Next = Head;
                Head = obj;
            }
        }

        public void AddToTheEnd(T data)
        {
            Object<T> obj = new Object<T>(data);
            if (Head == null)
            {
                Head = obj;
            }
            else
            {
                Object<T> current = Head;
                while (current.Next != null)
                {
                    current = current.Next;
                }

                current.Next = obj;
            }
        }

        public string GetElems()
        {
            Object<T> current = Head;
            string output = "";
            while (current != null)
            {
                output += String.Concat("\n", current.Data.ToString());
                current = current.Next;
            }
            return output;
        }
    }
}