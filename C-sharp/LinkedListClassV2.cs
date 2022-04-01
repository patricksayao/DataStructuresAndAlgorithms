using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace BigO_workspace
{
    public class LinkedListClassV2
    {
        // pointer example
        public static unsafe void FunctionOne()
        {
            //type* variable_name;
            //Where * is known as the de - reference operator. For example the following statement
            //int* x;
            //Declares a pointer variable x, which can hold the address of an int type. The reference operator (&) can be used to get the memory address of a variable.
            int x = 40;
            // The &x gives the memory address of the variable x, which we can assign to a pointer variable 
            int* x2 = &x;
            x = 30; // if we change the value of x, it would certainly do so with x2 since it is oly a pointer to the value of x

            Console.WriteLine($"The memory address: {(int)x2}"); // Displays the memory address  
            Console.WriteLine($"the value at the memory address: {*x2}"); // Displays the value at the memory address.               
        }

        // how to use a linked list
        public static void FunctionLinkedList()
        {
            // Creating a linkedlist
            // Using LinkedList class
            LinkedList<string> my_List = new LinkedList<string>();

            // append
            my_List.AddLast("Patrick");
            // prepend
            my_List.AddFirst("Trisha");
            // insert
            my_List.AddBefore(my_List.AddLast("Patrick"), "Lars");
            // removes the first node
            my_List.Remove(my_List.First);

            foreach (string str in my_List)
            {
                Console.WriteLine(str);
            }
        }

        public static void FunctionLinkedList2(string[] arr)
        {
            LinkedList<string> myList = new LinkedList<string>(arr);
            //foreach (string i in myList)
            //{
            //    Console.WriteLine(i);
            //}

            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(myList.ElementAt(i));
            }
            //myList.AddBefore(myList.ElementAt(2), "PP");
            myList.AddBefore(myList.AddFirst("Trisha"), "PP");


            //Console.WriteLine();
        }
        
    }

    // constructor example
    //public class MyLinkedListConstructor
    //{
    //    Hashtable head = new Hashtable();
    //    Hashtable tail = new Hashtable();
    //    int value;
    //    int length;

    //    public MyLinkedListConstructor(int value)
    //    {
    //        this.head.Add(value, null);            
    //        this.length = 1;
    //        this.tail = this.head;
    //    }

    //}



}
