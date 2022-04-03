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
        public void Insert(string value)
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
        public bool Includes(string value)
        {
            // Function to Search the list.
            Node temp = head;

            // if the list is empty
            if (head.data == null)
            {
                Console.WriteLine("Nothing Found, List Is Empty");
            }
            else
            {
                while (temp != null)
                {
                    if (temp.data == value)
                    {
                        Console.WriteLine(value + " is in the list!");
                        return true;
                    }
                    temp = temp.next;
                }
            }
            Console.WriteLine(value + " not in the list. ");
            return false;
        }
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
            str += "NULL";
            return str;
        }
    }
}
