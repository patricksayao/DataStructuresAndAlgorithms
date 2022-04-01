using System;
using System.Collections.Generic;

namespace BigO_workspace
{
    class MySortingAlgo
    {
        // Bubble sort START-------------------------------------------
        public static List<int> myBubbleSort(List<int> arr)
        {
            int temp;
            bool swapHappen = true;
            while (swapHappen)
            {
                swapHappen = false;
                for (int i = 0; i < arr.Count - 1; i++)
                {
                    if (arr[i] > arr[i + 1])
                    {
                        temp = arr[i];
                        arr[i] = arr[i + 1];
                        arr[i + 1] = temp;
                        swapHappen = true;
                    }
                }
            }
            return arr;
        }
        // Bubble sort END-------------------------------------------

        // Selection sort START-------------------------------------------
        public static List<int> mySelectionSort(List<int> arr)
        {
            int temp, selectionIndex = 0;
            while (selectionIndex < arr.Count)
            {
                for (int i = 0; i < arr.Count; i++)
                {
                    if (arr[i] > arr[selectionIndex])
                    {
                        temp = arr[i];
                        arr[i] = arr[selectionIndex];
                        arr[selectionIndex] = temp;
                    }
                }
                selectionIndex += 1;
            }
            return arr;
        }
        // Selection sort END-------------------------------------------

        // Insertion sort START-------------------------------------------
        public static List<int> myInsertionSort(List<int> arr)
        {
            // i should be 1 to start the comparison in the second index
            for (int i = 1; i < arr.Count; i++)
            {
                Console.WriteLine($"iteration {i}:");

                Console.WriteLine("The elements:");
                foreach (int k in arr)
                {
                    Console.Write(k + " ");
                }
                Console.Write("\n");                

                int key = arr[i];
                Console.WriteLine($"The key is: {key}");
                int j = i - 1;

                // Move elements of array[0..i-1], 
                // that are greater than key, 
                // to one position ahead of 
                // their current position
                Console.Write("Step 1 = move the bigger element/s: \n");
                while (j >= 0 && arr[j] > key)
                {
                    arr[j + 1] = arr[j];
                    
                    foreach (int k in arr)
                    {
                        Console.Write(k + " ");
                    }
                    Console.Write("\n");

                    j = j - 1;
                }
                arr[j + 1] = key;
                Console.Write("Step 2 = place the key in the right position: \n");
                foreach (int k in arr)
                {
                    Console.Write(k + " ");
                }
                Console.Write("\n\n");
            }

            Console.WriteLine("Sorted List:");
            return arr;
        }
        // Insertion sort END-------------------------------------------



        // MERGE SORT START----------------------------------------------
        public static List<int> myMergeSort(List<int> arr)
        {
            Console.Write($"Array to split is: ");
            foreach (var i in arr)
            {
                Console.Write(i + " ");
            }
            Console.Write("\n");

            // return the arr if it has one element left
            if (arr.Count <= 1)
            {
                Console.Write($"Array with one element detected... returning... ");
                foreach (var i in arr)
                {
                    Console.WriteLine(i);
                }
                Console.Write("\n");
                return arr;
            }

            // split array into right and left
            List<int> left = new List<int>();
            List<int> right = new List<int>();

            // count of of a given array by half
            int midpoint = arr.Count / 2;
            //Console.WriteLine(midpoint);

            Console.WriteLine("Split Operation Commencing...\n");


            // the left array ends at the middle of an array
            for (int i = 0; i < midpoint; i++)
            {
                left.Add(arr[i]);
            }
            // the right array starts where the midpoint ends
            for (int j = midpoint; j < arr.Count; j++)
            {
                right.Add(arr[j]);
            }

            // not included in computation-------------
            Console.Write("Left: ");
            foreach (int i in left)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine(" \n");
            Console.Write("Right: ");
            foreach (int j in right)
            {
                Console.Write(j + " ");
            }
            Console.WriteLine(" \n");
            //------------------------------------------

            Console.WriteLine("Split Operation Complete...\n");

            Console.WriteLine("recursion commencing...\n");

            // we use recursion to split the array again in half
            left = myMergeSort(left);
            right = myMergeSort(right);

            Console.WriteLine("recursion done...\n");

            // once recursion loop is done we use myMerge function
            // to merge each left and right arrays sortedly
            List<int> result = myMerge2(
                myMergeSort(left),
                myMergeSort(right)
            );

            return result;
        }

        public static List<int> myMerge2(List<int> left, List<int> right)
        {
            Console.WriteLine("Merge Operation Commencing...\n");
            Console.Write($"Left array: ");
            foreach (int item in left)
            {
                Console.Write(item + " ");
            }
            Console.Write("\n\n");
            Console.Write($"Right array: ");
            foreach (int item in right)
            {
                Console.Write(item + " ");
            }
            Console.Write("\n\n");


            List<int> sortedArr = new List<int>();
            int i = 0, j = 0;

            while (i < left.Count || j < right.Count)
            {
                if (i < left.Count && j < right.Count)
                {
                    if (left[i] < right[j])
                    {
                        sortedArr.Add(left[i]);
                        i++;
                    }
                    else
                    {
                        sortedArr.Add(right[j]);
                        j++;
                    }
                }
                else if (i < left.Count)
                {
                    sortedArr.Add(left[i]);
                    i++;
                }
                else if (j < right.Count)
                {
                    sortedArr.Add(right[j]);
                    j++;
                }
            }

            Console.Write("Sorted array list is: ");
            foreach (var item in sortedArr)
            {
                Console.Write($"{item} ");
            }
            Console.Write("\n\n");

            Console.WriteLine("Merge Operation Complete... \n");

            return sortedArr;
        }
        // MERGE SORT END----------------------------------------------


        // quick sort is very rarely used
        // QUICK SORT START--------------------------------------------
        //public static List<int> myQuickSort(List<int> arr)
        //{
        //    Random rnd = new Random();
        //    int pivot = rnd.Next(0, arr.Count - 1);

        //    Console.WriteLine($"the pivot is: {pivot}");

        //    for (int i = 0; i < arr.Count; i++)
        //    {
        //        if (pivot < arr[i])
        //        {
        //            int temp = arr[i];
        //            arr[i] = pivot;
        //            pivot = temp;
        //        }
        //    }

        //    return arr;
        //}

        //public static List<int> myQuickSort(List<int> arr, int left, int right)
        //{
        //    int pivot;
        //    List<int> partitionIndex;

        //    if (left < right)
        //    {
        //        pivot = right;
        //        partitionIndex = partition(arr, pivot, left, right);

        //        myQuickSort(arr, left, partitionIndex - 1);
        //        myQuickSort(arr, partitionIndex + 1, right);
        //    }
        //    return arr;
        //}

        //public static List<int> partition(List<int> arr, int pivot, int left, int right)
        //{
        //    int pivotValue = arr[pivot];
        //    int partitionIndex = left;

        //    for (int i = left; i < right; i++)
        //    {
        //        if (arr[i] < pivotValue)
        //        {
        //            swap(List<int> arr, int i, int partitionIndex);
        //            partitionIndex++;
        //        }
        //    }
        //    swap(List<int> arr, int right, int partitionIndex);
        //}
        // QUICK SORT END----------------------------------------------
    }
}
