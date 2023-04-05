import java.util.Scanner;

/**
 * switching the values against extra diagonal
 */

public class Lr12 {
    public static void main(String[] args) {
        Scanner scan = new Scanner(System.in);
        System.out.print("enter the size of a matrix ");
        final int N = scan.nextInt();
        int min = 0, max = 30;

        if (N > 15){
            max = (int) Math.ceil(N*1.7);
        }

        int [][] array = new int [N][N];

        System.out.println("\tinitial matrix\n");
        for (int i = 0; i < N; i++) {
            for (int j = 0; j < N; j++) {
                array[i][j] = (int) (Math.random()*(max-min+1)+min);
                System.out.printf("%-3d\t", array[i][j]);
            }
            System.out.println();
        }

        System.out.println("\n\tfinal matrix\n");
        for (int i = 0, k = N - 1; i < N; i++, k--) {
            for (int j = 0, l = N - 1; l > i; j++, l--) {
                int temp = array[j][i];
                array[j][i] = array[k][l];
                array[k][l] = temp;
            }
        }

        for (int i = 0; i < N; i++) {
            for (int j = 0; j < N; j++) {
                System.out.printf("%-3d\t", array[i][j]);
            }
            System.out.println();
        }
    }
}