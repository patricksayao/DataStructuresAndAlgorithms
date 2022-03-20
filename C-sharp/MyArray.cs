using System;
namespace BigO_workspace
{
    public class MyArray
    {
        // create a function that reverses the string
        public static string ReverseString(string str)
        {
            // divides each character in a string into elements of an array
            char[] stringArr = str.ToCharArray();
            
            string reverse = String.Empty; // empty string

            // starting from the last to the first, gets the element and adds it
            // into the string variable called reverse
            for (int i = stringArr.Length - 1; i > -1; i--)
            {
                reverse += stringArr[i];
            }
            return reverse;

            //Console.WriteLine(str);
            //return "";
        }

        public static string ReverseString2(string str)
        {
            string reverseString = string.Empty;
            for (int i = str.Length - 1; i > -1; i--)
            {
                reverseString += str[i];
            }
            return reverseString;
        }

        public static string ReverseString3(string str)
        {
            char[] stringArr = str.ToCharArray();

            Array.Reverse(stringArr);
            return new string(stringArr);
        }
    }
}
