using ConsoleApp.Challenges.binary_tree_and_bst;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
namespace TestProject2
{
    public class TestMaxBinaryTree
    {
        [Fact]
        public void Test_Max_Binary_Tree()
        {
            BinaryTree tree = new BinaryTree();
            tree.Root = new NodeBT(1);
            tree.Root.Left = new NodeBT(2);
            tree.Root.Right = new NodeBT(13);
            tree.Root.Left.Left = new NodeBT(4);
            tree.Root.Left.Right = new NodeBT(5);
            Assert.Equal(13,tree.FindMax());
        }
        [Fact]
        public void Test_Max_Binary_Tree2()
        {
            BinaryTree tree = new BinaryTree();
            tree.Root = new NodeBT(1);
            tree.Root.Left = new NodeBT(2);
            tree.Root.Right = new NodeBT(13);
            tree.Root.Left.Left = new NodeBT(4);
            tree.Root.Left.Right = new NodeBT(5);
            Assert.NotEqual(5, tree.FindMax());
        }
        [Fact]
        public void Test_Max_Binary_Tree3()
        {
            BinaryTree tree = new BinaryTree();
            Exception ex = Assert.Throws<Exception>(() => tree.FindMax());
            Assert.Equal("Tree is empty", ex.Message);

        }
    }
}
