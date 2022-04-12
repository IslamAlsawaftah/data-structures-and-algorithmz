using ConsoleApp;
using ConsoleApp.Challenges.stackqueuepseudo;
using ConsoleApp.Challenges.stacksandqueues;
using System;

using Xunit;
namespace TestProject2
{
    public class Teststackandqueuepseudo
    {
        PseudoQueue queue = new PseudoQueue();
        [Fact]
        public void TestEmpty()
        {
            Assert.Throws<Exception>(() => queue.Peek());
        }
        [Fact]
        public void TestEequeue()
        {
            queue.Enqueue(5);
            queue.Enqueue(10);
            queue.Enqueue(15);
            queue.Enqueue(20);

            Assert.Equal(5, queue.Peek());
        }
        [Fact]
        public void TestDequeue()
        {
            queue.Enqueue(5);
            queue.Enqueue(10);
            queue.Enqueue(15);
            queue.Enqueue(20);
            queue.Dequeue();

            Assert.Equal(10, queue.Peek());
        }
    }
}
