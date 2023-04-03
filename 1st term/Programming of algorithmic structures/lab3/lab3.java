package yearFIRST.termONE;

import static java.lang.Math.*;
import java.util.Arrays;
import java.util.Scanner;

public class Lr3 {
    public static final String ANSI_PURPLE = "\u001B[35m";
    public static final String ANSI_RESET = "\u001B[0m";

    public static void main(String[] args) {
        Scanner scan = new Scanner(System.in);
        float step = 0.2f;
        float min = 0;
        float max = 7;
        System.out.println(ANSI_PURPLE+"    Results of the first task:"+ANSI_RESET);
        task1(step, min, max);

        double [] first = {-2, 6, -12, 20, -30, 42, -56, 72, -90, 110, -132, 156};                     //послідовність виду pow(-1, i)*(i*i+i);
        double [] second = {0.33, -0.25, 0.2, -0.166, 0.142, -0.125, 0.11, -0.1, 0.0909, -0.0833};    //послідовність виду (pow(-1, i+1))/(i+2);
        System.out.println(ANSI_PURPLE+"\n    Results of the second task:"+ANSI_RESET);
        System.out.printf("For the first array %s the doubled sum of paired digits is %.4f\n", Arrays.toString(first), task2(first));
        System.out.printf("For the second array %s the doubled sum of paired digits is %.4f\n", Arrays.toString(second), task2(second));

        System.out.println("\nEnter the values for x");
        double x1 = scan.nextDouble();
        double x2 = scan.nextDouble();
        System.out.println(ANSI_PURPLE+"    Results of the third task:"+ANSI_RESET);
        System.out.printf("         ⁘ x = %.1f ⁘\n", x1);
        task3(x1);
        System.out.printf("         ⁘ x = %.1f ⁘\n", x2);
        task3(x2);
    }

    public static void task1(float step, float min, float max) {
        double z, y;
        float x = min;
        System.out.println("   |  x   |    y    |    z    |");
        do {
            z = cos((x + 2 * Math.PI) * pow(Math.E, x));
            y =  Math.log10(x/2 + 0.1);
            System.out.println("   |——————————————————————————|");
            System.out.printf("   | %.1f  | %7.4f | %7.4f |\n", x, y, z);
            x += step;
        } while (x < max-min);
        System.out.println("   ————————————————————————————");

    }

    public static double task2(double []arr){
        double z = 0, sum = 0;
        for ( int i = 0; i < arr.length; i++){
            if(arr[i]>0){
                z += arr[i];
                sum = z * 2;
            } else {
                arr[i] = 0;
            }
        }
        return sum;
    }

    public static void task3(double x){
        double fact = 1;
        for (int k = 1; k < 6; k++){
            fact *= k;
            double y = (pow(x, k+2))/(fact);
            System.out.printf("     for k [ %d ] y is %.4f\n",k ,y);
        }
    }
}
