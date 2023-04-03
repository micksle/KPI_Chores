package yearFIRST.termONE;

import java.util.Arrays;
import java.util.Scanner;

public class Pz3 {
    public static void main(String[] args) {
        Scanner scan = new Scanner(System.in);
        System.out.println("\n       First exercise");
        System.out.println("Enter a first array:");
        int[] array1 = new int[3];
        array1[0] = scan.nextInt();
        array1[1] = scan.nextInt();
        array1[2] = scan.nextInt();
        System.out.println("Enter a second array:");
        int[] array2 = new int[3];
        array2[0] = scan.nextInt();
        array2[1] = scan.nextInt();
        array2[2] = scan.nextInt();
        int middle[] = new int[2];
        middle = middleWay(array1, array2);
        System.out.printf("Middle array is: [%d, %d]", middle[0], middle[1]);

        System.out.println("\n       Second exercise");
        System.out.println("Enter the length of the matrix (not paired digit): ");
        int length = scan.nextInt();
        System.out.println("Enter the values");
        int[] array2nd = new int[length];
        for (int i = 0; i < array2nd.length; i++) {
            array2nd[i] = scan.nextInt();
        }
        int max = maxTriple(array2nd);
        System.out.println("The higher value among 1st, middle and the last digits is " + max);

        System.out.println("\n       Third exercise");
        System.out.println("Enter the length of the matrix:");
        int dlina = scan.nextInt();
        int loop[] = new int[dlina];
        for (int i = 0; i < loop.length; i++) {
            loop[i] = (1 + (i * 3) / 2);
        }
        System.out.println();
        System.out.println("The quantity of paired digits for matrix "+Arrays.toString(loop)+" is " + countEvens(loop));

        System.out.println("\n\n       Fourth exercise");
        int[] nums = new int[8];
        System.out.println("Enter the digits");
        nums[0] = scan.nextInt();
        nums[1] = scan.nextInt();
        nums[2] = scan.nextInt();
        nums[3] = scan.nextInt();
        nums[4] = scan.nextInt();
        nums[5] = scan.nextInt();
        nums[6] = scan.nextInt();
        nums[7] = scan.nextInt();
        System.out.printf("The digit '3' was found 3 times and not in a row - %b", haveThree(nums));

        System.out.println("\n\n       Fifth exercise");
        System.out.println("Enter the length of the matrix: ");
        int longitude = scan.nextInt();
        System.out.println("Enter the values");
        int[] array = new int[longitude];
        for (int i=0; i< array.length; i++) {
            array[i] = scan.nextInt();
        }
        System.out.println("Digits 0 sorted: "+Arrays.toString(zeroFront(array)));
    }


    public static int[] middleWay(int[] array1, int[] array2) {
        int middle[] = new int[2];
        middle[0] = array1[1];
        middle[1] = array2[1];
        return middle;
    }

    public static int maxTriple(int[] array2nd) {
        int max = 0;
        int x[] = new int[3];
        x[0] = array2nd[0];
        x[1] = array2nd[(array2nd.length) / 2];
        x[2] = array2nd[array2nd.length - 1];
        if (x[0] > x[1] && x[0] > x[2]) {
            max = x[0];
        } else if (x[1] > x[0] && x[1] > x[2]) {
            max = x[1];
        } else {
            max = x[2];
        }
        return max;
    }

    public static int countEvens(int[] loop) {
        int counter = 0;
        for (int i = 0; i < loop.length; i++) {
            if (loop[i] % 2 == 0) {
                counter++;
            }
        }
        return counter;
    }

    public static boolean haveThree(int[] nums) {
        boolean answear = false;
        int counter = 0;

        for (int i = 0; i < nums.length; i++) {
            if (i == 0) {
                if (((double) nums[i] / 3) == 1 && (nums[i] != nums[i + 1])) {
                    counter++;
                }
            } else if (i < 7) {
                if (((double) nums[i] / 3) == 1 && (nums[i - 1] != nums[i] && nums[i] != nums[i + 1])) {
                    counter++;
                }
            } else {
                if (((double) nums[i] / 3) == 1 && (nums[i - 1] != nums[i])) {
                    counter++;
                }
            }
        }
        if (counter == 3) {
            answear = true;
        }
        return answear;
    }

    public static int[] zeroFront(int[] array) {
        for (int i = 0; i< array.length; i++){
            for ( int j = i; j< array.length; j++){
                if (array[j]==0){
                    int tmp = array[j];
                    array[j] = array [i];
                    array [i] = tmp;
                    j++;

                }
            }
        }
        return array;
    }
}
