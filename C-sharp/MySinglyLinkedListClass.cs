using System;
namespace BigO_workspace
{
    // SINGLY LINKED LIST
    public class SinglyLinkedListNode
    {
        public object value
        {
            get;
            set;
        }

        // when this is used, the node class will be called again        
        public SinglyLinkedListNode next
        {
            get;
            set;
        }

        // this is the function the node class uses when it is called
        public SinglyLinkedListNode(object value)
        {
            this.value = value;
            this.next = null;

        }
    }

    public class MySinglyLinkedListClass
    {
        private SinglyLinkedListNode head;
        private SinglyLinkedListNode tail;
        public int length;

        // produces a linkedlist data structure
        public MySinglyLinkedListClass(object value)
        {
            this.head = new SinglyLinkedListNode(value);
            this.tail = this.head;
            this.length = 1;
        }

        // adds a node at the end
        public void append(object value)
        {
            SinglyLinkedListNode newNode = new SinglyLinkedListNode(value);
            this.tail.next = newNode;            
            this.tail = newNode;
            this.length++;
        }

        // adds a node at the start
        public void prepend(object value)
        {
            SinglyLinkedListNode newNode = new SinglyLinkedListNode(value);
            newNode.next = this.head;
            this.head = newNode;
            this.length++;
        }

        public void insert(int index, object value)
        {
            index = wrapIndex(index);
            if (index == 0)
            {
                prepend(value);
                return;
            }
            if (index ==  this.length - 1)
            {
                append(value);
                return;
            }
            SinglyLinkedListNode newNode = new SinglyLinkedListNode(value);

            // Singly linked list--------------------
            SinglyLinkedListNode leader = traverseToIndex(index - 1);
            SinglyLinkedListNode holdingPointer = leader.next;
            leader.next = newNode;
            newNode.next = holdingPointer;
            //---------------------------------------

            this.length++;
        }

        public void remove(int index)
        {
            index = wrapIndex(index);
            if (index == 0)
            {
                head = head.next;
                return;
            }

            SinglyLinkedListNode leader = traverseToIndex(index - 1);
            SinglyLinkedListNode nodeToRemove = leader.next;
            leader.next = nodeToRemove.next;
            this.length--;
        }

        public void reverse()
        {
            SinglyLinkedListNode first = head;
            tail = head;
            SinglyLinkedListNode second = first.next;
            for (int i = 0; i < length - 1; i++)
            {
                SinglyLinkedListNode temp = second.next;
                second.next = first;
                first = second;
                second = temp;
            }
            head.next = null;
            head = first;
        }


        // function to see the linkedlist
        public void printList()
        {
            if (this.head == null)
            {
                return;
            }
            SinglyLinkedListNode current = this.head;
            while (this.head != null)
            {
                Console.Write("-->" + this.head.value);
                this.head = this.head.next;
            }
            Console.WriteLine();
        }

        public int getLength()
        {
            return this.length;
        }

        public SinglyLinkedListNode getHead()
        {
            return this.head;
        }

        public SinglyLinkedListNode getTail()
        {
            return this.tail;
        }

        // this gives you.. an integer of the same number of index?
        private int wrapIndex(int index)
        {
            return Math.Max(Math.Min(index, this.length - 1), 0);
        }

        private SinglyLinkedListNode traverseToIndex(int index)
        {
            int counter = 0;
            index = wrapIndex(index);
            SinglyLinkedListNode currentNode = head;
            while (counter != index)
            {
                currentNode = currentNode.next;
                counter++;
            }
            return currentNode;
        }

    }
}
