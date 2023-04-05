import java.util.Scanner;

public class Lr22 {
    public static void main(String[] args) {
        Scanner scan = new Scanner(System.in);
        System.out.print("enter the upper bound  ");
        int r = scan.nextInt();
        int k = 1;
        long time = System.nanoTime();

        System.out.printf("for diapason from [%d] to [%d] sum is %.3f\n", k, r, noRec(r, k));

        time = System.nanoTime() - time;
        System.out.printf("\nno recursion elapsed time %4.3f ms\n", time/1_000_000.0);
    }

    public static double noRec(int k, int r) {
        double sum = 0;
        double a;
        double b;
        double result;

        for (k = k; k >= r; k--){
            a = 2*k-1;
            b = 2*k+1;
            result = a/b;
            sum += result;
        }
        return sum;
    }
}