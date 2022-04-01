using System;
using System.Collections;
using System.Collections.Generic;

namespace BigO_workspace
{
    public class UserHashTables
    {
        public int age = 54;
        public string name = "Trisha";
        public bool magic = false;
        public void scream()
        {
            Console.WriteLine("OOOOHHHH!");
        }        
    }

    // example of a hash table
    class SampleHashTable
    {
        public static void FunctionOne()
        {
            Hashtable myHash2 = new Hashtable();
            myHash2.Add("a", 100); // adds elements to a hash table
            //myHash2.Add("h", false);

            // checks to see if myHash2 contains this key before allowing an output
            // to be safer
            if (myHash2.ContainsKey("a"))
            {
                Console.WriteLine(myHash2["a"].ToString());
            }

            // this code is more prone to error
            //Console.WriteLine(myHash2["b"].ToString());            

            // changes the value of a key
            myHash2["a"] = 50;

            // outputs all the elements of the hashtable
            ICollection keys = myHash2.Keys;
            foreach (String k in keys)
            {
                Console.WriteLine(k + ": " + myHash2[k]);
            }
        }
    }

    // ------HOW HASH IMPLEMENTATION WORKS------------
    //------------START-------------
    // the object where the hashtable function will send
    // the key-value pair
    public class MyNode
    {
        public string key
        {
            get;
            set;
        }
        public int value
        {
            get;
            set;
        }
        public MyNode(string key, int value)
        {
            this.key = key;
            this.value = value;
        }
    }

    // the main hashtable function
    public class MyHashTable
    {
        // list where we could essentially add value
        // and convert them to the table
        private class MyNodes : List<MyNode> { }      

        // key-value pair is sent here
        private MyNodes[] data;

        // length of the data
        public int length;

        public ICollection Keys { get; internal set; }

        public MyHashTable(int size)
        {
            this.length = size;
            this.data = new MyNodes[size];
        }

        // where the key gets a hashed value
        private int hash(string key)
        {
            int hash = 0;
            for (int i = 0; i < key.Length; i++)
            {
                hash = (hash + (int)key[i] * i) % this.length;
            }
            return hash;
        }


        // sets(gives) the key-value pair an address
        // in the memory
        public void set(string key, int value)
        {
            int index = hash(key); // hashes the parameter 1
            if (this.data[index] == null)
            {
                this.data[index] = new MyNodes(); // pushes the value into the object
            }
            // adds another pair to the same address if
            // not null
            this.data[index].Add(new MyNode(key, value));
        }


        // gets the key from the hash table and outputs the value
        public int get(string key)
        {
            int index = hash(key); // hashes the parameter 1
            // checks if data is equal to a null
            if (this.data[index] == null)
            {
                return 0;
            }
            // if not then
            // loops through the data (like an array) and
            // checks the key, if it finds the key then
            // returns the value of the key
            foreach (var node in this.data[index])
            {
                if (node.key.Equals(key))
                {
                    return node.value;
                }
            }
            return 0;
        }


        // a list data type function
        // uses a list to add key-value pairs
        public List<string> keys()
        {
            List<string> result = new List<string>();
            for (int i = 0; i < this.data.Length; i++)
            {
                if (this.data[i] != null)
                {
                    for (int j = 0; j < length; j++)
                    {
                        result.Add(this.data[i][j].key);
                    }
                }
            }
            return result;
        }

        internal void Add(object a, bool v)
        {
            throw new NotImplementedException();
        }
        //------------END-------------
    }

    public class AnotherHashTable
    {
        // given an array, I want to know if there
        // are any recurring integers on it and
        // returns that number, if
        // none are detected then it must return
        // undefined using hash table
        // arr {2,5,1,2,3,5,1,2,4}

        // bruteforce approach
        // create a hash table and insert every element
        // in the array while checking if there
        // element duplicates
        public static void RecurringNumber(int[] userArray)
        {
            bool isDuplicate = false;
            Hashtable myHash = new Hashtable();
            for (int i = 0; i < userArray.Length; i++)
            {
                if (myHash.ContainsKey(userArray[i]))
                {
                    isDuplicate = true;
                    Console.WriteLine(userArray[i]);
                    break;
                }       
                //myHash[userArray[i]] = true;
                myHash.Add(userArray[i], true);
                //myHash[userArray[i]] = userArray[i];
            }
            if (!isDuplicate)
            {
                Console.WriteLine("undefined");
            }

            ICollection key = myHash.Keys;

            foreach (int k in myHash.Keys)
            {
                Console.WriteLine(k + ": " + myHash[k]);
            }
        }
    }
}
