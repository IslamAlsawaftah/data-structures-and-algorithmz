using ConsoleApp.Challenges.linkedlist;
using System;

namespace ConsoleApp
{
    public class Program
    {
        static void Main(string[] args)
        {
            LinkedList linkedList = new LinkedList();
            linkedList.Insert("2");
            linkedList.Insert("3");
            linkedList.Insert("4");
            //linkedList.Append("5");
            //linkedList.InsertBefore("11", "6");
            linkedList.InsertAfter("4", "10");
            Console.Write(linkedList.ToString());
            Console.WriteLine();
            //linkedList.Includes("b");
        }
    }
}
