using ConsoleApp.Challenges.binary_tree_and_bst;
using ConsoleApp.Challenges.hashtable;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.Challenges.tree_intersection
{
    public class TreeIntersection
    {
        public List<int> Tree_Intersection(BinaryTree binaryTree1, BinaryTree binaryTree2)
        {
            if (binaryTree1.Root == null || binaryTree2.Root == null)  throw new Exception ("Tree is empty"); ;

            List<int> result = new List<int>();
            Hashtable hashtable = new Hashtable(10);

            int[]  tree1Values = binaryTree1.PreOrder(binaryTree1.Root);
            int[]  tree2Values = binaryTree2.PreOrder(binaryTree2.Root);

            foreach (int value in tree1Values)
            {
                // create node and add it to hash table
                NodeBT node = new NodeBT(value);
                hashtable.Set(node.Value.ToString(), node.Value.ToString());
            }
            foreach (int value in tree2Values)
            {
                if (hashtable.Contains(value.ToString()))
                {
                    result.Add(value);
                }
            }
            return result;
        }
    }
}
