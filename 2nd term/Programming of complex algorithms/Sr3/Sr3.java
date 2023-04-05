import java.util.Arrays;
import java.util.Scanner;

class Sr3 {
    public static void main(String[] args) {
        Scanner scan = new Scanner(System.in);
        System.out.println("enter the size of an array");
        final int N = scan.nextInt();
        int[] a = new int[N];
        int odd = 0;
        int max = N > 50 ? N > 1000 ? 20000 : 1000 : 99;
        int min = N > 50 ? N > 1000 ? -18000 : -850 : -24;

        for (int i = 0; i < a.length; i++) {
            a[i] = (int) (Math.random() * (max - min + 1) + min);
            if(a[i] % 2 != 0){
                odd++;
            }
        }

        int[] b = new int[odd];
        int j = 0;

        for (int k : a) {
            if (k % 2 != 0) {
                b[j] = k;
                j++;
            }
        }
        System.out.println("initial array");
        System.out.println(Arrays.toString(a));
        int[] c1 = Arrays.copyOf(b, b.length);
        int[] c2 = Arrays.copyOf(b, b.length);
        int[] c3 = Arrays.copyOf(b, b.length);

        System.out.println("INSERTION sorted");
        long time = System.nanoTime();
        insertionSort(c1);
        double inserTime = (System.nanoTime() - time)/1_000_000.0;
        System.out.println(Arrays.toString(c1));

        System.out.println("SELECTION sorted");
        time = System.nanoTime();
        selectionSort(c2);
        double selecTime = (System.nanoTime() - time)/1_000_000.0;
        System.out.println(Arrays.toString(c2));

        System.out.println("SHELL sorted");
        time = System.nanoTime();
        shellSort(c3);
        double shellTime = (System.nanoTime() - time)/1_000_000.0;
        System.out.println(Arrays.toString(c3));

        System.out.println("QUICK sorted");
        time = System.nanoTime();
        quickSort(b, 0, b.length-1);
        double quickTime = (System.nanoTime() - time)/1_000_000.0;
        System.out.println(Arrays.toString(b));

        System.out.printf("\nelapsed time \ninsertion sort: %4.3f ms\nselection sort: %4.3f ms\n" +
                "shell sort: %4.3f ms\nquick sort: %4.3f ms\n", inserTime, selecTime, shellTime, quickTime);
    }

    public static void selectionSort(int[] arr) {
        int temp, index;
        for(int i = 0; i < arr.length; i++) {
            index = i;
            temp = arr[i];
            for (int j = i + 1; j < arr.length; j++) {    // цикл выбора найбольшего элемента
                if (arr[j] > temp) {
                    index = j;
                    temp = arr[j];
                }
            }
            arr[index] = arr[i];
            arr[i] = temp;                   // меняем местами найбольший с a[i]
        }
    }

    public static void  insertionSort(int[] arr) {
        for (int i = 1; i < arr.length; i++) {
            int current = arr[i];
            int j = i - 1;
            while(j >= 0 && current > arr[j]) {
                arr[j+1] = arr[j];
                j--;
            }
            arr[j+1] = current;
        }
    }

    public static void quickSort(int[] arr, int low, int high) {
        if (low < high) {
            int pivot = arr[low];
            int i = low;
            int j = high;
            int temp;

            while(i < j) {
                while(arr[j] < pivot) j--;
                while(i < arr.length && arr[i] >= pivot) i++;

                if (i < j) {
                    temp = arr[i];
                    arr[i] = arr[j];
                } else {
                    temp = arr[low];
                    arr[low] = arr[j];
                }
                arr[j] = temp;
            }
            quickSort(arr, low,j-1);
            quickSort(arr,j+1 ,high);
        }
    }


    public static void shellSort(int[] arr) {
        for (int gap = arr.length/2; gap > 0; gap /= 2) {
            for (int i = gap; i < arr.length; i++) {
                int temp = arr[i];
                int j;
                for (j = i; j >= gap && arr[j - gap] < temp; j -= gap) {
                    arr[j] = arr[j - gap];
                }
                arr[j] = temp;
            }
        }
    }
}