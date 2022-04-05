using ConsoleApp.Challenges.linkedlist;
using System.Collections.Generic;
using System;

namespace ConsoleApp
{
    public class Program
    {
        static void Main(string[] args)
        {
            LinkedList list1 = new LinkedList();
            list1.Insert(3);
            list1.Insert(1);
            Console.WriteLine("First List:");
            Console.WriteLine(list1.ToString());
            Console.WriteLine();

            LinkedList list2 = new LinkedList();
            list2.Insert(4);
            list2.Insert(9);
            list2.Insert(5);
            Console.WriteLine("Second List:");
            Console.WriteLine(list2.ToString());
            Console.WriteLine();

            LinkedList list3 = new LinkedList();
            list3.ZipLists(list1, list2);
            Console.WriteLine("Zipped List:");
            Console.WriteLine(list3.ToString());
        }
    }
}
