import java.util.Scanner;
import static java.lang.Math.*;

public class Sr1 {
    public static void main(String[] args) {
        Scanner scan = new Scanner(System.in);
        double y;
        for (int i = 0; i < 5; i++) {
            System.out.println("\nEnter thr value for x:");
            double x = scan.nextDouble();

            double result = count(x);

            if (result % 1 == 0) {
                System.out.printf("The result for y is [%.0f]\n", result);
            } else {
                System.out.printf("The result for y is [%.3f]\n", result);
            }
        }

    }

    public static double count(double x) {
        double y;
        if (x <= -4) y = pow(x, 2) - 8*x;
        else if (x >= 0) y = 2-x;
        else y = 3*x - 2;
        return y;
    }

}
