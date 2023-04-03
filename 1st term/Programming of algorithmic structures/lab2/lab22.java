package yearFIRST.termONE;

import java.util.Scanner;
import static java.lang.Math.*;

public class Lr22 {
    public static final String ANSI_PURPLE = "\u001B[35m";
    public static final String ANSI_RESET = "\u001B[0m";

    public static void main(String[] args) {
        Scanner scan = new Scanner(System.in);
        System.out.println("Enter a:");
        double a = scan.nextDouble();
        System.out.println("Enter b:");
        double b = scan.nextDouble();
        System.out.println("Enter c:");
        double c = scan.nextDouble();

        System.out.println(ANSI_PURPLE + "      Results of the third task:" + ANSI_RESET);
        System.out.println(task3(a, b, c));

        System.out.println(ANSI_PURPLE + "      Results of the fourth task:" + ANSI_RESET);
        System.out.println(task4());
    }

    public static double task3(double a, double b, double c) {
        double p = (a + b + c) / 2;
        double minValue;
        if (a<=0 || b<=0 || c<=0) {
            System.out.println("Error. The sides of triangle must be positive and the sum of two sides must be more than the last one");
            return 0;
        }
        if (a <= b && a <= c) {
            minValue = a;
        } else if (b <= a && b <= c) {
            minValue = b;
        }  else {
            minValue = c;
        }

        double squareCube = pow(minValue, 2);
        double squareTriangle = sqrt(p * (p - a) * (p - b) * (p - c));

        if (squareCube > squareTriangle) {
            System.out.println("The cube has bigger square:");
            return squareCube;
        } else if (squareTriangle > squareCube) {
            System.out.println("The triangle has bigger square:");
            return squareTriangle;
        } else {
            System.out.println("Error. The sides of triangle must be positive and the sum of two sides must be more than the last one");
            return 0;
        }
    }


    public static String task4() {
        double[][] loop = {{3, 5, 4},
                {13, 8, 11},
                {10, 5, 12}};
        for(int i=0;i<3;i++) {
            double p = (loop[i][0]+loop[i][1]+loop[i][2])/2;
            double triangleSquare = sqrt(p * (p - loop[i][0]) * (p - loop[i][1]) * (p - loop[i][2]));
            double minSide;
            if(loop[i][0] <= loop[i][1] && loop[i][0]<= loop[i][2]){
                minSide = loop[i][0];
            } else if (loop[i][1]<= loop[i][0] && loop[i][1]<= loop[i][2]){
                minSide = loop[i][1];
            } else {
                minSide = loop[i][2];
            }
            double cubeSquare = pow(minSide,2);

            if(triangleSquare>cubeSquare){
                System.out.println("Triangle`s square is bigger than cubic`s square");
            } else{
                System.out.println("Cubic`s square is bigger than triangle`s square");
            }

        }
        return "";
    }
}
