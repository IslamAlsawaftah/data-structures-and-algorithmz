using ConsoleApp.Challenges.linkedlist;
using ConsoleApp.Challenges.stackqueuepseudo;
using ConsoleApp.Challenges.stacksandqueues;

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

            //Console.WriteLine("First List:");
            //Console.WriteLine(list1.ToString());
            Console.WriteLine();

            LinkedList list2 = new LinkedList();
            list2.Insert(4);
            list2.Insert(9);
            list2.Insert(5);
            //Console.WriteLine("Second List:");
            //Console.WriteLine(list2.ToString());
            Console.WriteLine();

            //Console.WriteLine("Zipped List:");
            //LinkedList result = ZipLists(list1, list2);
            //Console.Write(result.ToString());

            Stack stack = new Stack();
            stack.push(3);
            stack.push(2);
            stack.push(1);
            //Console.WriteLine(stack.ToString());

            Queue queue = new Queue();
            queue.enqueue(1);
            queue.enqueue(2);
            queue.enqueue(3);   
            //Console.WriteLine(queue.ToString());

            PseudoQueue q = new PseudoQueue();
            q.Enqueue(1);
            q.Enqueue(2);
            q.Enqueue(3);
            Console.WriteLine("Peek is :" + q.Peek());
            q.Dequeue();
            Console.WriteLine("Peek after Dequeue is :" + q.Peek());

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
