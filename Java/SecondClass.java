import java.util.Arrays;
import java.util.Hashtable;

public class SecondClass {
    // compare two loops and check if they have a similar element

    // bruteforce approach
    // use nested loop to traverse and find the similar element
    //O(n * m) time complexity
    //O(1) space Complexity
    public static boolean CommonArrayItem(int[] arr1, int[] arr2) {
        for (int i = 0; i < arr1.length; i++){
            for (int j = 0; j < arr2.length; j++){
                if (arr1[i] == arr2[j]){
                    return true;
                }
            }
        }
        return false;
    }

    // improved approach
    // O(n + m) time complexity
    // O(n) space complexity
    // put the elements of the first array into a hash table
    public static boolean CommonArrayItem2(int[] arr1, int[] arr2) {
        Hashtable<Integer, Boolean> hashArray = new Hashtable();
        for (int i = 0; i < arr1.length; i++){
            hashArray.put(arr1[i], true);
        }

        //System.out.println(hashArray.size());
        //System.out.println(hashArray);


        // loop throught the second array and checks if the hash table
        // has a key with witj one of its element
        for (int j = 0; j < arr2.length; j++){
            if (hashArray.containsKey(arr2[j])){
                return true;
            }
        }
        return false;
    }

    // quickest method
    // O(1) Time and Space complexity
    // utilizes a function in the libray to compare
    // two arrays
    public static boolean CommonArrayItem3(int[] arr1, int[] arr2) {
        if (Arrays.equals(arr1, arr2)){
            return true;
        }
        return false;
    }
}
