using System;
using Xunit;
using ConsoleApp.Challenges.linkedlist;
namespace TestProject2
{
    public class UnitTest1
    {
        [Fact]
        public void TestEmpty()
        {
            // instantiate an empty linked list
            LinkedList list = new LinkedList();
            // can insert into the linked list
            list.Insert("a");
            //head property will point to the first node in the linked list
            Assert.Equal("[a] -> NULL", list.ToString());
        }
        [Fact]
        public void TestInsertMultiple()
        {
            LinkedList list = new LinkedList();
            //can insert multiple nodes into the linked list
            list.Insert("a");
            list.Insert("b");
            list.Insert("c");
            Assert.Equal("[c] -> [b] -> [a] -> NULL", list.ToString());
        }

        [Fact]
        public void TestFound()
        {
            LinkedList list = new LinkedList();

            list.Insert("a");
            list.Insert("b");
            list.Insert("c");
            //  return true when finding a value within the linked list that exists
            Assert.True(list.Includes("a"));
        }
        [Fact]
        public void TestNotFound()
        {
            LinkedList list = new LinkedList();

            list.Insert("a");
            list.Insert("b");
            list.Insert("c");
            //  return false when finding a value within the linked list that does not exists
            Assert.False(list.Includes("x"));
        }
        [Fact]
        public void TestPrint()
        {
            LinkedList list = new LinkedList();

            list.Insert("a");
            list.Insert("b");
            list.Insert("c");
            //return a collection of all the values that exist in the linked list
            Assert.Equal("[c] -> [b] -> [a] -> NULL", list.ToString());
        }
    }
}
