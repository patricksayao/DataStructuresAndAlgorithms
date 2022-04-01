using System;
using System.Collections;
using System.Diagnostics;
using System.Threading;
using System.Linq;
using System.Collections.Generic;

namespace BigO_workspace
{
    public class EmptyClassTwo
    {
        //public EmptyClassTwo()
        //{
        //}

        public static bool CommonArrayItem(string[] arr1, string[] arr2)
        {
            // basic bruteforce approach
            // using a nested loop to compare each element of the first array
            // and to the elements second array
            // O(n*m)

            //Stopwatch stopwatch = new Stopwatch();
            //TimeSpan ts = stopwatch.Elapsed;
            //stopwatch.Start();
            for (int i = 0; i < arr1.Length; i++)
            {
                for (int j = 0; j < arr2.Length; j++)
                {
                    if (arr1[i] == arr2[j])
                    {
                        //stopwatch.Stop();                       
                        //Console.WriteLine("Elapsed Time is {0} ms", stopwatch.ElapsedMilliseconds);
                        //Console.WriteLine("Elapsed RunTime in TimeStamp is {0:00}:{1:00}:{2:00}.{3}",
                        //        ts.Hours, ts.Minutes, ts.Seconds, ts.Milliseconds);
                        return true;
                    }
                }
            }
            //stopwatch.Stop();
            //Console.WriteLine("Elapsed Time is {0} ms", stopwatch.ElapsedMilliseconds);
            //Console.WriteLine("Elapsed RunTime in TimeStamp is {0:00}:{1:00}:{2:00}.{3}",
            //        ts.Hours, ts.Minutes, ts.Seconds, ts.Milliseconds);
            return false;
        }

        public static bool CommonArrayItem2(object[] arr1, object[] arr2)
        {
            // improved approached
            // loops through the first array to create a hash table
            // where properties == items in the array then loop
            // through second array and check if the item in second array
            // exists on created object
            // O(n + m)


            Hashtable arrHash = new Hashtable();
            //arrHash.Add("A", true); 

            foreach (string i in arr1)
            {
                if (!i.Equals(arr1)) // just in case if the table already has a similar key
                {
                    var item = i;
                    arrHash[item] = true;
                    //arrHash.Add(i, true);
                }                
            }

            //ICollection key = arrHash.Keys;

            //foreach (string k in arrHash.Keys)
            //{
            //    Console.WriteLine(k + ": " + arrHash[k]);
            //}
            //Console.ReadKey();

            for (int i = 0; i < arr2.Length; i++)
            {
                if (arrHash.ContainsKey(arr2[i]))
                {
                    return true;
                }
            }

            return false;
        }

        public static bool CommonItemPair3(object[] arr1, object[] arr2)
        {
            // using a premade function from c# I used
            // intersect function to compare two arrays
            // and check both of them to see if they
            // have matching elements
            IEnumerable<object> both = arr1.Intersect(arr2);
            foreach (object i in both)
            {
                return true;
            }
            return false;
        }

    }
}
