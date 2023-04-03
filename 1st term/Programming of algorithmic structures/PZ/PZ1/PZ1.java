package yearFIRST.termONE;

import java.util.Scanner;

public class Pz1 {
    public static void main(String[] args) {
        Scanner scan = new Scanner(System.in);

        System.out.println("\n       First exercise");
        int x = 20*(1/3)+158*158;
        System.out.println("The result for x is:"+x);

        System.out.println("\n       Second exercise");
        System.out.println("Enter a double digit:");
        float n = scan.nextFloat();
        int n1 = (int) Math.ceil(n);
        System.out.println("Digit "+n+" has rounded into "+n1);

        System.out.println("\n       Third exercise");
        System.out.println("Enter a three-digit number:");
        int t = scan.nextInt();
        int c = t%10;
        int b = t/10%10;
        int a = t/100%10;
        System.out.println("The sum of the digits is: "+(a+b+c));

    }
}
