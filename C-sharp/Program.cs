using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Threading;
using System.Linq;


// Feb 18 2022
// description - program to practice runtimes


namespace BigO_workspace
{

    // this is an object
    public class UserTable
    {
        public int age = 50;
        public string name = "Patrick";
        public bool magic = true;
        public void scream()
        {
            Console.WriteLine("AAAAHHHHH!");
        }
    }

    class MainClass
    {
        // sample of a function
        public static void FindNemo(string[] arr)
        {
            // how to measure runtime
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine("searching...");
                if (arr[i] == "nemo")
                {                    
                    Console.WriteLine("nemo has been found.");
                    break; // breaks out of the loop if nemo has already been found                 
                }
            }
            stopwatch.Stop();
            TimeSpan ts = stopwatch.Elapsed;
            Console.WriteLine("Elapsed Time is {0} ms", stopwatch.ElapsedMilliseconds);
            Console.WriteLine("Elapsed RunTime in TimeStamp is {0:00}:{1:00}:{2:00}.{3}",
                    ts.Hours, ts.Minutes, ts.Seconds, ts.Milliseconds);
        }

        // sample of basic recursion function
        public static int countRecursion = 0;
        public static object myRecursionHere()
        {
            Console.Write(countRecursion + "... ");
            // base case------------------------//
            if (countRecursion > 3)             //
            {                                   //
                return "done";                  //
            }                                   //
            //----------------------------------//
            countRecursion++;
            // recursive case-------------------//
            return myRecursionHere();           //
            //----------------------------------//
        }


        // for DFS--------------------------------------
        public static void PrintList(List<int> list)
        {
            foreach (var item in list)
            {
                Console.Write(item.ToString() + " ");
            }
            Console.WriteLine();
        }
        //----------------------------------------------


