using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp.Challenges.hashmap_repeated_word;
using Xunit;

namespace TestProject2
{
    public class TestHashmapRepeatedWord
    {
        HashmapRepeated hashmapRepeatedWord = new HashmapRepeated();
        [Fact]
        public void Test1()
        {
            string text = "";
            Assert.Equal("No text provided", hashmapRepeatedWord.HashmapRepeatedWord(text));
        }
        [Fact]
        public void Test2()
        {
            string text = "Once upon a time, there was brave princess who";
            Assert.Equal("No Repetetion", hashmapRepeatedWord.HashmapRepeatedWord(text));
        }
        [Fact]
        public void Test3()
        {
            string text = "It was the best of times, it was the worst of times, it was the age of wisdom, it was the age of foolishness, it was the epoch of belief, it was the epoch of incredulity, it was the season of Light, it was the season of Darkness, it was the spring of hope, it was the winter of despair, we had everything before us, we had nothing before us, we were all going direct to Heaven, we were all going direct the other way – in short, the period was so far like the present period, that some of its noisiest authorities insisted on its being received, for good or for evil, in the superlative degree of comparison only...";
            Assert.Equal("it", hashmapRepeatedWord.HashmapRepeatedWord(text));
        }
        [Fact]
        public void Test4()
        {
            string text = "It was a queer, sultry summer, the summer they electrocuted the Rosenbergs, and I didn’t know what I was doing in New York";
            Assert.Equal("was", hashmapRepeatedWord.HashmapRepeatedWord(text));
        }
        [Fact]
        public void Test5()
        {
            string text = "Once upon a time, there was a brave princess who...";
            Assert.Equal("a", hashmapRepeatedWord.HashmapRepeatedWord(text));
        }
    }
}
