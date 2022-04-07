using ConsoleApp.Challenges.linkedlist;

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

            Console.WriteLine("Zipped List:");
            LinkedList result = ZipLists(list1, list2);
            Console.Write(result.ToString());

        }
         public static LinkedList ZipLists(LinkedList list1, LinkedList list2)
        {
            LinkedList list3 = new LinkedList();
            Node curr1 = list1.head;
            Node curr2 = list2.head;
            int value;
            while (curr1 != null || curr2 != null)
            {
                if (curr1 != null)
                {
                    value = curr1.data;
                   list3.Append(value);
                    curr1 = curr1.next;
                }
                if (curr2 != null)
                {
                    value = curr2.data;
                   list3.Append(value);
                    curr2 = curr2.next;
                }
            }
            return list3;
        }
    }
}
