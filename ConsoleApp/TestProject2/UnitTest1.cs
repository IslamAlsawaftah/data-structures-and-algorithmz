using System;
using Xunit;
using ConsoleApp.Challenges.linkedlist;
namespace TestProject2
{
    public class UnitTest1
    {
        [Fact]
        public void TestAppend()
        {
            //instantiate an empty linked list
            LinkedList list = new LinkedList();
            // can append into the linked list
            list.Append("5");
            //Can successfully add a node to the end of the linked list
            Assert.Equal("head -> [5] -> X", list.ToString());
        }
        [Fact]
        public void TestAppendMultipleNode()
        {
            //instantiate an empty linked list
            LinkedList list = new LinkedList();
            // can append into the linked list
            list.Insert("2");
            list.Insert("3");
            list.Insert("1");
            list.Append("5");
            //Can successfully add multiple nodes to the end of a linked list
            Assert.Equal("head -> [1] -> [3] -> [2] -> [5] -> X", list.ToString());
        }
        [Fact]
        public void TestInsertBeforeMiddle()
        {
            //instantiate an empty linked list
            LinkedList list = new LinkedList();
            // can insert before middle the linked list
            list.Insert("3");
            list.Insert("5");
            list.Insert("2");
            list.Insert("1");
            list.Insert("4");
            list.InsertBefore("2", "10");
            //Can successfully add node begore middle of the linked list
            Assert.Equal("head -> [4] -> [1] -> [10] -> [2] -> [5] -> [3] -> X", list.ToString());
        }

        [Fact]
        public void TestInsertBeforeFirst()
        {
            //instantiate an empty linked list
            LinkedList list = new LinkedList();
            // can insert before first in the linked list
            list.Insert("2");
            list.Insert("3");
            list.Insert("4");
            list.InsertBefore("4", "10");
            //Can successfully insert a node before the first node of a linked list
            Assert.Equal("head -> [10] -> [4] -> [3] -> [2] -> X", list.ToString());
        }

        [Fact]
        public void TestInsertAfterMiddle()
        {
            //instantiate an empty linked list
            LinkedList list = new LinkedList();
            // can insert after middle the linked list
            list.Insert("3");
            list.Insert("5");
            list.Insert("2");
            list.Insert("1");
            list.Insert("4");
            list.InsertAfter("2", "10");
            //Can successfully insert after a node in the middle of the linked list
            Assert.Equal("head -> [4] -> [1] -> [2] -> [10] -> [5] -> [3] -> X", list.ToString());
        }

        [Fact]
        public void TestInsertAfterLast()
        {
            //instantiate an empty linked list
            LinkedList list = new LinkedList();
            // can append into the linked list
            list.Insert("3");
            list.Insert("2");
            list.Insert("1");
            list.InsertAfter("3", "10");
            //Can successfully insert a node after the last node of the linked list
            Assert.Equal("head -> [1] -> [2] -> [3] -> [10] -> X", list.ToString());
        }
    }
}