        public static void Main(string[] args)
        {
            //int count = 0;
            int[] items = new int[10];
            int[] items2 = { 1, 2, 3, 4, 5 };
            string[] arrStrings = { "A", "B", "C", "D", "E" };
            string[] arrStrings2 = { "F", "G", "H", "D", "I", "X" };
            string[] arr = { "bruce", "marlin", "hank", "darla", "nemo", "squirt", "bloat", "dory", "nigel" };

            object[] arrObj = { "Hello", "World", 10, null, false, 19 };

            //string str = "Hello";

            string[] arr2 = new string[10000]; // creates a string sized array of 1000 elements
            for (int i = 0; i < 1000; i++) // adds the string "nemo" to the array each loop
            {
                arr2[i] = "nemo";
            }

            int[] arrayOne = { 0, 3, 4};
            int[] arrayTwo = { 4, 6, 30, 1 };

            int[] arrayThree = { 2, 5, 1, 8, 3, 5, 1, 2, 4 };

            List<int> listArr = new List<int>();
            listArr.Add(6);
            listArr.Add(9);
            listArr.Add(4);
            listArr.Add(2);
            listArr.Add(10);

            List<int> listArr2 = new List<int>();
            listArr2.Add(8);
            listArr2.Add(5);
            listArr2.Add(2);
            listArr2.Add(6);

            List<int> listArr3 = new List<int>();
            listArr3.Add(9);
            listArr3.Add(3);
            listArr3.Add(1);
            listArr3.Add(4);
            listArr3.Add(0);
            listArr3.Add(7);

            List<int> listArr4 = new List<int>();
            listArr4.Add(4);
            listArr4.Add(6);
            listArr4.Add(3);
            listArr4.Add(1);
            listArr4.Add(8);
            listArr4.Add(5);
            listArr4.Add(9);

            var listArr5 = new List<int>()
            {
                99, 44, 6, 2, 1, 5, 63, 87, 283, 4, 0
            };

            int[] arr1A = { 4, 6, 3};
            int[] arr1B = { 1, 8, 5, 9 };

            int[] arr1C = { 4, 6, 3, 1, 8, 5, 9 };

            //2d dimentional array
            int[,] arr2D = { { 1, 2 }, { 3, 4 } };

            //3d dimentional array
            int[,,] arr3D = { { { 1, 2 }, { 3, 30 } }, { { 4, 5 }, { 6, 60 } } };

            try
            {
                //foreach (object i in arrObj)
                //{
                //    Console.WriteLine(i);
                //}

                //for (int i = 0; i < arrObj.Length; i++)
                //{
                //    Console.WriteLine(arrObj[i]);
                //}

                //FindNemo(arr); // it takes O(n) "Linear Time" to find nemo
                //Console.WriteLine($"{arr[0]}"); // it takes 0(1) "Constant Time" to find the first element

                //EmptyClass.PrintFirstItemTenHalfThenSayHi100Times(items);

                //EmptyClass.ArrayPairs(arrStrings);

                //EmptyClass.SumOfElements(items2);

                //var pairedItem = EmptyClassTwo.CommonArrayItem(arrStrings, arrStrings2);
                //Console.WriteLine(pairedItem); // O(n*m) TC / O(1) SC

                //var pairedItem2 = EmptyClassTwo.CommonArrayItem2(arrStrings, arrStrings2);
                //Console.WriteLine(pairedItem2); // O(n+m) TC / O(n) SC

                //Console.WriteLine(EmptyClassTwo.CommonItemPair3(arrStrings, arrStrings2)); // O(n) TC / O(1) SC

                //Console.WriteLine(EmptyClassThree.FunctionOne());

                //EmptyClassThree.FunctionOne();


                // Array exercises---------
                //Console.WriteLine(MyArray.ReverseString2(str));
                //--------------------------------

                // MergeSort exercises---------
                //MergedSort.MergeSortedArrays(arrayOne, arrayTwo);
                //MergedSort.MergeSortedArrays2(arrayOne, arrayTwo);
                //--------------------------------

                // Hashtables exercise-----------
                //UserTable user1 = new UserTable();
                //user1.scream();
                //UserHashTables user2 = new UserHashTables();
                //user2.scream();

                //MyHashTable h = new MyHashTable(2);
                //h.set("grapes", 1000);
                //h.set("apples", 54);
                ////Console.WriteLine(h.get("apples"));                
                ////h.keys();
                //for (int i = 0; i < h.length; i++)
                //{
                //    Console.WriteLine(h.keys()[i]);
                //    //Console.WriteLine(h.keys()[i] + ": " + h.get(h.keys()[i]));
                //    Console.WriteLine(h.get(h.keys()[i]));
                //}

                //AnotherHashTable.RecurringNumber(arrayThree);
                //--------------------------------


                // Linked List-------------------
                //LinkedListClassV2.FunctionOne();

                //MyLinkedListConstructor h = new MyLinkedListConstructor(10);              
                //Console.WriteLine(h);

                //MySinglyLinkedListClass l = new MySinglyLinkedListClass(10);
                //l.append(5);
                //l.append("gg");
                //l.prepend(1);
                //l.insert(2, "kilo");
                //l.insert(20, 7);
                //l.remove(2);
                //l.reverse();
                //l.printList();

                //LinkedListClassV2.FunctionLinkedList();

                //LinkedListClassV2.FunctionLinkedList2(arr);

                //MyDoublyLinkedListClass k = new MyDoublyLinkedListClass("Jake");
                //k.append("mark");
                //k.prepend(70);
                //Console.Write("elements of the list: "); k.printList();
                //Console.Write("the length is: "); k.getLength();                
                //Console.Write("the head is: "); k.getHead();
                //Console.Write("the tail is: "); k.getTail();
                //Console.WriteLine($"Inserting element at designated index ");
                //k.insert(2, "mason");
                //Console.Write("elements of the list: "); k.printList();
                //Console.WriteLine($"Removing element at designated index ");
                //k.remove(2);
                //Console.Write("elements of the list: "); k.printList();


                //---------------------------------------------

                // Stacks and Queues-------------------------
                //StackVsQueues.HowToUseStack();

                //MyStackClass myStack = new MyStackClass();
                //Console.WriteLine(myStack.peek());
                //myStack.push(20);
                //myStack.push("melon");
                //myStack.push(null);
                //myStack.push(16);
                //myStack.push("100");
                //myStack.printStack();
                //Console.WriteLine("The first element of the stack: " + myStack.peek());
                //Console.WriteLine("Pop peration commenced... \nremoved element is: " + myStack.pop());
                //Console.WriteLine("The first element of the stack: " + myStack.peek());
                //myStack.printStack();

                //StackVsQueues.HowToUseQueues();

                //MyQueueClass y = new MyQueueClass();
                ////Console.WriteLine(y.peek());
                //y.enqueue(30);
                //y.enqueue("Hello");
                //y.enqueue("yellow");
                //y.enqueue(true);
                //y.enqueue(5);
                //Console.WriteLine("the first element of the queue is: " + y.peek());
                //Console.WriteLine("dequeue commencing... \nelement " + y.dequeue() + " is removed");
                //y.printQueue();

                //MyQueuesUsingStack p = new MyQueuesUsingStack();
                //p.enqueue(80);
                //p.enqueue("hello");
                ////p.peek();

                //p.printQueue();
                //p.dequeue();
                //p.printQueue();

                //-----------------------------------

                // BinarySearchTree------------------

                //MyBinarySearchTree d = new MyBinarySearchTree();
                //d.insert(9);
                //d.insert(4);
                //d.insert(6);
                //d.insert(20);
                //d.insert(170);
                //d.insert(15);
                //d.insert(1);

                //d.printTree(d.root);
                //-----------------------------------

                // Graphs----------------------------
                //MyGraph d = new MyGraph();
                //d.addVertex(10);
                //d.addVertex(15);
                //d.addEdges(10, 15);
                //d.showConnections();
                //-----------------------------------

                // Recursions------------------------
                //Console.WriteLine(myRecursionHere());

                //long longNum = MyRecursion.FindFactorialIterative(50);
                //long longNum2 = MyRecursion.FindFactorialRecursive(6);
                //Console.WriteLine(longNum2);

                //int intNum = MyRecursion.FibonnaciIterative(6);                
                //Console.WriteLine($"{intNum} is the sum of the last sequence");
                //int intNum2 = MyRecursion.FibonnaciRecursive(6);
                //Console.WriteLine(intNum2);
                //string myStr = MyRecursion.ReverseStringIteratively("mark");
                //Console.WriteLine(myStr);
                //string myStr2 = MyRecursion.ReverseStringRecursive("mark");
                //Console.WriteLine(myStr2);
                //-----------------------------------

                // Sorting----------------------------
                //List<int> k = MySortingAlgo.myBubbleSort(listArr);
                //foreach (var i in k)
                //{
                //    Console.WriteLine(i);
                //}

                //foreach (var item in MySortingAlgo.mySelectionSort(listArr2))
                //{
                //    Console.WriteLine(item);
                //}

                //foreach (var item in MySortingAlgo.myInsertionSort(listArr3))
                //{
                //    Console.Write(item + " ");
                //}

                //MySortingAlgo.myMergeSort(listArr4);
                //Console.Write("\n");
                //foreach (var item in MySortingAlgo.myMergeSort(listArr4))
                //{
                //    Console.Write(item + " ");
                //}

                //MergedSort.MergeSortedArrays(arr1A, arr1B);
                //MergedSort.MergeSortedArrays2(arr1A, arr1B);

                //foreach (var item in MySortingAlgo.mergeSort(arr1C))
                //{
                //    Console.WriteLine(item);
                //}

                //------------------------------------

                // Search algo-----------------------------
                //int d = BinarySearch.myBinarySearch(listArr5, 677);
                //Console.WriteLine($"{d}");

                //MyBinarySearchTree d = new MyBinarySearchTree();
                //d.insert(9);
                //d.insert(4);
                //d.insert(6);
                //d.insert(20);
                //d.insert(170);
                //d.insert(15);
                //d.insert(1);

                // BFS------
                //var result = MyBinarySearchTree.BreadthFirstSearchIteratively(d.root);
                //foreach (var item in result)
                //{
                //    Console.Write(item.ToString() + " ");
                //}
                //Console.WriteLine();

                //Recurcive call
                //List<int> list = new List<int>();
                //Queue<BSTNode> queue = new Queue<BSTNode>();
                //queue.Enqueue(d.root);
                //var result2 = MyBinarySearchTree.BreadthFirstSearchRecursively(queue, list);
                //foreach (var item in result2)
                //{
                //    Console.Write(item.ToString() + " ");
                //}
                //Console.WriteLine();


                // DFS------
                //var InOrder = d.DFSInOrder();
                //PrintList(InOrder);
                //var PreOrder = d.DFSPreOrder();
                //PrintList(PreOrder);
                //var PostOrder = d.DFSPostOrder();
                //PrintList(PostOrder);

                //-----------------------------------------

                // Dynamic programming---------------------
                Console.WriteLine("1:" + MyDynamicProgramming.Memoization(12));
                Console.WriteLine("2:" + MyDynamicProgramming.Memoization(12));

                //var p1 = MyDynamicProgramming.Measure(() => MyDynamicProgramming.square(2));        // 00:00:00.0001388
                //var p2 = MyDynamicProgramming.Measure(() => MyDynamicProgramming.slowSquare(2));    // 00:00:00.1006509
                //Console.WriteLine(p1);
                //Console.WriteLine(p2);


            }
            catch (Exception ex)
            {
                Console.WriteLine("error: " + ex.Message + "\n");
                Console.WriteLine(ex.StackTrace);
            }

            
        }
    }
}
