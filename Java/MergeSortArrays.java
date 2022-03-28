public class MergeSortArrays {
    
    public static void MergeAndSortArrays(int[] userNewRecord, int[] userOldRecord) {
        int lengthOfNR = userNewRecord.length;
        int lengthOfOR = userOldRecord.length;
        int lengthOfFR = lengthOfNR + lengthOfOR;
        int[] userFinalRecord = new int[lengthOfFR]; // declares the size of the array
        int i = 0, j = 0, k = 0;

        // this combines the two arrays together and sorts at the same time in one loop
        while (i < lengthOfNR && j < lengthOfOR){
            if (userNewRecord[i] < userOldRecord[j]){
                userFinalRecord[k++] = userNewRecord[i++];
            }
            else {
                userFinalRecord[k++] = userOldRecord[j++];
            }
        }

        // using a loop to add the remaining elements to the final array
        // only one of the loop will activate
        // PROBLEM: if two arrays are not sorted there is a big chance that it wont be sorted as a whole
        while (i < lengthOfNR){
            userFinalRecord[k++] = userNewRecord[i++];
        }
        while (j < lengthOfOR){
            userFinalRecord[k++] = userOldRecord[j++];
        }

        //System.out.println("x");

        for (i = 0; i < lengthOfFR; i++){
            if (i >= lengthOfFR - 1){
                System.out.print(userFinalRecord[i]);
            }
            else {
                System.out.print(userFinalRecord[i] + ", ");
            }
            //System.out.println(userFinalRecord[i]);
        }
    }
}
