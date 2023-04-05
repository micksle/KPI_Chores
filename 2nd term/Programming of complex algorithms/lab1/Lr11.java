import java.util.Scanner;

/**
 * reversing the max and min row in matrix
 */

public class Lr11 {
    public static void main(String[] args) {
        Scanner scan = new Scanner(System.in);
        System.out.print("Enter the matrix size\nrows: ");
        final int N = scan.nextInt();
        System.out.print("columns: ");
        final int M = scan.nextInt();

        long time = System.nanoTime();

        int [][] array = new int[N][M];
        int [][] loop = new int[N][M];
        int [] summa = new int[array.length];
        int min = -5, max = 30;

        if (N > 15){
            max = (int) Math.ceil(N * 1.7);
        } else if (M > 15){
            max = (int) Math.ceil(M * 1.7);
        }

        int sum = 0;

        System.out.println("\t\t\tInitial matrix\n");
        for (int i = 0; i < array.length; i++) {
            for (int j = 0; j < array[i].length; j++){
                array[i][j] = (int) (Math.random()*(max-min+1)+min);
                sum += array[i][j];
                System.out.printf("%-3d\t", array[i][j]);
            }
            System.out.println();
            summa[i] = sum;
            sum = 0;
        }
        System.out.println();

        int maximum = summa[0];
        int maxR = 0;

        int minimum = summa[0];
        int minR = 0;

        for (int i = 0; i < array.length; i++) {
            if (summa[i] > maximum) {
                maximum = summa[i];
                maxR = i;
            }
            if (summa[i] < minimum){
                minimum = summa[i];
                minR = i;
            }
        }

        System.out.printf("\tmatrix with reversed MAX [%d] and MIN [%d] sum of rows\n\n", (maxR+1), (minR+1));
        for (int i = 0; i < loop.length; i++){
            for (int j = 0; j < loop[i].length; j++){
                loop[i][j] = array[i][j];
                if (i == minR) loop[i][j] = array[maxR][j];
                if (i == maxR) loop[i][j] = array[minR][j];
                System.out.printf("%-3d\t", loop[i][j]);
            }
            System.out.println();
        }

        time = System.nanoTime() - time;
        System.out.printf("\nelapsed time %4.3f ms\n", time/1_000_000.0);
    }
}