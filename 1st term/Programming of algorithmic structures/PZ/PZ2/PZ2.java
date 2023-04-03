package yearFIRST.termONE;

import java.util.Scanner;
import static java.lang.Math.*;

public class Pz2 {
    public static void main(String[] args) {
        Scanner scan = new Scanner(System.in);

        System.out.println("\n\t\tfirst exercise");
        System.out.println("enter the number: ");
        int n = scan.nextInt();
        System.out.println("the difference between the value you entered and 21 is: " + diff21(n));

        System.out.println("\n\t\tsecond exercise");
        System.out.println("the value you entered is in the range [90, 110] or [190, 210]: " + nearHundred(n));

        System.out.println("\n\t\tthird exercise");
        System.out.println("is it possible for you to sleep long? " + sleepIn(true, true));

        System.out.println("\n\t\tfourth exercise");
        System.out.println("enter 3 numbers");
        int a = scan.nextInt();
        int b = scan.nextInt();
        int c = scan.nextInt();
        if (isInRange(a, b, c)) {
            System.out.println("at least one of the numbers is in the range [13,19]: " + isInRange(a, b, c));
        } else {
            System.out.println("no number is in the range [13,19]");
        }

        System.out.println("\n\t\tfifth exercise");
        int x = (int) (random() * 20);
        int y = (int) (random() * 20);
        System.out.println("value among random " + x + " and " + y + " closest to 10 is: " + close10(x, y));

    }

    public static int diff21(int n) {
        if (n > 21) {
            return (n - 21) * 2;
        } else {
            return 21 - n;
        }
    }

    public static boolean nearHundred(int n) {
        if (n >= 90 && n <= 110 || 190 <= n & n <= 210) {
            return true;
        } else {
            return false;
        }
    }

    public static boolean sleepIn(boolean weakday, boolean vacation) {
        return !weakday | vacation;
    }

    public static boolean isInRange(int a, int b, int c) {
        if (a >= 13 && a <= 19) {
            return true;
        } else if (b >= 13 && b <= 19) {
            return true;
        } else if (c >= 13 && c <= 19) {
            return true;
        } else {
            return false;
        }
    }

    public static int close10(int x, int y) {
        if (abs(x - 10) > abs(y - 10)) {
            return y;
        } else if (abs(y - 10) > abs(x - 10)) {
            return x;
        } else {
            return x;
        }
    }
}
