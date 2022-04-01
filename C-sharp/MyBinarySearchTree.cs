using System;
using System.Collections.Generic;

namespace BigO_workspace
{
    class BSTNode
    {
        public int value
        {
            get;
            set;
        }
        public BSTNode left
        {
            get;
            set;
        }
        public BSTNode right
        {
            get;
            set;
        }

        public BSTNode(int value)
        {
            this.value = value;
            this.left = null;
            this.right = null;
        }
    }

    class MyBinarySearchTree
    {
        public BSTNode root;

        public MyBinarySearchTree()
        {
            this.root = null;
        }

        public void insert(int value)
        {
            BSTNode newNode = new BSTNode(value);
            if (this.root == null)
            {
                this.root = newNode;
                return;
            }

            BSTNode currentNode = new BSTNode(value);
            while (true)
            {
                if (currentNode.value > value)
                {
                    if (currentNode.left == null)
                    {
                        currentNode.left = new BSTNode(value);
                        return;
                    }
                    currentNode = currentNode.left;
                }
                else
                {
                    if (currentNode.right == null)
                    {
                        currentNode.right = new BSTNode(value);
                        return;
                    }
                    currentNode = currentNode.right;
                }
            }
        }

        public BSTNode lookup(int value)
        {
            if (root == null)
            {
                return null;
            }
            BSTNode currentNode = this.root;
            while (currentNode != null)
            {
                if (value < currentNode.value)
                {
                    currentNode = currentNode.left;
                }
                else if (value > currentNode.value)
                {
                    currentNode = currentNode.right;
                }
                else
                {
                    return currentNode;
                }
            }
            return null;
        }

        int COUNT = 5;
        public void printTree(BSTNode node)
        {
            print2DUtil(root, 0);
        }

        private void print2DUtil(BSTNode root, int space)
        {
            // base case
            if (root == null)
            {
                return;
            }
            // increase distance between levels
            space += COUNT;

            // process the right child first
            print2DUtil(root.right, space);

            // print current node after space
            // count
            Console.Write("\n");
            for (int i = COUNT; i < space; i++)
            {
                Console.Write(" ");
            }
            Console.Write(root.value + "\n");
            // process left child
            print2DUtil(root.left, space);
        }

        // not yet reviewed------------------------------------
        public void remove(int value)
        {
            if (root == null)
            {
                return;
            }

            BSTNode nodeToRemove = root;
            BSTNode parentNode = null;
            while (nodeToRemove.value != value)
            { //Searching for the node to remove and it's parent
                parentNode = nodeToRemove;
                if (value < nodeToRemove.value)
                {
                    nodeToRemove = nodeToRemove.left;
                }
                else if (value > nodeToRemove.value)
                {
                    nodeToRemove = nodeToRemove.right;
                }
            }

            BSTNode replacementNode = null;
            if (nodeToRemove.right != null)
            { //We have a right node
                replacementNode = nodeToRemove.right;
                if (replacementNode.left == null)
                { //We don't have a left node
                    replacementNode.left = nodeToRemove.left;
                }
                else
                { //We have a have a left node, lets find the leftmost
                    BSTNode replacementParentNode = nodeToRemove;
                    while (replacementNode.left != null)
                    {
                        replacementParentNode = replacementNode;
                        replacementNode = replacementNode.left;
                    }
                    replacementParentNode.left = null;
                    replacementNode.left = nodeToRemove.left;
                    replacementNode.right = nodeToRemove.right;
                }
            }
            else if (nodeToRemove.left != null)
            {//We only have a left node
                replacementNode = nodeToRemove.left;
            }

            if (parentNode == null)
            {
                root = replacementNode;
            }
            else if (parentNode.left == nodeToRemove)
            { //We are a left child
                parentNode.left = replacementNode;
            }
            else
            { //We are a right child
                parentNode.right = replacementNode;
            }
        }
        //-----------------------------------------------

        // Breadth First Search--------------------------
        // iteratively-----------------------------------
        public static List<int> BreadthFirstSearchIteratively(BSTNode currentNode)
        {
            List<int> list = new List<int>();
            Queue<BSTNode> queue = new Queue<BSTNode>();
            queue.Enqueue(currentNode);

            while (queue.Count > 0)
            {
                currentNode = queue.Dequeue();
                list.Add(currentNode.value);
                if (currentNode.left != null)
                {
                    queue.Enqueue(currentNode.left);
                }

                if (currentNode.right != null)
                {
                    queue.Enqueue(currentNode.right);
                }
            }
            return list;
        }
        //-----------------------------------------------

        // Breadth First Search--------------------------
        // recursively-----------------------------------
        public static List<int> BreadthFirstSearchRecursively(Queue<BSTNode> queue, List<int> list)
        {
            if (queue.Count == 0)
            {
                return list;
            }
            var currentNode = queue.Dequeue();
            list.Add(currentNode.value);
            if (currentNode.left != null)
            {
                queue.Enqueue(currentNode.left);
            }
            if (currentNode.right != null)
            {
                queue.Enqueue(currentNode.right);
            }
            return BreadthFirstSearchRecursively(queue, list);
        }
        //-----------------------------------------------

        // Depth First Search----------------------------
        public List<int> DFSInOrder()
        {
            List<int> result = new List<int>();
            traverseInOrder(this.root, result);
            return result;
        }

        public List<int> traverseInOrder(BSTNode node, List<int> list)
        {
            if (node.left != null)
            {
                traverseInOrder(node.left, list);
            }
            list.Add(node.value);
            if (node.right != null)
            {
                traverseInOrder(node.right, list);
            }

            return list;
        }

        public List<int> DFSPreOrder()
        {
            List<int> result = new List<int>();
            traversePreOrder(this.root, result);
            return result;
        }

        public List<int> traversePreOrder(BSTNode node, List<int> list)
        {
            list.Add(node.value);
            if (node.left != null)
            {
                traversePreOrder(node.left, list);
            }

            if (node.right != null)
            {
                traversePreOrder(node.right, list);
            }

            return list;
        }

        public List<int> DFSPostOrder()
        {
            List<int> result = new List<int>();
            traversePostOrder(this.root, result);
            return result;
        }

        public List<int> traversePostOrder(BSTNode node, List<int> list)
        {
            if (node.left != null)
            {
                traversePostOrder(node.left, list);
            }

            if (node.right != null)
            {
                traversePostOrder(node.right, list);
            }
            list.Add(node.value);

            return list;
        }

        
    }
}
