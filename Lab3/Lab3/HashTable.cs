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

        public int HashFunction(string str)
        {
            int prime = 31;
            ulong hash = 0;
            for (int i = 0; i < str.Length; i++)
            {
                hash = (hash * (ulong)prime) + str[i];
            }
            return (int)hash%_length;
        }
    }
}