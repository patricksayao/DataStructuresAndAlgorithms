public class FirstClass {
    
    public static void PrintItemsInArray(int[] arr){
        //System.out.println("Hi");

        long startTime = System.currentTimeMillis(); // runtime in milliseconds

        double quotient = arr.length / 2;
        double middleIndex = Math.floor(quotient);
        int index = 0;

        while (index < middleIndex){
            System.out.println(arr[index]);
            index++;
        }

        for (int i = 0; i < 100; i++){
            System.out.println("Hi");
        }

        long estimatedTime = System.currentTimeMillis() - startTime; // subtracts the starttime before at the beginning to the end of the program
        System.out.println("runtime is: " + estimatedTime + " milisecs");
    }

    public static void ArrayPairs(int[] arr) {
        for (int i = 0; i < arr.length; i++){
            for (int j = 0; j < arr.length; j++){
                if (j >= arr.length - 1){
                    System.out.print(arr[i] + "" + arr[j] +"\n");
                }
                else{
                    System.out.print(arr[i] +""+ arr[j] + ", ");
                }
            }
        }
    }

    public static void ArrayPairs2(String[] arr) {
        for (int i = 0; i < arr.length; i++){
            for (int j = 0; j < arr.length; j++){
                if (j >= arr.length - 1){
                    System.out.print(arr[i] + arr[j] +"\n");
                }
                else{
                    System.out.print(arr[i] + arr[j] + ", ");
                }
            }
        }
    }

    public static void SumOfElements(int[] arr) {
        System.out.println("The sum is:");
        for (int i = 0; i < arr.length; i++){
            for (int j = 0; j < arr.length; j++){
                if (j >= arr.length - 1){
                    System.out.print(arr[i] + arr[j] + "\n");
                }
                else{
                    System.out.print(arr[i] + arr[j] +", ");
                }
            }
        }
    }
}
