using System;
namespace BigO_workspace
{
    //we need to merge both arrays into one
    // userNewRecord {0,3,4,31}
    // userOldRecord {4,6,30}
    public class MergedSort
    {        
        // bruteforce approach
        // O(n + m + o) Time complexity
        // create an empty array and merge the both array into the new one
        // and then sort the arrays one by one
        public static void MergeSortedArrays(int[] userNewRecord, int[] userOldRecord)
        {
            int lengthOfTwoArrays = userNewRecord.Length + userOldRecord.Length;
            int counter = 0;
            int[] userFinalRecord = new int[lengthOfTwoArrays];
            // gets the element of the first array
            for (int i = 0; i < userNewRecord.Length; i++)
            {
                userFinalRecord[i] += userNewRecord[i];
                counter++;
            }

            // gets the elements of the second array
            for (int i = 0; i < userOldRecord.Length; i++)
            {
                userFinalRecord[counter + i] += userOldRecord[i];
            }

            // outputs the combined
            // not included on the computation--------------------------
            Console.WriteLine("Combined Arrays:");                      //
            for (int i = 0; i < userFinalRecord.Length; i++)            //
            {                                                           //
                if (i >= userFinalRecord.Length - 1)                    //
                {                                                       //
                    Console.Write(userFinalRecord[i] + "\n");           //
                }                                                       //
                else                                                    //
                {                                                       //
                    Console.Write(userFinalRecord[i] + ", ");           //
                }                                                       //
            }                                                           //
            //-----------------------------------------------------------

            // sort the arrays by increasing digits
            for (int i = 0; i < userFinalRecord.Length - 1; i++)
            {
                if (userFinalRecord[i] > userFinalRecord[i + 1])
                {
                    int temp = userFinalRecord[i]; // temporary holds a value
                    userFinalRecord[i] = userFinalRecord[i + 1];
                    userFinalRecord[i + 1] = temp;
                }
            }

            // outputs the sorted array
            // not included on the computation-----------------------
            Console.WriteLine("Sorted Final Array:");               //
            for (int i = 0; i < userFinalRecord.Length; i++)        //
            {                                                       //
                if (i >= userFinalRecord.Length - 1)                //
                {                                                   //
                    Console.Write(userFinalRecord[i] + "\n");       //
                }                                                   //
                else                                                //
                {                                                   //
                    Console.Write(userFinalRecord[i] + ", ");       //
                }                                                   //
            }                                                       //
            //-------------------------------------------------------
        }


        // improved approach
        // combine two arrays as well as sort them in one loop using
        // if-else then use another loop to add whichever elements are left
        // O(n + m) Time complexity
        public static void MergeSortedArrays2(int[] userNewRecord, int[] userOldRecord)
        {
            int lengthOfNewRecord = userNewRecord.Length;
            int lengthOfOldRecord = userOldRecord.Length;
            int lengthOfFinalRecord = lengthOfNewRecord + lengthOfOldRecord;
            int[] userFinalRecord = new int[lengthOfFinalRecord];
            int i = 0, j = 0, k = 0;

            // loop that combines and sort the elements at the same time
            while (i < lengthOfNewRecord || j < lengthOfOldRecord)
            {
                if (i < lengthOfNewRecord && j < lengthOfOldRecord)
                {
                    if (userNewRecord[i] < userOldRecord[j])
                    {
                        userFinalRecord[k++] = userNewRecord[i++];
                    }
                    else
                    {
                        userFinalRecord[k++] = userOldRecord[j++];
                    }
                }
                else if (i < lengthOfNewRecord)
                {
                    userFinalRecord[k++] = userNewRecord[i++];
                }
                else if (i < lengthOfOldRecord)
                {
                    userFinalRecord[k++] = userOldRecord[j++];
                }
                
            }

            // only one loop will activate and
            // adds any remaining elements to the
            // final array
            //while (i < lengthOfNewRecord)
            //{
            //    userFinalRecord[k++] = userNewRecord[i++];
            //}

            //while (j < lengthOfOldRecord)
            //{
            //    userFinalRecord[k++] = userOldRecord[j++];
            //}

            // outputs the elements of the final array
            // not include in the computation
            Console.WriteLine("Sorted Final Array:");
            for (i = 0; i < lengthOfFinalRecord; i++)
            {
                if (i >= lengthOfFinalRecord - 1)
                {
                    Console.Write(userFinalRecord[i] + "\n");
                }
                else
                {
                    Console.Write(userFinalRecord[i] + ", ");
                }
            }
        }
    }
}
