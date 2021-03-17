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
            int prime = 79;
            ulong hash = 0;
            for (int i = 0; i < str.Length; i++)
            {
                hash = (hash * (ulong)prime) + str[i];
            }
            return (int)(hash%(ulong)_length);
        }

        public void FillTable(List<string> input)
        {
            int NStr = 0;
            double k;
            foreach (var str in input)
            {
                k = (double) NStr / _length;
                if (k > 0.8)
                {
                    ResizeHashTable();
                }
                string firstWord = "";
                for (int i = 0; i < str.Length && str[i]!=';'; i++)
                {
                    firstWord += str[i];
                }
                _table[HashFunction(firstWord)].AddToBeginning(str);
                NStr++;
            }
        }

        public string GetByIndex(int i)
        {
            return _table[i].GetElems();
        }

        private void ResizeHashTable()
        {
            _length *= 2;
            LinkedList<string>[] temp = new LinkedList<string>[_length];
            foreach (var linkedList in _table)
            { 
                Object<string> current = linkedList.Head;
                while (current != null)
                {
                    string firstWord = "";
                    for (int i = 0; i < current.Data.Length && current.Data[i]!=';'; i++)
                    {
                        firstWord += current.Data[i];
                    }
                    temp[HashFunction(firstWord)].AddToBeginning(current.Data);
                    current = current.Next;
                }
            }
            _table = temp;
        }

        public string GetByName(string name)
        {
            string definition = "";
            int index = HashFunction(name.ToUpper());
            Object<string> current = _table[index].Head;
            while (current != null)
            {
                if (current.Data.Split(';')[0] == name.ToUpper())
                {
                    definition = current.Data;
                    break;
                }
                current = current.Next;
            }

            return definition;
        }
    }
}