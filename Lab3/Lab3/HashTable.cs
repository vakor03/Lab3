using System.Collections.Generic;

namespace Lab3
{
    public struct HashTable
    {
        private int _length;
        private LinkedList<string>[] _table;

        public HashTable(int length)
        {
            _length = length;
            _table = new LinkedList<string>[_length];
            for (int i = 0; i < _length; i++)
            {
                _table[i] = new LinkedList<string>();
            }
        }

        public int HashFunction(string str)
        {
            int prime = 31;
            ulong hash = 0;
            for (int i = 0; i < str.Length; i++)
            {
                hash = (hash * (ulong)prime) + str[i];
            }
            return (int)(hash%(ulong)_length);
        }

        public void FillTable(List<string> input)
        {
            foreach (var str in input)
            {
                _table[HashFunction(str.Split(';')[0])].AddToTheEnd(str);
            }
        }

        public string GetByIndex(int i)
        {
            return _table[i].GetElems();
        }
    }
}