import java.util.ArrayList;
import java.util.Scanner;

class Lr4 {
    public static final String ANSI_PURPLE = "\u001B[35m";
    public static final String ANSI_RESET = "\u001B[0m";
    public static final String ANSI_RED = "\u001B[31m";

    public static void main(String[] args) {
        int[][] array = createArray();
        int key = keyValue(array);

        System.out.println(ANSI_PURPLE + "\n\t\tINITIAL ARRAY" + ANSI_RESET);
        print(array);
        double time = System.nanoTime();
        ArrayList<Integer> barrierIndexes = barrierSearch(array, key);
        double barrierTime = (System.nanoTime() - time) / 1_000_000.0;
        System.out.println("\nfor barrier search:");
        result(barrierIndexes, array, key);

        insertionSort(array);
        System.out.println(ANSI_PURPLE + "\n\t\tSORTED ARRAY" + ANSI_RESET);
        print(array);
        time = System.nanoTime();
        ArrayList<Integer> binaryIndexes = binarySearch(array, key);
        time = (System.nanoTime() - time) / 1_000_000.0;
        System.out.println("for binary search:");
        result(binaryIndexes, array, key);

        System.out.printf("\nelapsed time \nbarrier search: %4.3f ms\nbinary search: %4.3f ms\n", barrierTime, time);
    }

    public static ArrayList<Integer> barrierSearch(int[][] array, int key) {
        int LI = array.length - 1;        //LI - last index
        ArrayList<Integer> index = new ArrayList<>();

        int lastElem = array[LI][LI];
        array[LI][LI] = key;
        for (int i = 0; i < array.length; i++) {
            for (int j = 0; j < array.length; j++) {
                if (array[i][j] == key) {
                    index.add(i);
                    index.add(j);
                }
            }
        }
        array[LI][LI] = lastElem;

        if ((array[LI][LI] != key)) {
            index.remove(index.size() - 1);
            index.remove(index.size() - 1);
        }
        return index;
    }

    public static ArrayList<Integer> binarySearch(int[][] array, int key) {
        ArrayList<Integer> index = new ArrayList<>();

        for (int i = 0; i < array.length; i++) {
            int firstIndex = 0;
            int lastIndex = array[i].length - 1;

            while (firstIndex <= lastIndex) {
                int middleIndex = firstIndex + ((lastIndex - firstIndex) / 2);

                if (array[i][middleIndex] == key) {
                    index.add(i);
                    index.add(middleIndex);
                    if (middleIndex != 0 && array[i][middleIndex-1] == key){
                        index.add(i);
                        index.add(middleIndex-1);
                    }
                    if (middleIndex != array[i].length-1 && array[i][middleIndex+1] == key){
                        index.add(i);
                        index.add(middleIndex+1);
                    }
                    break;
                } else if (array[i][middleIndex] < key) {
                    firstIndex = middleIndex + 1;
                } else if (array[i][middleIndex] > key) {
                    lastIndex = middleIndex - 1;
                }
            }
        }
        return index;
    }

    private static void insertionSort(int[][] arr) {
        for (int i = 0; i < arr.length; i++) {
            for (int j = 1; j < arr.length; j++) {
                int current = arr[i][j];
                int k = j - 1;
                while (k >= 0 && current < arr[i][k]) {
                    arr[i][k + 1] = arr[i][k];
                    k--;
                }
                arr[i][k + 1] = current;
            }
        }
    }

    public static void result(ArrayList<Integer> index, int[][] array, int key) {
        if (index.size() < 2) {
            System.out.println("key was not found");
        } else {
            for (int i = 0; i < index.size() - 1; i++) {
                if (array[index.get(i)][index.get(i + 1)] == key) {
                    System.out.println("key found at row " + (index.get(i) + 1) + " col " + (index.get(i + 1) + 1));
                }
            }
        }
    }


    private static int[][] createArray() {
        Scanner scan = new Scanner(System.in);
        System.out.print("\nenter the size of an array: ");
        final int N = scan.nextInt();
        int[][] array = new int[N][N];

        int max = N >= 50 ? 837 : 239;
        int min = N >= 50 ? -264 : -44;
        for (int i = 0; i < array.length; i++) {
            for (int j = 0; j < array.length; j++) {
                array[i][j] = (int) (Math.random() * (max - min + 1) + min);
            }
        }
        return array;
    }

    private static int keyValue(int[][] array) {
        Scanner scan = new Scanner(System.in);
        String res = array.length < 50 ? "-44 to 239" : "-264 to 837";
        boolean correct = false;
        int key = 0;

        while (!correct) {
            System.out.printf("enter the searching key between [%s]: ", res);
            key = scan.nextInt();

            if (array.length < 50 && (key < -44 || key > 239)) {
                System.out.println(ANSI_RED + "\tincorrect key value, please, try again" + ANSI_RESET);
            } else if (array.length >= 50 && (key < -264 || key > 837)) {
                System.out.println(ANSI_RED + "\tincorrect key value, please, try again" + ANSI_RESET);
            } else {
                correct = true;
            }
        }

        return key;
    }

    private static void print(int[][] array) {
        for (int[] arr : array) {
            for (int j = 0; j < array.length; j++) {
                System.out.printf("%5d", arr[j]);
            }
            System.out.println();
        }
        System.out.println();
    }
}