using System;
using System.Collections;

namespace BigO_workspace
{
    public class StackVsQueues
    {
        // creating stacks using library
        public static void HowToUseStack()
        {
            // usin stack class
            Stack my_stack = new Stack();
            // addng elements
            my_stack.Push("geeks");
            my_stack.Push("geeksforgeeks");
            my_stack.Push('G');
            my_stack.Push(null);
            my_stack.Push(1234);
            my_stack.Push(490.98);

            Console.Write("{ ");
            foreach (var i in my_stack)
            {
                Console.Write($" {i}, ");
            }
            Console.Write(" } ");

            Console.WriteLine("Total elements present in " +
                      "my_stack: {0}\n", my_stack.Count);

            // in a stack the pop method remooves the first element always
            my_stack.Pop();
            Console.WriteLine("Pop opration commenced...");

            Console.Write("{ ");
            foreach (var i in my_stack)
            {
                Console.Write($" {i}, ");
            }
            Console.Write(" } ");
            Console.WriteLine("Total elements present in " +
                      "my_stack: {0}", my_stack.Count);

            Console.WriteLine("\nIs \"geeks\" element in the stack?");
            // Checking if the element is
            // present in the Stack or not
            if (my_stack.Contains("geeks") == true)
            {
                Console.WriteLine("Element is found...!!");
            }

            else
            {
                Console.WriteLine("Element is not found...!!");
            }

            // Remove all the elements
            // from the stack
            //my_stack.Clear();
        }

        public static void HowToUseQueues()
        {
            // creating a queue
            Queue myQueue = new Queue();

            // Inserting elements into a queue
            myQueue.Enqueue("one");

            // Displaying the count of elements
            // contained in the Queue
            Console.Write("Total number of elements in the Queue are : ");
            Console.WriteLine(myQueue.Count);         

            // Inserting the elements into the Queue
            myQueue.Enqueue("Chandigarh");
            myQueue.Enqueue("Delhi");
            myQueue.Enqueue(5);
            myQueue.Enqueue(10);

            Console.Write("Total number of elements in the Queue are : ");
            Console.WriteLine(myQueue.Count);            

            // Checking whether the element is
            // present in the Queue or not
            // The function returns True if the
            // element is present in the Queue, else
            // returns False
            Console.WriteLine(myQueue.Contains(7));

            // removes the first element in a queue
            myQueue.Dequeue();

            Console.Write("Total number of elements in the Queue are : ");
            Console.WriteLine(myQueue.Count);

            //object[] myArray = { "one", 2 };

            // Converting the Queue
            // into object array
            Object[] arr = myQueue.ToArray();

            // Displaying the elements in array
            foreach (Object obj in arr)
            {
                Console.WriteLine(obj);
            }
        }
    }
}
