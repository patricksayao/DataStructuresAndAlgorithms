// import java.util.Arrays;
// import java.util.Scanner;
import java.util.Stack;

public class ThirdClass {
    
    public static void CreatingStack() {
        // String[] strings = { "a", "b", "c", "d", "e" };

        // String[] name = {"Fred", "Justin"};

        Stack<String> myStack = new Stack<>();
        myStack.push("item1");
        myStack.pop();
        myStack.push("item2");

        System.out.println(myStack);


        // Scanner myObject = new Scanner(System.in);
        // System.out.println("type your name:\n");
        // String userName = myObject.nextLine();
        // System.out.println("Your name is: " + userName);
    }

    // reverse a string
    // create a function that reverses the characters on a given string
    // brutefore approach
    // O(n)
    public static String StringReverse(String str) {
        // put the string characters in an array
        char[] charArray = str.toCharArray(); // O(1)        
        // creates an empty string variable
        String reverseString = "";
        // iterates each elements in the array and adds them to the empty char variable
        // one by one
        for (int i = charArray.length - 1; i > -1; i--){
            reverseString += charArray[i];
        }
        return reverseString;
    }

    // improved approach
    // use a java library function to minimize operation
    // of the above code
    // O(n)
    public static String StringReverse2(String str) {
        char charArray;
        String reverseString = "";
        for (int i = 0; i < str.length(); i++){
            charArray = str.charAt(i);
            reverseString += charArray;
        }
        return reverseString;
    }
}
