using ConsoleApp.Challenges.binary_tree_and_bst;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.Challenges.FizzBuzz_k_ary_tree
{
    public class KaryTree
    {
		public NodeFB Root;
        public KaryTree()
        {
            Root = null;
			// try to access a member—for instance,
		   // a method or a property—on a variable that currently holds a null reference. 
		}
		public static KaryTree FizzBuzzTree(KaryTree tree)
		{
			if(tree == null)
            {
				return null;
            }
			KaryTree karyTree = new KaryTree();
			CheckFizzBuzz(tree.Root,karyTree.Root);
			return karyTree;
		}
		public static void CheckFizzBuzz(NodeFB node, NodeFB node2)
		{
			if (node == null)
			{
				return;
			}
			if (Int32.TryParse(node.Value.ToString(), out int value))
			{
				if (value % 5 == 0 && value % 3 == 0)
				{
					node2.Value = "FizzBuzz";
				}
				else if (value % 5 == 0)
				{
					node2.Value = "Buzz";
				}
				else if (value % 3 == 0)
				{
					node2.Value = "Fizz";
				}
				else
				{
					node2.Value = node.Value.ToString();
					//node2.Value = $"{node2.Value}";
				}
                for (int i = 0; i < node.Children.Count; i++)
                {
					node2.AddChild(node.Children[i].Value);
					CheckFizzBuzz(node.Children[i],node2.Children[i]);
                }
			}
		}
	}
}
