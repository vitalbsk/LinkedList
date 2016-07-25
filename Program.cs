using System;

namespace DataStructure.LinkedList
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Linked list.");
            LinkedList<int> list = new LinkedList<int>();
            list.AddFirst(1);
            list.AddLast(2);
            Console.WriteLine(list);
        }
    }
}
