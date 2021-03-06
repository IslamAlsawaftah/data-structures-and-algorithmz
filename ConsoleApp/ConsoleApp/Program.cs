using ConsoleApp.Challenges.binary_tree_and_bst;
using ConsoleApp.Challenges.FizzBuzz_k_ary_tree;
using ConsoleApp.Challenges.insertion_sort;
using ConsoleApp.Challenges.sorting.merge;
using ConsoleApp.Challenges.linkedlist;
using ConsoleApp.Challenges.stackqueuepseudo;
using ConsoleApp.Challenges.stacksandqueues;

using System;
using System.Collections.Generic;
using ConsoleApp.Challenges.sorting.quick;
using ConsoleApp.Challenges.hashtable;
using ConsoleApp.Challenges.hashmap_repeated_word;
using ConsoleApp.Challenges.hashmap_left_join;
using ConsoleApp.Challenges.tree_intersection;
using ConsoleApp.Challenges.graph;
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

            //Console.WriteLine("Kary tree");

            //KaryTree karyTree = new KaryTree();

            //karyTree.Root = new NodeFB(15);

            //KaryTree tree1 = KaryTree.FizzBuzzTree(karyTree);
            //Console.WriteLine(tree1.Root.Value);

            // Insertion Sort
            Console.WriteLine("Array before Insertion Sort");
            int[] array = { 12, 11, 13, 5, 6 };
            for(int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + " ");
            }
            Console.WriteLine();
            Console.WriteLine("Array After Insertion Sort");
            InsertionSort sort = new InsertionSort();
            sort.Insertionsort(array);
            sort.PrintArray(array);



            int[] MyArray = { 8, 4, 23, 42, 16, 15};
            Console.Write("Array before Merge Sort\n");
            MergeSort merge = new MergeSort();
            merge.PrintArray(MyArray);

            merge.Mergesort(MyArray);
            Console.Write("\nArray After Merge Sort\n");
            merge.PrintArray(MyArray);

            int[] arrr = { 8, 4, 23, 42, 16, 15 };
            QuickSort quickSort = new QuickSort();
            Console.WriteLine("\nArray Before Quick Sort\n");
            quickSort.PrintArray(arrr);
            quickSort.Quicksort(arrr, 0, arrr.Length - 1);

            Console.WriteLine("\nArray After Quick Sort\n");
            quickSort.PrintArray(arrr);

            Console.WriteLine();

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

            HashmapRepeated g = new HashmapRepeated();
            Console.WriteLine("Repeated word: " + g.HashmapRepeatedWord("It was the best of times, it was the worst of times, it was the age of wisdom, it was the age of foolishness, it was the epoch of belief, it was the epoch of incredulity, it was the season of Light, it was the season of Darkness, it was the spring of hope, it was the winter of despair, we had everything before us, we had nothing before us, we were all going direct to Heaven, we were all going direct the other way – in short, the period was so far like the present period, that some of its noisiest authorities insisted on its being received, for good or for evil, in the superlative degree of comparison only"));
            Console.WriteLine("Repeated word: " + g.HashmapRepeatedWord("I didn’t know what I was doing in New York"));
            Console.WriteLine("Repeated word: " + g.HashmapRepeatedWord(""));
            Console.WriteLine("Repeated word: " + g.HashmapRepeatedWord("didn’t know what I was doing in New York"));


            Hashtable hashtable1 =new  Hashtable(5);
            hashtable1.Set("fond", "enamored");
            hashtable1.Set("wrath", "anger");
            hashtable1.Set("diligent", "employed");
            hashtable1.Set("outift", "garb");
            hashtable1.Set("guide", "usher");

            Hashtable hashtable2 = new Hashtable(5);
            hashtable2.Set("fond", "averse");
            hashtable2.Set("wrath", "delight");
            hashtable2.Set("diligent", "idle");
            hashtable2.Set("guide", "follow");
            hashtable2.Set("flow", "jam");

            HashmapLeftJoin leftJoin = new HashmapLeftJoin();
            List<string > keys = new List<string>();
            keys = leftJoin.LeftJoin(hashtable1, hashtable2);
            foreach (var item in keys)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();

            BinaryTree tree1 = new BinaryTree();
            tree1.Root = new NodeBT(1);
            tree1.Root.Left = new NodeBT(2);
            tree1.Root.Right = new NodeBT(13);
            tree1.Root.Left.Left = new NodeBT(4);
            tree1.Root.Left.Right = new NodeBT(5);

            BinaryTree tree2 = new BinaryTree();
            tree2.Root = new NodeBT(2);
            tree2.Root.Left = new NodeBT(23);
            tree2.Root.Right = new NodeBT(3);
            tree2.Root.Left.Left = new NodeBT(6);
            tree2.Root.Left.Right = new NodeBT(5);

            TreeIntersection tree_Intersection = new TreeIntersection();
            List<int> intersections = tree_Intersection.Tree_Intersection(tree1, tree2);

            Console.WriteLine("intersections are: ");
            foreach (int value in intersections)
            {
                Console.Write(value + " ");
            }

            Console.WriteLine();

            Graph gr = new Graph(true,true);
            int V = 5;
            List<int>[] adj = new List<int>[V];
            for (int i = 0; i < V; i++)
                adj[i] = new List<int>();
            //gr.AddNode(1);
            //gr.AddNode(2);
            //gr.AddNode(3);
            //gr.AddNode(4);
            // Adding edge as shown in the example figure
            //Vertex vertex = new Vertex(1);
            //Vertex vertex2 = new Vertex(2);
            //Vertex vertex3 = new Vertex(3);
            //Vertex vertex4 = new Vertex(4);
            //Vertex vertex5 = new Vertex(5);
            //Vertex vertex6 = new Vertex(6);

            //gr.AddEdge(vertex2, vertex6,7);
            //gr.AddEdge(vertex, vertex5,12);
            //gr.AddEdge(vertex4, vertex5, 2);
            //gr.AddEdge(vertex3, vertex2, 3);
            //List<Vertex> list = gr.BreadthFirst(vertex);
            //for (int i = 0; i < list.Count; i++)
            //{
            //    Console.WriteLine("breadth " + list[i].value);
            //}
            //Console.WriteLine("size is " + gr.Size());
            //gr.PrintGraph(adj,V);
            Graph graph = new Graph(true,true);
            //graph.AddNode("Pandora");
            //graph.AddNode("Arendelle");
            //graph.AddNode("Metroville");
            //graph.AddNode("Monstroplolis");
            //graph.AddNode("Narnia");
            //graph.AddNode("Naboo");
            Vertex vertex = new Vertex("Pandora");
            Vertex vertex2 = new Vertex("Arendelle");
            Vertex vertex3 = new Vertex("Metroville");
            Vertex vertex4 = new Vertex("Monstroplolis");
            Vertex vertex5 = new Vertex("Narnia");
            Vertex vertex6 = new Vertex("Naboo");
            graph.AddEdge(vertex, vertex2, 150);
            graph.AddEdge(vertex, vertex3, 99);
            graph.AddEdge(vertex2, vertex4, 42);
            graph.AddEdge(vertex3, vertex5, 37);
            graph.AddEdge(vertex3, vertex, 82);
            graph.AddEdge(vertex6, vertex4, 73);
            string[] arrays = { "Pandora", "Arendelle", "Metroville" };
            Console.WriteLine("result is " + graph.BusinessTrip(graph, arrays));
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
