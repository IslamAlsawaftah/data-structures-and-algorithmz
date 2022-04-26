using System;
using System.Collections;
using System.Collections.Generic;

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
	}
}
