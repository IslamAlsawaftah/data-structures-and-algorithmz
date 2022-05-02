using ConsoleApp.Challenges.binary_tree_and_bst;
using ConsoleApp.Challenges.linkedlist;
using ConsoleApp.Challenges.stackqueuepseudo;
using ConsoleApp.Challenges.stacksandqueues;

using System;
using System.Collections.Generic;
//using System.Collections.Generic;

namespace ConsoleApp
{
    public class Program
    {

        static void Main(string[] args)
        {
            BinaryTree tree = new BinaryTree();
            tree.Root = new NodeBT(1);
            tree.Root.Left = new NodeBT(2);
            tree.Root.Right = new NodeBT(13);
            tree.Root.Left.Left = new NodeBT(4);
            tree.Root.Left.Right = new NodeBT(5);



            Console.WriteLine("Preorder traversal of binary tree is ");
            int[] arr = tree.PreOrder(tree.Root);

            for(int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }
            tree.list.Clear();
            Console.WriteLine();

            Console.WriteLine("Inorder traversal of binary tree is ");
            int[] arr2 = tree.InOrder(tree.Root);

            for (int i = 0; i < arr2.Length; i++)
            {
                Console.Write(arr2[i] + " ");
            }
            tree.list.Clear();
            Console.WriteLine();

            Console.WriteLine("Postorder traversal of binary tree is ");
            int[] arr3 = tree.PostOrder(tree.Root);

            for (int i = 0; i < arr3.Length; i++)
            {
                Console.Write(arr3[i] + " ");
            }
            Console.WriteLine();
          
            BinarySearchTree binarySearchTree = new BinarySearchTree();
            binarySearchTree.Add(10);
            binarySearchTree.Add(15);
            binarySearchTree.Add(35);
            binarySearchTree.Add(26);
            binarySearchTree.Add(47);

            int[] arr4 =  binarySearchTree.PreOrder(binarySearchTree.Root);
            Console.WriteLine("Binary Search Tree Values");
            for(int i = 0; i < arr4.Length; i++)
            {
                Console.Write(arr4[i] + " ");
            }
            Console.WriteLine();
            Console.WriteLine(binarySearchTree.Contains(0));

            Console.WriteLine("Maximum value in BT is " + tree.FindMax());

            List<int> result = tree.BreadthFirst(tree);
            Console.WriteLine("Breadth First Values");
            for (int i = 0; i < result.Count; i++)
            {
                Console.Write(result[i] + " ");
            }
            Console.WriteLine() ;


            Console.WriteLine("Fizz Buzz Tree!");
            NodeBT node1 = new NodeBT(50);
            NodeBT node2 = new NodeBT(15);
            NodeBT node3 = new NodeBT(5);
            NodeBT node4 = new NodeBT(18);
            NodeBT node5 = new NodeBT(10);
            NodeBT node6 = new NodeBT(14);
            BinaryTree fizzBuzz = new BinaryTree();
            fizzBuzz.Root = new NodeBT(12);
            fizzBuzz.Root.Left = node1;
            fizzBuzz.Root.Left.Left = node3;
            fizzBuzz.Root.Left.Right = node4;
            fizzBuzz.Root.Right = node2;
            fizzBuzz.Root.Right.Left = node5;
            fizzBuzz.Root.Right.Right = node6;
            fizzBuzz.FizzBuzzTree(fizzBuzz);
            Console.ReadLine();



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
            //Console.WriteLine("Peek is :" + q.Peek());
            q.Dequeue();
            //Console.WriteLine("Peek after Dequeue is :" + q.Peek());

            //Console.WriteLine(ValidateBrackets("()[[Extra Characters]]"));
            //Console.WriteLine(ValidateBrackets("{}(){}"));
            //Console.WriteLine(ValidateBrackets("[({}]"));
            //Console.WriteLine(ValidateBrackets("("));
            //Console.WriteLine(ValidateBrackets(null));

        }
        public static bool ValidateBrackets(string str)
        {
            if (str == null)
                return true;
            Stack stack = new Stack();
            for (int i = 0; i < str.Length; i++)
            {
                char current = str[i];
                if (current == '{' || current == '(' || current == '[')
                {
                    stack.push(current);
                }
                if (current == '}' || current == ')' || current == ']')
                {
                    if (stack.isEmpty())
                        return false;

                    char last = (char)stack.peek();
                    if (current == '}' && last == '{' || current == ')' && last == '(' || current == ']' && last == '[')
                        stack.pop();
                    else
                        return false;
                }
            }
            return stack.isEmpty();
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
