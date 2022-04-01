using System;
using System.Collections.Generic;
namespace BigO_workspace
{
    class MyQueuesUsingStack
    {
        private Stack<object> stack = new Stack<object>();
        private Stack<object> auxiliaryStack = new Stack<object>();

        public object peek()
        {
            fillAuxiliaryStackWithStack(); // 80
            object value = auxiliaryStack.Peek(); // 80
            fillStackWithAuxiliaryStack();
            return value;
        }

        public void peek2()
        {
            fillAuxiliaryStackWithStack(); // 80
            //object value = auxiliaryStack.Peek(); // 80
            Console.WriteLine(auxiliaryStack.Peek());
            fillStackWithAuxiliaryStack(); //  puts back the 80 in the original stack
        }

        public void enqueue(object value)
        {
            this.stack.Push(value);
        }

        public object dequeue()
        {
            fillAuxiliaryStackWithStack();
            object value = auxiliaryStack.Pop();
            fillStackWithAuxiliaryStack();
            return value;
        }

        public void printQueue()
        {
            if (stack.Count == 0)
            {
                return;
            }
            // gets all the elements of the orig stack to the auxiliary stack
            fillAuxiliaryStackWithStack();
            foreach (var i in auxiliaryStack)
            {
                Console.Write("-->" + i);
            }
            Console.WriteLine();
            fillStackWithAuxiliaryStack();
        }


        private void fillAuxiliaryStackWithStack()
        {
            while(stack.Count > 0)
            {
                // making the auxiliary stack as queue of stack
                auxiliaryStack.Push(stack.Pop());
            }
        }

        private void fillStackWithAuxiliaryStack()
        {
            while(auxiliaryStack.Count > 0)
            {
                // return stack to the original state
                stack.Push(auxiliaryStack.Pop());
            }
        }
    }
}
