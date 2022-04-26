using System;
namespace ConsoleApp.Challenges.binary_tree_and_bst
{
    public class NodeBT
    {
        public int Value;
        public NodeBT Left, Right;

        public NodeBT(int y)
        {
            Value = y;

            Right = Left = null;
        }
    }
}