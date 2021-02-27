using System;

namespace Lab3
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedList<int> lL = new LinkedList<int>(new int[]{1,2});
            lL.Add(12);
            Console.WriteLine(lL.GetNext());
            Console.WriteLine(lL.GetNext());
            }
    }
}