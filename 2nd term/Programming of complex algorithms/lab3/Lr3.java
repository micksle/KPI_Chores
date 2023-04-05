import java.util.Arrays;
import java.util.Scanner;

public class Lr3 {
    public static final String ANSI_PURPLE = "\u001B[35m";
    public static final String ANSI_RESET = "\u001B[0m";

    public static void main(String[] args) {
        int[][] array = createArray();
        int[][] selectionArray = new int[array.length][array.length];
        int[][] bubbleArray = new int[array.length][array.length];
        for (int i = 0; i < array.length; i++) {
            bubbleArray[i] = Arrays.copyOf(array[i], array.length);
            selectionArray[i] = Arrays.copyOf(array[i], array.length);
        }

        System.out.println(ANSI_PURPLE + "\tINITIAL ARRAY" + ANSI_RESET);
        print(array);

        System.out.println(ANSI_PURPLE + "\n\tinsertion sort" + ANSI_RESET);
        double time = System.nanoTime();
        insertionSort(array);
        double inserTime = (System.nanoTime() - time) / 1_000_000.0;
        print(array);

        System.out.println(ANSI_PURPLE + "\n\tselection sort" + ANSI_RESET);
        time = System.nanoTime();
        selectionSort(selectionArray);
        double selecTime = (System.nanoTime() - time) / 1_000_000.0;
        print(selectionArray);

        System.out.println(ANSI_PURPLE + "\n\tbubble sort" + ANSI_RESET);
        time = System.nanoTime();
        bubbleSort(bubbleArray);
        double bubbleTime = (System.nanoTime() - time) / 1_000_000.0;
        print(bubbleArray);

        System.out.printf("\nelapsed time \ninsertion sort: %4.3f ms\nselection sort: %4.3f ms\nbubble sort: %4.3f ms\n", inserTime, selecTime, bubbleTime);
    }

    private static void insertionSort(int[][] array) {
        int t = array.length - 2;
        for (int i = 0; i < array.length; i++) {
            for (int j = 1; j < array.length; j++) {
                int current = array[i][j];
                int k = j - 1;

                while (k >= 0 && current > array[i][k]) {
                    array[i][k + 1] = array[i][k];
                    k--;
                }
                array[i][k + 1] = current;

            }
        }
    }

    private static void selectionSort(int[][] array) {
        int temp, index;
        int t = array.length - 2;
        for (int i = 0; i < array.length; i++) {
            for (int j = 0; j < array.length; j++) {
                if ((i + j > t + 1) || (i + j == t + 1)) {
                    index = j;
                    temp = array[i][j];
                    for (int k = j + 1; k < array.length; k++) {   // цикл выбора найбольшего элемента
                        if (array[i][k] > temp) {
                            index = k;
                            temp = array[i][k];
                        }
                    }
                    array[i][index] = array[i][j];
                    array[i][j] = temp;                   // меняем местами найбольший с a[i]
                }
            }
        }
    }

    private static void bubbleSort(int[][] array) {
        boolean sorted = false;
        int temp;
        int t = array.length - 2;
        while (!sorted) {
            sorted = true;
            for (int i = 0; i < array.length; i++) {
                for (int j = 0; j < array.length - 1; j++) {
                    if ((i + j > t + 1) || (i + j == t + 1)) {
                        if (array[i][j] < array[i][j + 1]) {
                            temp = array[i][j];
                            array[i][j] = array[i][j + 1];
                            array[i][j + 1] = temp;
                            sorted = false;
                        }
                    }
                }
            }
        }
    }

    private static int[][] createArray() {
        Scanner scan = new Scanner(System.in);
        System.out.println("\nenter the size of an array");
        final int N = scan.nextInt();
        int[][] array = new int[N][N];

        int max = N > 50 ? N > 99 ? 999 : 234 : 99;
        int min = N > 50 ? N > 99 ? -425 : -178 : -24;
        for (int i = 0; i < array.length; i++) {
            for (int j = 0; j < array.length; j++) {
                array[i][j] = (int) (Math.random() * (max - min + 1) + min);
            }
        }
        return array;
    }

    private static void print(int[][] array) {
        for (int[] arr : array) {
            for (int j = 0; j < array.length; j++) {
                System.out.printf("%4d", arr[j]);
            }
            System.out.println();
        }
    }

}