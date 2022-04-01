using System;
using System.Collections.Generic;

namespace BigO_workspace
{
    class BinarySearch
    {
        public static int myBinarySearch(List<int> arr, int num)
        {
            int min = 0, max = arr.Count - 1;

            while (min <= max)
            {
                int mid = (min + max) / 2;
                if (num == arr[mid])
                {
                    return mid;
                }
                else if (num < arr[mid])
                {
                    max = mid - 1;
                }
                else
                {
                    min = mid + 1;
                }
            }
            return 0;
        }
    }
}
