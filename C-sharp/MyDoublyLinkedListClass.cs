using System;
namespace BigO_workspace
{
    // DOUBLY LINKED LIST
    public class DoublyLinkedListNode
    {
        public object value
        {
            get;
            set;
        }

        // when this is used, the node class will be called again        
        public DoublyLinkedListNode next
        {
            get;
            set;
        }

        // added for double linked list
        public DoublyLinkedListNode previous
        {
            get;
            set;
        }

        // this is the function the node class uses when it is called
        public DoublyLinkedListNode(object value)
        {
            this.value = value;
            this.next = null;
            this.previous = null;
        }
    }

    public class MyDoublyLinkedListClass
    {
        public DoublyLinkedListNode head;
        public DoublyLinkedListNode tail;
        public int length;

        public MyDoublyLinkedListClass(object value)
        {
            this.head = new DoublyLinkedListNode(value);
            this.tail = this.head;
            this.length = 1;
        }

        public void append(object value)
        {
            DoublyLinkedListNode newNode = new DoublyLinkedListNode(value);
            newNode.previous = this.tail;
            this.tail.next = newNode;
            this.tail = newNode;
            this.length++;
        }

        public void prepend(object value)
        {
            DoublyLinkedListNode newNode = new DoublyLinkedListNode(value);
            newNode.next = this.head;
            this.head.previous = newNode;
            this.head = newNode;
            this.length++;
        }

        public void insert(int index, object value)
        {
            //index = wrapIndex(index);
            //Console.WriteLine(index);
            if (index == 0)
            {
                prepend(value);
                return;
            }
            if (index > this.length - 1)
            {
                Console.WriteLine($"index out of bounds, value put at index {this.length}");
                append(value);
                return;
            }
            DoublyLinkedListNode newNode = new DoublyLinkedListNode(value);
            DoublyLinkedListNode leader = traverseToIndex(index - 1);
            DoublyLinkedListNode follower = leader.next;
            leader.next = newNode;
            newNode.previous = leader;
            newNode.next = follower;
            follower.previous = newNode;
            this.length++;

        }

        public void remove(int index)
        {
            //index = wrapIndex(index);
            if (index == 0)
            {
                head = head.next;
                return;
            }

            DoublyLinkedListNode leader = traverseToIndex(index - 1);
            DoublyLinkedListNode nodeToRemove = leader.next;
            leader.next = nodeToRemove.next;
            nodeToRemove.next.previous = leader;
            this.length--;

        }


        public void printList()
        {
            if (this.head == null)
            {
                return;
            }
            DoublyLinkedListNode current = this.head;
            while (current != null)
            {
                Console.Write("--> " + current.value);
                current = current.next;
            }
            Console.WriteLine("");
        }

        public void getLength()
        {
            Console.WriteLine(length);
        }

        public void getHead()
        {
            Console.WriteLine(this.head.value);
        }

        public void getTail()
        {
            Console.WriteLine(this.tail.value);
        }

        public int wrapIndex(int index)
        {
            return Math.Max(Math.Min(index, this.length - 1), 0);
        }

        private DoublyLinkedListNode traverseToIndex(int index)
        {
            int count = 0;
            index = wrapIndex(index);
            DoublyLinkedListNode currentNode = head;
            while (count != index)
            {
                currentNode = currentNode.next;
                count++;
            }
            return currentNode;
        }
    }
}
