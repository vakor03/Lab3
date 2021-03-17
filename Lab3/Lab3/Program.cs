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
            Console.Write("Type a sentence to get definition: ");
            string[] words = Console.ReadLine().Split('!','?','.',',',' ');
            foreach (var word in words)
            {
                Console.WriteLine();
                Console.WriteLine($"{word}: {string.Join(",", hashTable.GetByNameNew(word))}");
            }
            
        }

        public static HashTable InitTable()
        {
            ReadFile file = new ReadFile(@"..\..\..\..\..\dict_processed.txt");
            HashTable hashTable = new HashTable(50);
            hashTable.FillTable(file.Read());
            return hashTable;
        }
    }
}