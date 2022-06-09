using ConsoleApp.Challenges.hashtable;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace TestProject2
{
    public class TestHashtable
    {
        Hashtable hashtable = new Hashtable(1024);
        // Setting a key/value to your hashtable results in the value being in the data structure
        [Fact]
        public void Test1()
        {
            hashtable.Set(1, "one");

            Assert.Equal("one", hashtable.Get(1).value);
        }
        // Retrieving based on a key returns the value stored
        [Fact]
        public void Test2()
        {
            hashtable.Set(1, "one");
            Assert.Equal("one", hashtable.Get(1).value);
        }
        // Successfully returns null for a key that does not exist in the hashtable
        [Fact]
        public void Test3()
        {
            hashtable.Set(2, "two");
            Assert.Null(hashtable.Get(1));
        }
        //Successfully returns a list of all unique keys that exist in the hashtable
        [Fact]
        public void Test4()
        {
            hashtable.Set(1, "one");
            hashtable.Set(2, "two");
            hashtable.Set(3, "three");

            List<int> expected = new List<int>() {1,2,3};
            Assert.Equal(expected,hashtable.Keys());
        }
        // Successfully handle a collision within the hashtable
        [Fact]
        public void Test5()
        {

            hashtable.Set(1, "one");
            hashtable.Set(2, "two");

            int val1 = hashtable.Hash(1);
            int val2 = hashtable.Hash(2);

            Assert.Equal(val1, val2);
        }
        // Successfully hash a key to an in-range value
        [Fact]
        public void Test6()
        {
            int val = hashtable.Hash(1);
            Assert.InRange(val,0,hashtable.size);
        }
        [Fact]
        public void Test7()
        {
            hashtable.Set(1, "one");
            bool res = hashtable.Contains(1);
            Assert.True(res);
        }
    }
}
