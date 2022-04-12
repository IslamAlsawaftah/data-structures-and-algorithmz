using ConsoleApp.Challenges.stacksandqueues;
using System.Collections.Generic;
using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.Challenges.stackqueuepseudo
{
    public class PseudoQueue
    {

        Stack stack1 = new Stack();
        Stack stack2 = new Stack();
        public void Enqueue(int x)
        {
            // Move all elements from stack1 to stack2

            while (stack1.isEmpty() == false)
            {
                stack2.push(stack1.pop());
            }

            // Push item into stack1
            stack1.push(x);

            // Push everything back to stack1
            while (stack2.isEmpty() == false)
            {
                stack1.push(stack2.pop());
            }
        }
        // Dequeue an item from the queue
        public object Dequeue()
        {
            // if first stack is empty
            if (stack1.isEmpty() == true)
            {
                return "Q is Empty";

            }

            return  stack1.pop();
        }
        public object Peek()
        {
            return stack1.peek();
        }

    }
}
