using ConsoleApp.Challenges.binary_tree_and_bst;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
namespace TestProject2
{
    public class TestFizzBuzz
    {
        [Fact]
        public void Test_Empty_FizzBuzz_Tree()
        {
            BinaryTree tree = new BinaryTree();
            Exception ex = Assert.Throws<Exception>(() => tree.FizzBuzzTree(tree));
            Assert.Equal("Tree is empty", ex.Message);

        }
        [Fact]
        public void Test_FizzBuzz()
        {
            NodeBT node1 = new NodeBT(50);
            NodeBT node2 = new NodeBT(15);
            NodeBT node3 = new NodeBT(5);
            NodeBT node4 = new NodeBT(18);
            NodeBT node5 = new NodeBT(10);
            NodeBT node6 = new NodeBT(14);
            BinaryTree fizzBuzz = new BinaryTree();
            fizzBuzz.Root = new NodeBT(12);
            fizzBuzz.Root.Left = node1;
            fizzBuzz.Root.Left.Left = node3;
            fizzBuzz.Root.Left.Right = node4;
            fizzBuzz.Root.Right = node2;
            fizzBuzz.Root.Right.Left = node5;
            fizzBuzz.Root.Right.Right = node6;
            List<string> expected = new List<string>() { "Fizz" }; 
            Assert.Equal(expected, fizzBuzz.Traverse(fizzBuzz.Root));
        }
        [Fact]
        public void Test_FizzBuzz1()
        {
            NodeBT node1 = new NodeBT(50);
            NodeBT node2 = new NodeBT(15);
            NodeBT node3 = new NodeBT(5);
            NodeBT node4 = new NodeBT(18);
            NodeBT node5 = new NodeBT(10);
            NodeBT node6 = new NodeBT(14);
            BinaryTree fizzBuzz = new BinaryTree();
            fizzBuzz.Root = new NodeBT(10);
            fizzBuzz.Root.Left = node1;
            fizzBuzz.Root.Left.Left = node3;
            fizzBuzz.Root.Left.Right = node4;
            fizzBuzz.Root.Right = node2;
            fizzBuzz.Root.Right.Left = node5;
            fizzBuzz.Root.Right.Right = node6;
            List<string> expected = new List<string>() { "Buzz" };
            Assert.Equal(expected, fizzBuzz.Traverse(fizzBuzz.Root));
        }
        [Fact]
        public void Test_FizzBuzz2()
        {
            NodeBT node1 = new NodeBT(50);
            NodeBT node2 = new NodeBT(15);
            NodeBT node3 = new NodeBT(5);
            NodeBT node4 = new NodeBT(18);
            NodeBT node5 = new NodeBT(10);
            NodeBT node6 = new NodeBT(14);
            BinaryTree fizzBuzz = new BinaryTree();
            fizzBuzz.Root = new NodeBT(15);
            fizzBuzz.Root.Left = node1;
            fizzBuzz.Root.Left.Left = node3;
            fizzBuzz.Root.Left.Right = node4;
            fizzBuzz.Root.Right = node2;
            fizzBuzz.Root.Right.Left = node5;
            fizzBuzz.Root.Right.Right = node6;
            List<string> expected = new List<string>() { "FizzBuzz" };
            Assert.Equal(expected, fizzBuzz.Traverse(fizzBuzz.Root));
        }
        [Fact]
        public void Test_FizzBuzz3()
        {
            NodeBT node1 = new NodeBT(50);
            NodeBT node2 = new NodeBT(15);
            NodeBT node3 = new NodeBT(5);
            NodeBT node4 = new NodeBT(18);
            NodeBT node5 = new NodeBT(10);
            NodeBT node6 = new NodeBT(14);
            BinaryTree fizzBuzz = new BinaryTree();
            fizzBuzz.Root = new NodeBT(14);
            fizzBuzz.Root.Left = node1;
            fizzBuzz.Root.Left.Left = node3;
            fizzBuzz.Root.Left.Right = node4;
            fizzBuzz.Root.Right = node2;
            fizzBuzz.Root.Right.Left = node5;
            fizzBuzz.Root.Right.Right = node6;
            List<string> expected = new List<string>() {"14"};
            Assert.Equal(expected, fizzBuzz.Traverse(fizzBuzz.Root));
        }
    }
}
