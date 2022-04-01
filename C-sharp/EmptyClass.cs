using System;
namespace BigO_workspace
{
    public class EmptyClass
    {     
        
        public static void PrintFirstItemTenHalfThenSayHi100Times(int[] items)
        {
            Console.WriteLine(items[0]);

            decimal quotient = items.Length / 2;
            var middleIndex = Math.Floor(quotient);
            int index = 0;

            while (index < middleIndex)
            {
                Console.WriteLine(items[index]);
                index++;
            }

            for (int i = 0; i< 100; i++)
            {
                Console.WriteLine("Hi");
            }
            
        }

        public static void ArrayPairs(string[] arr) // ? = 0(n^2)
        {
            for (int i = 0; i < arr.Length; i++) // 0(n)
            {
                for (int j = 0; j < arr.Length; j++) // 0(n)
                {
                    if (j >= arr.Length - 1) // 0(n)
                    {
                        Console.Write($"{arr[i]}{arr[j]}\n"); // 0(1)
                    }
                    else // 0(1)
                    {
                        Console.Write($"{arr[i]}{arr[j]}, "); // 0(1)
                    }                    
                }
            }
        }

        public static void SumOfElements(int[] arr)
        {
            Console.WriteLine("The elements to add to each other");
            for (int i = 0; i < arr.Length; i++)
            {
                if (i >= arr.Length - 1)
                {
                    Console.Write($"{arr[i]}\n");
                }
                else
                {
                    Console.Write($"{arr[i]}, ");
                }
            }

            Console.WriteLine("their sums:");
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr.Length; j++)
                {
                    if (j >= arr.Length - 1)
                    {
                        Console.Write($"{arr[i] + arr[j]}\n");
                    }
                    else
                    {
                        Console.Write($"{arr[i] + arr[j]}, ");
                    }
                }
            }
        }
    }
}
