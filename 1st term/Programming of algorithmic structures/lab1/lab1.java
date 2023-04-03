package yearFIRST.termONE;

import java.util.*;
import static java.lang.Math.*;

public class Lr1 {
    public static final String ANSI_PURPLE = "\u001B[35m";
    public static final String ANSI_RESET = "\u001B[0m";

    public static void main(String[] args) {
        Scanner scan = new Scanner(System.in);
        double a=-0.5, b = 1.7, t = 0.44;
        double r = calcR(b,t,a);
        double s = calcS(b,t,a);

        System.out.println(ANSI_PURPLE+"\n\t\tResults of the task"+ANSI_RESET);
        System.out.printf("For a [%.1f]\tb [%.1f] \tt [%.2f] \n y is [%.4f] \tz is [%.4f]\n", a, b, t, r, s);
        System.out.println("Enter the values for a, b and t");
        a = scan.nextDouble();
        b = scan.nextDouble();
        t = scan.nextDouble();
        r = calcR(b,t,a);
        s = calcS(b,t,a);
        System.out.printf("For a [%.1f]\tb [%.1f] \tt [%.2f] \n y is [%.4f] \tz is [%.4f]\n", a, b, t, r, s);
        outputDate();
    }

    public static double calcR(double b, double t, double a) {
        double y = pow(E, -b*t)*sin(a*t+b)-sqrt(abs(b*t+a));
        return y;
    }

    public static double calcS(double b, double t, double a) {
        double s = b*sin(a*pow(t, 2)*cos(2*t))-1;
        return s;
    }

    public static void outputDate(){
        Date date = new Date();
        System.out.printf("\nToday`s date is %1$te %1$tB %1$tY\n", date);
    }
}
