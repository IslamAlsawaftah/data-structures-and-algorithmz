using ConsoleApp.Challenges.binary_tree_and_bst;
using ConsoleApp.Challenges.tree_intersection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace TestProject2
{
    public class TestTreeIntersection
    {
        [Fact]
        public void Test1()
        {

            BinaryTree tree = new BinaryTree();
            tree.Root = new NodeBT(1);
            tree.Root.Left = new NodeBT(2);
            tree.Root.Right = new NodeBT(13);
            tree.Root.Left.Left = new NodeBT(4);
            tree.Root.Left.Right = new NodeBT(5);

            BinaryTree tree2 = new BinaryTree();
            tree2.Root = new NodeBT(11);
            tree2.Root.Left = new NodeBT(23);
            tree2.Root.Right = new NodeBT(3);
            tree2.Root.Left.Left = new NodeBT(6);
            tree2.Root.Left.Right = new NodeBT(5);

            TreeIntersection tree_Intersection = new TreeIntersection();
            List<int> intersections = tree_Intersection.Tree_Intersection(tree, tree2);
            List<int> expected = new List<int>() {5};
            Assert.Equal(expected, intersections);
        }
        [Fact]
        public void Test2()
        {

            BinaryTree tree = new BinaryTree();
            tree.Root = new NodeBT(1);
            tree.Root.Left = new NodeBT(2);
            tree.Root.Right = new NodeBT(13);
            tree.Root.Left.Left = new NodeBT(4);
            tree.Root.Left.Right = new NodeBT(5);

            BinaryTree tree2 = new BinaryTree();
            tree2.Root = new NodeBT(11);
            tree2.Root.Left = new NodeBT(23);
            tree2.Root.Right = new NodeBT(3);
            tree2.Root.Left.Left = new NodeBT(6);
            tree2.Root.Left.Right = new NodeBT(5);

            TreeIntersection tree_Intersection = new TreeIntersection();
            List<int> intersections = tree_Intersection.Tree_Intersection(tree, tree2);
            List<int> expected = new List<int>() { 5,23 };
            Assert.NotEqual(expected, intersections);
        }
        [Fact]
        public void Test3()
        {

            BinaryTree tree = new BinaryTree();
            BinaryTree tree2 = new BinaryTree();
            tree.Root = null;
            tree2.Root = new NodeBT(11);
            TreeIntersection tree_Intersection = new TreeIntersection();
            Exception ex = Assert.Throws<Exception>(() => tree_Intersection.Tree_Intersection(tree, tree2));
            Assert.Equal("Tree is empty", ex.Message);

        }
    }
}
