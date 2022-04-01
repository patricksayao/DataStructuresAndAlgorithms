using System;
namespace BigO_workspace
{
    class MyRecursion
    {

        // write two functions that finds the factorial of any number
        // one should be recursive an one should be loop
        public static long FindFactorialRecursive(int number)
        {
            if (number == 1)
            {
                return 1;
            }
            Console.WriteLine("--> " + number);
            return number * FindFactorialRecursive(number - 1);
        }

        public static long FindFactorialIterative(int number)
        {
            long answer = 1;
            for (int i = number; i > 0; i--)
            {
                answer *= i;
            }
            return answer;
        }

        public static int FibonnaciIterative(int number)
        {
            int count = 1;
            int temp = 1;
            int sum = 0;
            for (int i = number; i > 0; i--)
            {
                sum = count + temp;
                Console.WriteLine($"{temp} + {count} = {sum}");                
                if (count >= 2)
                {
                    temp = count;
                }
                count++;
            }
            return sum;
        }

        public static int FibonnaciRecursive(int number)
        {
            if (number < 2)
            {
                return number;
            }
            //Console.WriteLine(FibonnaciRecursive(number - 1) + FibonnaciRecursive(number - 2));
            return FibonnaciRecursive(number - 1) + FibonnaciRecursive(number - 2);
        }

        public static string ReverseStringIteratively(string s)
        {
            string newStr = "";
            if (s.Length == 0)
            {
                return "no characters entered";
            }
            for (int i = 1; i <= s.Length; i++)
            {
                newStr += s[s.Length - i];
            }
            return newStr;
        }

        public static string ReverseStringRecursive(string s)
        {
            if (s.Length == 0)
            {
                return "";
            }
            //Console.WriteLine(s.Substring(1) + s[0] + "\n");
            return ReverseStringRecursive(s.Substring(1)) + s[0];
        }
    }
}
