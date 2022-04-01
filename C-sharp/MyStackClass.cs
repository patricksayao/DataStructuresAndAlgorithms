using System;
namespace BigO_workspace
{
    // properties of Stacknode object
    class StackNode
    {
        public object value
        {
            get;
            set;
        }

        public StackNode next
        {
            get;
            set;
        }

        public StackNode(object value)
        {
            this.value = value;
            this.next = null;
        }
    }

    // properties of MyStackClass object
    class MyStackClass
    {
        public StackNode top;
        public StackNode bottom;
        public int length;

        public MyStackClass()
        {
            this.top = null;
            this.bottom = null;
            this.length = 0;
        }

        public object peek()
        {
            if (this.length > 0)
            {
                return this.top.value;
            }
            return -100000;
        }

        public void push(object value)
        {
            StackNode newNode = new StackNode(value);
            if (length == 0)
            {
                this.top = newNode;
                this.bottom = newNode;
            }
            else
            {
                StackNode holdingPointer = this.top;
                this.top = newNode;
                this.top.next = holdingPointer; 
            }
            this.length++;
        }

        public object pop()
        {
            if (this.length == 0)
            {
                return -10000;
            }
            StackNode holdingPointer = this.top;
            this.top = this.top.next;
            this.length--;
            return holdingPointer.value;
        }

        public void printStack()
        {
            if (this.length == 0)
            {
                return;
            }
            StackNode currentNode = top;
            Console.Write(currentNode.value);
            currentNode = currentNode.next;
            while (currentNode != null)
            {
                Console.Write($"-->{currentNode.value} ");
                currentNode = currentNode.next;
            }
            Console.WriteLine("");
        }
    }


}
