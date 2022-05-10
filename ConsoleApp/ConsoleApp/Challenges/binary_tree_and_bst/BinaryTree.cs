using ConsoleApp.Challenges.FizzBuzz_k_ary_tree;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp.Challenges.binary_tree_and_bst
{

	public class BinaryTree
	{
		// Root of Binary Tree
		public NodeBT Root;
		public List<int> list = new List<int>();


		public BinaryTree()
		{
			// Set initial tree root
			Root = null;
		}

		public int[] PreOrder(NodeBT Root)
		{
			if (Root == null)
			{
				throw new Exception("Tree is empty");
			}
			list.Add(Root.Value);

			if (Root.Left != null)
			{
				PreOrder(Root.Left);

			}
			if (Root.Right != null)
			{
				PreOrder(Root.Right);
			}
			return list.ToArray();
		}
		public int[] InOrder(NodeBT Root)
		{

			if (Root == null)
			{
				throw new Exception("Tree is empty");
			}
			if (Root.Left != null)
			{
				InOrder(Root.Left);
			}
			list.Add(Root.Value);
			
			if (Root.Right != null)
			{
				InOrder(Root.Right);
			}
			return list.ToArray();
		}
		public int[] PostOrder(NodeBT Root)
		{

			if (Root == null)
			{
				throw new Exception("Tree is empty");
			}
			if (Root.Left != null)
			{
				PostOrder(Root.Left);
			}
			if (Root.Right != null)
			{
				PostOrder(Root.Right);
			}
			list.Add(Root.Value);
			return list.ToArray();
		}
		public int FindMax()
		{
			if(Root == null)
            {
				throw new Exception("Tree is empty");
            }

			var result = Root.Value;
			var q = new Queue();
			// Add first node of tree
			q.Enqueue(Root);

			while (q.Count !=0)
			{
				NodeBT node = (NodeBT)q.Peek(); // Get new head

				if (node.Left != null)
				{
					// Add left child value
					q.Enqueue(node.Left);
				}
				if (node.Right != null)
				{
					// Add right child value
					q.Enqueue(node.Right);
				}
				// Check that node value is greater than or not
				if (node.Value > result)
				{
					result = node.Value;
				}
				// Remove element of queue
				q.Dequeue();
			}
			return result;
		}
		public List<int> BreadthFirst(BinaryTree tree)
        {
			if (Root == null)
			{
				throw new Exception("Tree is empty");
			}
			Queue<NodeBT> q = new Queue<NodeBT>();
			List<int> result = new List<int>();
			q.Enqueue(tree.Root);
			while (q.Count > 0)
			{
				NodeBT Front = q.Peek();
				result.Add(Front.Value);
				q.Dequeue();
				if (Front == null)
                {
					continue;
				}
				if (Front.Left != null)
                {
					q.Enqueue(Front.Left);
				}
				if (Front.Right != null)
				{
					q.Enqueue(Front.Right);
				}
			}
			return result;
		}

	}
}
