using ConsoleApp.Challenges.binary_tree_and_bst;
using ConsoleApp.Challenges.FizzBuzz_k_ary_tree;
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
        public void Test_FizzBuzz()
        {
            KaryTree tree = new KaryTree();
            tree.Root = new NodeFB(1);
            KaryTree fizzbuzz = KaryTree.FizzBuzzTree(tree);
            Assert.Equal("1", fizzbuzz.Root.Value);
            Assert.Equal(1, tree.Root.Value);

        }
        [Fact]
        public void Test_FizzBuzz2()
        {
            KaryTree tree = new KaryTree();
            tree.Root = new NodeFB(15);
            tree.Root.AddChild(15); // first child index 0
            KaryTree fizzbuzz = KaryTree.FizzBuzzTree(tree); // call it with class name because it static
            Assert.Equal("FizzBuzz", fizzbuzz.Root.Children[0].Value);
        }
        [Fact]
        public void Test_FizzBuzz3()
        {
            KaryTree tree = new KaryTree();
            tree.Root = new NodeFB(10);
            KaryTree fizzbuzz = KaryTree.FizzBuzzTree(tree);
            Assert.Equal("Buzz", fizzbuzz.Root.Value);
        }
        [Fact]
        public void Test_FizzBuzz4()
        {
            KaryTree tree = new KaryTree();
            tree.Root = new NodeFB(21);
            KaryTree fizzbuzz = KaryTree.FizzBuzzTree(tree);
            Assert.Equal("Fizz", fizzbuzz.Root.Value);
        }
    }
}
