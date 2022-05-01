using ConsoleApp.Challenges.binary_tree_and_bst;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
namespace TestProject2
{
    public class TestBreadthFirst
    {
        BinaryTree tree = new BinaryTree();
        [Fact]
        public void Breadth_First()
        {
            tree.Root = new NodeBT(2);
            tree.Root.Left = new NodeBT(7);
            tree.Root.Right = new NodeBT(5);
            tree.Root.Left.Left = new NodeBT(2);
            tree.Root.Left.Right = new NodeBT(6);
            tree.Root.Left.Right.Left = new NodeBT(5);
            tree.Root.Left.Right.Right = new NodeBT(11);
            tree.Root.Right.Right = new NodeBT(9);
            tree.Root.Right.Right.Left = new NodeBT(4);


            List<int> list = new List<int>() { 2, 7, 5, 2, 6, 9, 5, 11, 4 };

            Assert.Equal(list, tree.BreadthFirst(tree));
        }
        [Fact]
        public void Test_Max_Binary_Tree3()
        {
            BinaryTree tree = new BinaryTree();
            Exception ex = Assert.Throws<Exception>(() => tree.BreadthFirst(tree));
            Assert.Equal("Tree is empty", ex.Message);

        }
    }
}
