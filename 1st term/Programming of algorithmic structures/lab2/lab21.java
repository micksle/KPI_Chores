package yearFIRST.termONE;

import static java.lang.Math.*;

public class Lr21 {
    public static final String ANSI_PURPLE = "\u001B[35m";
    public static final String ANSI_RESET = "\u001B[0m";
    public static void main(String[] args) {
        double x1 = -2.3;
        double x2 = 0.6;
        double x3 = 4.8;
        System.out.println();

        System.out.println(ANSI_PURPLE+"    Results of the first task:"+ANSI_RESET);
        System.out.printf("For the first x (%.1f):%n",x1);
        task1(x1);
        System.out.printf("For the second x (%.1f):%n",x2);
        task1(x2);
        System.out.printf("For the third x (%.1f):%n",x3);
        task1(x3);

        System.out.println();
        System.out.println(ANSI_PURPLE+"    Results of the second task:"+ANSI_RESET);
        System.out.printf("For the first x (%.1f):%n",x1);
        task2(x1);
        System.out.printf("For the second x (%.1f):%n",x2);
        task2(x2);
        System.out.printf("For the third x (%.1f):%n",x3);
        task2(x3);
    }

    public static void task1 (double x){
        double y;
        double a = 0.7;
        double b = -1.25;
        double z = 3.5;
        if (x<a) {
            y=2.8*pow(sin(a*x),2) - b* pow(x,3) * z;
        } else if (x>b*b) {
            y=pow(E,abs(2.5*a*x) + z*a*b*x);
        } else {
            y=z*pow(cos(a*x+b),2);
        }
        System.out.printf("%20.4f%n",y);
    }

    public static void task2(double x) {
        double y;
        double[] first = {0.1, 1.2, 2.5};
        double[] second = {0.5, 2.5, 1.2};
        double[] third = {pow(E, 2.5 * first[0] *x), pow(E, 2.5 * first[1] *x), pow(E, 2.5 * first[2] *x)};

        for (int i = 0; i < 3; i++) {
            if (x < first[i]){
                y = 3.5 * pow( pow(sin(second[i] * x + third[i]), 3), 2) - pow( E, 3.5* first[i]);
            } else if (x > pow( second[i], 2.5)){
                y = pow( cos(pow(first[i], second[i]) + x * third[i]), 2) + pow( first[i], 2);
            } else {
                y = log(first[i] + pow(second[i], 3) * x) + first[i];
            }
            System.out.printf("%20.4f%n",y);
        }

    }

}
