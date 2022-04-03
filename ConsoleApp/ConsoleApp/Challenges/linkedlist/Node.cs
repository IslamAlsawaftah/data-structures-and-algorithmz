using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.Challenges.linkedlist
{
    public class Node
    {
        public string data; // data to be added to the list
        public Node next;    // pointer(reference) to next Node in list, next is type of Node class, Has a relation ship.
        public Node(string x) // constructor that take new data that i want to put in list
        {
            data = x;
            next = null;
        }
    }
}
