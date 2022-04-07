using ConsoleApp.Challenges.linkedlist;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.Challenges.stacksandqueues
{
    public class Queue
    {
        public Node front { get; set; } // top property
        public Node rear { get; set; } // top property

        public Queue()
        {
            front = null;
        }
        public void enqueue(int value)
        {
            Node node = new Node(value);
            if(front == null)
            {
                front=node;
                rear=node;
            }
            rear.next = node;
            rear = node;
        }
        public int dequeue()
        {
            if (front == null)
            {
                throw new Exception("Queue is empty!"); // raise exception when called on empty stack

            }
            Node temp = front;
            front = front.next;
            temp.next = null;
            return temp.data;
        }
        public int peek()
        {
            if (front == null)
            {
                throw new Exception("Queue is empty!"); // raise exception when called on empty stack

            }
            return front.data;
        }
        public bool isEmpty()
        {
            return front == null;
        }
        public string ToString()
        {
            string str = "";
            // temp reference to the head node 
            if (front == null)
            {
                return "Queue is empty";
            }
            else  // loop through list 
            {
                Node temp = front;
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
    }
}