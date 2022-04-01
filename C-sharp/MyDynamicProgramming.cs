using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading;

namespace BigO_workspace
{
    class MyDynamicProgramming
    {
        // basic memoization----------------------------------------------------
        // this list will hold the value
        private static Dictionary<int, int> cache = new Dictionary<int, int>();
        // the function
        public static int Memoization(int n)
        {
            // if item is present in cache
            if (cache.ContainsKey(n))
            {
                Console.WriteLine("item exists");
                return cache[n]; // return the value in the index of the cache
            }
            // if item is not present in cache
            else
            {
                Console.WriteLine("item non existant");
                cache.Add(n, n + 30); // adds the value in the cache
                return cache[n]; // return the value in the index of the cache
            }
        }
        //----------------------------------------------------------------------


        // improved memoization-------------------------------------------------
        //public static int ImprovedMemoization()
        //{
        //    Dictionary<int, int> cache2 = new Dictionary<int, int>();

        //    Func<int, int> someFunc = delegate (int n)
        //    {
        //        if (cache.ContainsKey(n))
        //        {
        //            Console.WriteLine("item exists");
        //            return cache[n]; // return the value in the index of the cache
        //        }
        //        // if item is not present in cache
        //        else
        //        {
        //            Console.WriteLine("item non existant");
        //            cache.Add(n, n + 30); // adds the value in the cache
        //            return cache[n]; // return the value in the index of the cache
        //        }
        //    };

        //    return someFunc(n);          
        //}

        //int myInt = 


        public static Func<int, int> square = n => n * n;

        public static Func<int, int> slowSquare = n =>
        {
            Thread.Sleep(100);
            return n * n;
        };

        public static TimeSpan Measure(Action action)
        {
            var sw = new Stopwatch();
            sw.Start();
            action();
            sw.Stop();
            return sw.Elapsed;
        }
    }
}
