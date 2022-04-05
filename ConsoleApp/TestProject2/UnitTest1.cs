using System;
using Xunit;
using ConsoleApp.Challenges.linkedlist;
namespace TestProject2
{
    public class UnitTest1
    {
        [Fact]
        public void TestkGreaterThanList()
        {
            LinkedList linkedList = new LinkedList();
            linkedList.Insert(2);
            linkedList.Insert(8);
            linkedList.Insert(3);
            linkedList.Insert(1);
            //  k is greater than the length of the linked list
            Assert.Equal("Index out of range", linkedList.kthFromEnd(11));
        }
        [Fact]
        public void TestkEqualList()
        {
            LinkedList linkedList = new LinkedList();
            linkedList.Insert(2);
            linkedList.Insert(8);
            linkedList.Insert(3);
            linkedList.Insert(1);
            //  k is greater than the length of the linked list
            Assert.Equal(0, linkedList.kthFromEnd(4));
        }
        [Fact]
        public void TestkNegative()
        {
            LinkedList linkedList = new LinkedList();
            linkedList.Insert(2);
            linkedList.Insert(8);
            linkedList.Insert(3);
            linkedList.Insert(1);
            //  k is not a positive integer
            Assert.Equal(0, linkedList.kthFromEnd(-1));

        }
        [Fact]
        public void TestLinkedListSizeOne()
        {
            LinkedList linkedList = new LinkedList();

            linkedList.Insert(3);
            //   linked list is of a size 1
            Assert.Equal(3, linkedList.kthFromEnd(0));
        }
        [Fact]
        public void TestkNotAtTheEnd()
        {
            LinkedList linkedList = new LinkedList();
            linkedList.Insert(2);
            linkedList.Insert(8);
            linkedList.Insert(14);
            linkedList.Insert(3);
            linkedList.Insert(1);
            //  k is in the middle of the linked list
            Assert.Equal(14, linkedList.kthFromEnd(2));
        }
    }
}
