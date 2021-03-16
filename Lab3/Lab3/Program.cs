using System;

namespace Lab3
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO: LinkedList
            //TODO: HashTable
            //TODO: Reading from command line?
            //TODO: Finding algo
            HashTable hashTable = InitTable();
            
            foreach (var word in args)
            {
                Console.WriteLine();
                Console.WriteLine(hashTable.GetByName(word));
            }
            
        }

        public static HashTable InitTable()
        {
            ReadFile file = new ReadFile(@"..\..\..\..\..\dict_processed true.txt");
            HashTable hashTable = new HashTable(50);
            hashTable.FillTable(file.Read());
            return hashTable;
        }
    }
}