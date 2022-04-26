using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using  ConsoleApp.Challenges.binary_tree_and_bst;

namespace TestProject2
{
    public class TestTree
    {
        BinaryTree tree = new BinaryTree();

        [Fact]
        public void Instantiate_Empty_Tree()
        {
            Assert.Null(tree.Root);
        }
        [Fact]
        public void Instantiate_Empty_Tree_with_Single_Root()
        {
            tree.Root = new NodeBT(15);
            Assert.NotNull(tree.Root);
        }
        [Fact]
        public void Test_Preorder_Traversal()
        {
            tree.Root = new NodeBT(1);
            tree.Root.Left = new NodeBT(2);
            tree.Root.Right = new NodeBT(3);
            tree.Root.Left.Left = new NodeBT(4);
            tree.Root.Left.Right = new NodeBT(5);
            int[] arr = { 1, 2, 4, 5, 3 };

            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }
            Assert.Equal(arr, tree.PreOrder(tree.Root));
        }
        [Fact]
        public void Test_Inorder_Traversal()
        {
            tree.Root = new NodeBT(1);
            tree.Root.Left = new NodeBT(2);
            tree.Root.Right = new NodeBT(3);
            tree.Root.Left.Left = new NodeBT(4);
            tree.Root.Left.Right = new NodeBT(5);
            int[] arr = { 4, 2, 5, 1, 3 };

            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }
            Assert.Equal(arr, tree.InOrder(tree.Root));
        }
        [Fact]
        public void Test_Postorder_Traversal()
        {
            tree.Root = new NodeBT(1);
            tree.Root.Left = new NodeBT(2);
            tree.Root.Right = new NodeBT(3);
            tree.Root.Left.Left = new NodeBT(4);
            tree.Root.Left.Right = new NodeBT(5);
            int[] arr = { 4, 5, 2, 3, 1 };

            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }
            Assert.Equal(arr, tree.PostOrder(tree.Root));
        }
        [Fact]
        public void Test_Binary_Search_Tree()
        {
            BinarySearchTree binarySearchTree = new BinarySearchTree();
            binarySearchTree.Add(10);
            binarySearchTree.Add(15);
            binarySearchTree.Add(35);
            binarySearchTree.Add(26);
            binarySearchTree.Add(47);
            int[] arr = { 10, 15, 35, 26, 47 };
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }
            Assert.Equal(arr, binarySearchTree.PreOrder(binarySearchTree.Root));
        }
        [Fact]
        public void Test_Binary_Search_Tree_Contains_True()
        {
            BinarySearchTree binarySearchTree = new BinarySearchTree();
            binarySearchTree.Add(10);
            binarySearchTree.Add(15);
            binarySearchTree.Add(35);
            Assert.True(binarySearchTree.Contains(10));
        }
        [Fact]
        public void Test_Binary_Search_Tree_Contains_False()
        {
            BinarySearchTree binarySearchTree = new BinarySearchTree();
            binarySearchTree.Add(10);
            binarySearchTree.Add(15);
            binarySearchTree.Add(35);
            Assert.False(binarySearchTree.Contains(20));
        }
        [Fact]
        public void Test_Add_ToLeft_BST()
        {
            BinarySearchTree binarySearchTree = new BinarySearchTree();
            binarySearchTree.Add(10);
            binarySearchTree.Add(5);
            Assert.NotNull(binarySearchTree.Root.Left);
            Assert.Null(binarySearchTree.Root.Right);
        }
        [Fact]
        public void Test_Add_ToRight_BST()
        {
            BinarySearchTree binarySearchTree = new BinarySearchTree();
            binarySearchTree.Add(10);
            binarySearchTree.Add(15);
            Assert.Null(binarySearchTree.Root.Left);
            Assert.NotNull(binarySearchTree.Root.Right);
        }
    }
    }