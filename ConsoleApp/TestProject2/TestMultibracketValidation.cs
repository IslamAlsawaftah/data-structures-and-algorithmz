using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using static ConsoleApp.Program;

namespace TestProject2
{
    public class TestMultibracketValidation
    {
        [Fact]
        public void TestBrackets1()
        {
            string str = "{";
            Assert.False(ValidateBrackets(str));
        }
        [Fact]
        public void TestBrackets2()
        {
            string str = "[({}]";
            Assert.False(ValidateBrackets(str));
        }
        [Fact]
        public void TestBrackets3()
        {
            string str = "()[[Extra Characters]]";
            Assert.True(ValidateBrackets(str));
        }
        [Fact]
        public void TestBrackets4()
        {
            string str = "(){}[[]]";
            Assert.True(ValidateBrackets(str));
        }
    }
}
