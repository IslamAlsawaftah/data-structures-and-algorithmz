using ConsoleApp.Challenges.linkedlist;
using System.Collections.Generic;
using System;

namespace ConsoleApp
{
    public class Program
    {
        static void Main(string[] args)
        {
              LinkedList linkedList = new LinkedList();
                linkedList.Insert(2);
                linkedList.Insert(8);
                linkedList.Insert(11);
                linkedList.Insert(3);
                Console.WriteLine(linkedList.ToString()); 
                Console.WriteLine();
                Console.Write(linkedList.kthFromEnd(0));
                Console.WriteLine(); 
           
        }
    }
}
