using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.Challenges.linkedlist
{
    public class LinkedList
    {
        Node head; // reference to head node 
        public LinkedList() // contructor to intialize head to null 
        {
            head = null;
        }
        public void Insert(int value)
        {
            try
            {
                Node node = new Node(value); // create new node 
                node.next = head; // we tell node to point what head currently is
                head = node; // tell head to point to our new node 
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        //public bool Includes(string value)
        //{
        //    // Function to Search the list.
        //    Node temp = head;

        //    // if the list is empty
        //    if (head.data == null)
        //    {
        //        Console.WriteLine("Nothing Found, List Is Empty");
        //    }
        //    else
        //    {
        //        while (temp != null)
        //        {
        //            if (temp.data == value)
        //            {
        //                Console.WriteLine(value + " is in the list!");
        //                return true;
        //            }
        //            temp = temp.next;
        //        }
        //    }
        //    Console.WriteLine(value + " not in the list. ");
        //    return false;
        //}
        public string ToString()
        {
            string str = "";
            // temp reference to the head node 
            if (head == null)
            {
                return "list is empty";
            }
            else  // loop through list 
            {
                Node temp = head;
                while (temp != null)
                {
                    // str = "["+temp.data+"]"+"->"; // print data
                    str += "[" + temp.data + "] -> ";
                    temp = temp.next;
                }
            }
            str += "null";
            return str;
        }
        public void Append(int value)
        {
            Node newNode = new Node(value); // create new node 
            newNode.next = null; // we set node that comes after appended node to be null
            if (head == null) // if we dont have nodes inside linked list:  head -> [5] -> X
            {
                head = newNode;
            }
            else // if we have nodes inside linked list: head -> [1] -> [3] -> [2] -> [5] -> X
            {
                Node temp = new Node(value);
                temp = head;
                while (temp.next != null)
                    temp = temp.next;
                temp.next = newNode;
            }
        }

        //public void InsertBefore(string value, string NewValue)
        //{
        //    Node current = head; // start from head 
        //    Node temp = new Node(NewValue);
        //    if (head.data == value)
        //    {
        //        temp.next = head;
        //        head = temp;
        //    }
        //    if (current.next.data != value)
        //    {
        //        Console.Write("value does'nt exist in list");
        //    }
        //    while (current.next != null)
        //    {
        //        if (current.next.data == value)
        //        {
        //            temp.next = current.next;
        //            current.next = temp;
        //            break;
        //        }
        //        current = current.next;    // move  to the next node
        //    }


        //}

        //public void InsertAfter(string value, string NewValue)
        //{
        //    Node temp = new Node(NewValue);
        //    Node current = head;
        //    if (current.data != value)
        //    {
        //        Console.Write("value does'nt exist in list");
        //    }
        //    while (current != null)
        //    {
        //        if (current.data == value)
        //        {
        //            temp.next = current.next;
        //            current.next = temp;
        //            break;
        //        }
        //        current = current.next;
        //    }
        //}
        /* Function to get the nth node from the last of a
  linked list */
        //public object kthFromEnd(int index)
        //{
        //    try
        //    {
        //        Node p = head, n = null;
        //        while (p != null)
        //        {
        //            Node tmp = p.next;
        //            p.next = n;
        //            n = p;
        //            p = tmp;
        //        }
        //        head = n;
        //        Node current = head;

        //        // Index of Node we are
        //        // currently looking at
        //        int count = 0;
        //        while (current != null)
        //        {
        //            if (count == index)
        //                return current.data;
        //            count++;
        //            current = current.next;
        //        }
        //        return current.data;
        //    } catch (Exception message)
        //    {
        //        return "Index out of range" + message;
        //    }
        //}
        public LinkedList ZipLists(LinkedList list1, LinkedList list2)
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
                    Append(value);
                    curr1 = curr1.next;
                }
                if (curr2 != null)
                {
                    value = curr2.data;
                    Append(value);
                    curr2 = curr2.next;
                }
            }
            return list3;
        }
    }
}
