using System;
using System.Collections;
using System.Collections.Generic;

namespace Lab3
{
    public struct HashTable
    {
        private int _length;
        private LinkedList<int>[] _table;

        public HashTable(int length)
        {
            _length = length;
            _table = new LinkedList<int>[_length];
        }

        /*public static HashFunction(string str)
        {
            
        }*/
    }
}