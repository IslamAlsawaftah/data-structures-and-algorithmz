using ConsoleApp.Challenges.linkedlist;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.Challenges.stacksandqueues
{
    public class Stack
    {
        public Node top { get; set; } // top property
        public Stack()
        {
            top = null;
        }
        public void push(int value)
        {
            Node node = new Node(value);
            node.next = top;
            top = node;
        }
        public int pop()
        {
            if (top == null)
            {
                throw new Exception("Stack is empty!");

            }
            Node temp = top;
            top = top.next;
            temp.next = null;
            return temp.data;
        }
        public int peek()
        {
            if (top == null)
            {
                throw new Exception("Stack is empty!");

            }
            return top.data;
        }
        public bool isEmpty()
        {
            return top == null;
        }
        public string ToString()
        {
            string str = "";
            if (top == null)
            {
                return "Stack is empty";
            }
            else 
            {
                Node temp = top;
                while (temp != null)
                {
                    str += "[" + temp.data + "] -> ";
                    temp = temp.next;
                }
            }
            str += "null";
            return str;
        }
    }
    }
