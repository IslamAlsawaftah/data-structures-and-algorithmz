using ConsoleApp;
using ConsoleApp.Challenges.stacksandqueues;
using System;

using Xunit;
namespace TestProject2
{
    public class Teststackandqueue
    {
        Stack stack = new Stack();
        Queue queue = new Queue();
        [Fact]
        public void Push_To_Stack()
        {
            stack.push(3);
            Assert.Equal(3, stack.top.data);
        }
        [Fact]
        public void Push_Multiple_To_Stack()
        {
            stack.push(3);
            stack.push(2);
            stack.push(1);
            Assert.Equal("[1] -> [2] -> [3] -> null", stack.ToString());
        }
        [Fact]
        public void Pop_Off_The_Stack()
        {
            stack.push(3);
            Assert.Equal(3, stack.pop());
        }
        [Fact]
        public void Empty_Stack_After_Multiple_Pops()
        {
            stack.push(3);
            stack.push(2);
            stack.pop();
            stack.pop();
            Assert.True(stack.isEmpty());
        }
        [Fact]
        public void Peek_Next_Item_On_stack()
        {
            stack.push(1);
            stack.push(2);
            Assert.Equal(2, stack.peek());

        }
        [Fact]
        public void Instantiate_Empty_Stack()
        {
            Assert.True(stack.isEmpty());
        }
        [Fact]
        public void Pop_Empty_Stack_Exception()
        {
            Assert.Throws<Exception>(() => stack.pop());
        }
        [Fact]
        public void Peek_Empty_Stack_Exception()
        {
            Assert.Throws<Exception>(() => stack.peek());
        }
        [Fact]
        public void Enqueue_Into_Queue()
        {
            queue.enqueue(1);
            Assert.Equal(1, queue.front.data);
        }
        [Fact]
        public void Enqueue_Multiple_Values_To_Queue()
        {
            queue.enqueue(1);
            queue.enqueue(2);
            queue.enqueue(3);
            Assert.Equal("[1] -> [2] -> [3] -> null", queue.ToString());
        }
        [Fact]
        public void Test_Dequeue()
        {
            queue.enqueue(2);
            queue.enqueue(1);
            Assert.Equal(2, queue.dequeue());
        }
        [Fact]
        public void Peek_Into_Queue()
        {
            queue.enqueue(3);
            Assert.Equal(3, queue.peek());
        }
        [Fact]
        public void Empty_Queue_After_Multiple_Dequeues()
        {
            queue.enqueue(2);
            queue.enqueue(1);
            queue.dequeue();
            queue.dequeue();
            Assert.True(queue.isEmpty());
        }
        [Fact]
        public void Instantiate_Empty_Queue()
        {
            Assert.True(queue.isEmpty());
        }
        [Fact]
        public void Pop_Empty_Queue_Exception()
        {
            Assert.Throws<Exception>(() => queue.dequeue());
        }
        [Fact]
        public void Peek_Empty_Queue_Exception()
        {
            Assert.Throws<Exception>(() => queue.peek());
        }
    }
}
