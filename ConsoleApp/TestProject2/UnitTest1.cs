using ConsoleApp;
using ConsoleApp.Challenges.linkedlist;
using System;

using Xunit;
namespace TestProject2
{
    public class UnitTest1
    {
        [Fact]
        public void TestZipped1()
        {
            LinkedList list = new LinkedList();
            list.Insert(2);
            list.Insert(3);
            list.Insert(1);

            LinkedList list1 = new LinkedList();
            list1.Insert(4);
            list1.Insert(9);
            list1.Insert(5);

            LinkedList list2 = new LinkedList();
            var result = Program.ZipLists(list, list1);
            Assert.Equal("[1] -> [5] -> [3] -> [9] -> [2] -> [4] -> null", result.ToString());
        }
        [Fact]
        public void TestZipped2()
        {
            LinkedList list = new LinkedList();
            list.Insert(3);
            list.Insert(1);

            LinkedList list1 = new LinkedList();
            list1.Insert(4);
            list1.Insert(9);
            list1.Insert(5);

            LinkedList list2 = new LinkedList();
            var result = Program.ZipLists(list, list1);
            Assert.Equal("[1] -> [5] -> [3] -> [9] -> [4] -> null", result.ToString());
        }
        [Fact]
        public void TestZipped3()
        {
            LinkedList list = new LinkedList();
            list.Insert(2);
            list.Insert(3);
            list.Insert(1);

            LinkedList list1 = new LinkedList();
            list1.Insert(9);
            list1.Insert(5);

            LinkedList list2 = new LinkedList();
            var result = Program.ZipLists(list, list1);
            Assert.Equal("[1] -> [5] -> [3] -> [9] -> [2] -> null", result.ToString());
        }
    }
}
