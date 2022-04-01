using System;
namespace BigO_workspace
{
    class QueueNode
    {
        public object value
        {
            get;
            set;
        }

        public QueueNode next
        {
            get;
            set;
        }

        public QueueNode(object value)
        {
            this.value = value;
            this.next = null;
        }
    }

    class MyQueueClass
    {
        public QueueNode first;
        public QueueNode last;
        public int length;

        public MyQueueClass()
        {
            this.first = null;
            this.last = null;
            this.length = 0;
        }

        public object peek()
        {
            if (this.length > 0)
            {
                return this.first.value;
            }
            return null;
        }

        public void enqueue(object value)
        {
            QueueNode newNode = new QueueNode(value);
            if (this.length == 0)
            {
                this.first = newNode;
                this.last = newNode;
            }
            else
            {
                this.last.next = newNode;
                this.last = newNode;
            }
            this.length++;
        }

        public object dequeue()
        {
            if (this.length == null)
            {
                return -100000;
            }
            if (this.length == 0)
            {
                return null;
            }
            QueueNode holdingPointer = this.first;
            this.first = this.first.next;

            this.length--;
            return holdingPointer.value;
        }

        public void printQueue()
        {
            if (this.first == null)
            {
                return;
                //Console.WriteLine("None");
            }
            QueueNode currentNode = first;
            Console.Write(currentNode.value);
            currentNode = currentNode.next;
            while (currentNode != null)
            {
                Console.Write("--> " + currentNode.value);
                currentNode = currentNode.next;
            }
            Console.WriteLine("");
        }
    }
}
