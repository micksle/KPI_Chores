package yearFIRST.termONE;

import java.util.Scanner;
import static java.lang.Math.*;

public class MKR {
    public static final String ANSI_PURPLE = "\u001B[35m";
    public static final String ANSI_RESET = "\u001B[0m";

    public static void main(String[] args) {
        Scanner scan = new Scanner(System.in);
        System.out.println("\n\tEnter the first word:");
        String str1 = scan.nextLine();
        System.out.println("What`s the quantity of the repetitions?");
        int n1 = scan.nextInt();
        String result1 = frontTimes(str1, n1);
        System.out.println("\tEnter the second word:");
        String str2 = scan.next();
        System.out.println("What`s the quantity of the repetitions?");
        int n2 = scan.nextInt();
        String result2 = frontTimes(str2, n2);
        System.out.println("\tEnter the third word:");
        String str3 = scan.next();
        System.out.println("What`s the quantity of the repetitions?");
        int n3 = scan.nextInt();
        String result3 = frontTimes(str3, n3);
        System.out.println();
        System.out.println(ANSI_PURPLE+"\tResults of the first task:"+ANSI_RESET);
        System.out.println("first modified word is "+result1);
        System.out.println("first modified word is "+result2);
        System.out.println("first modified word is "+result3);

        double x = 0.6;
        System.out.println(ANSI_PURPLE+"\tResults of the second task:"+ANSI_RESET);
        System.out.printf("for x = %.1f sum is [%.4f]\n", x, task2(x));
    }

    public static String frontTimes(String str, int n) {
        String result = "";
        if (n<0){
            String error = "Quantity of the repetitions must be positive number";
            return error;
        } else if (n==0){
            return str;
        }

        if (str.length() > 3) {
            String copy = str.substring(0, 3);
            for (int i = 0; i < n; i++) {
                String body = result;
                result = copy + body;
            }
        } else {
            String copy = str;
            for (int i = 0; i < n; i++) {
                String body = result;
                result = copy + body;
            }
        }
        return result;
    }

    public static double task2(double x){
        double fact = 1;
        double sum = 0;
        for (int k = 1; k < 6; k++){
            fact *= k;
            if (k==3){
                continue;
            }
            double y = (pow(-1, k) * pow((x + 3), k + 2) / (fact));
            sum += y;
        }
            return sum;
        }
}
