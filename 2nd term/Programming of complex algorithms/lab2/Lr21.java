import java.util.Scanner;

public class Lr21 {
    public static void main(String[] args) {
        Scanner scan = new Scanner(System.in);
        System.out.print("enter the upper bound  ");
        int r = scan.nextInt();
        int k = 1;
        long time = System.nanoTime();

        System.out.printf("\nfor diapason from [%d] to [%d] sum is %.3f\n", k, r, recurs(k, r));
        time = System.nanoTime() - time;
        System.out.printf("recursion elapsed time %4.3f ms\n", time/1_000_000.0);

    }

    public static double recurs(int k, int r) {
        double sum = 0;
        double a = 2*r-1;
        double b = 2*r+1;
        double result = a/b;

        if (k > r) {
            return sum;
        } else {
            sum += result;
            return sum + recurs(k, r-1);
        }
    }

}