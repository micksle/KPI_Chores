package yearFIRST.termONE;

import java.util.Scanner;                                                       //імпортуємо необхідні для роботи бібліотеки

public class RgrTr12Kali {
    public static final String ANSI_PURPLE = "\u001B[35m";                      //імпортуємо колір для більш контрастного виводу
    public static final String ANSI_RESET = "\u001B[0m";                        //результатів на екран

    public static void main(String[] args) {
        Scanner scan = new Scanner(System.in);                                  //створюємо новий об'єкт класу сканер
        double[][] loop = { {1, 8, -5, 3, 10, 117.5  },                          //вводимо задану матрицю методом присвоєння
                {-3, 5, -3, 5, 5, 92.2   },
                {0, 2, -2, -1, -10, -91.7},
                {-6, -4, -3, -2, 5, 40.6 },
                {-6, 1, 10, -8, 8, 56.8  } };

        System.out.println(ANSI_PURPLE + "\n                RESULTS OF THE FIRST TASK:" + ANSI_RESET);   //виводимо результати першого завдання
        System.out.println("\n                    ⁘ initial matrix ⁘");                              //початкова матриця
        task13(loop);
        System.out.println("\n\n                    ⁘ triangular matrix ⁘");                          //трикутникова матриця
        task13(task11(loop));
        System.out.println("\n\n                    ⁘ vector-result matrix ⁘\n");                      //матриця-вектор результатів
        task14(task12(loop));

        System.out.println("\n\nEnter the natural values for the second task:");
        int a = scan.nextInt();                                                                       //скануємо значення для 2го завдання
        int b = scan.nextInt();
        int c = scan.nextInt();

        System.out.println(ANSI_PURPLE + "                RESULTS OF THE SECOND TASK:\n" + ANSI_RESET);    //виводимо результати другого завдання
        System.out.printf("for the first value [ %d ], the number of unpaired digits is: %d\n",a, task2(a));
        System.out.printf("for the second value [ %d ], the number of unpaired digits is: %d\n",b,task2(b));
        System.out.printf("for the third value [ %d ], the number of unpaired digits is: %d\n",c,task2(c));
    }

    public static double[][] task11(double[][]loop){                            //створюємо метод для обрахунку матриці методом Гауса
        double temp;
        int i = 1;
        do{
            for (int j = i; j < loop.length; j++) {
                temp = loop[j][i - 1] / loop[i - 1][i - 1];
                for (int k = 0; k < loop.length + 1; k++) {
                    loop[j][k] = loop[j][k] - temp * loop[i - 1][k];
                }
            }
            i++;
        } while (i < loop.length);
        return loop;                                                            //повертаємо матрицю в головний метод
    }

    public static double[] task12(double[][]loop){                              //створюємо метод для обрахунку матриці-вектору результатів
        double[] result = new double[loop.length];
        int i = loop.length-1;
        do{
            result[i] = loop[i][loop.length] / loop[i][i];
            for (int j = loop.length - 1; j > i; j--) {
                result[i] = result[i] - loop[i][j] * result[j] / loop[i][i];
            }
            i--;
        } while (i >= 0);
        return result;                                                                //повертаємо результат підрахунку трикутникової матриці
    }                                                                              //в головний метод

    public static void task13(double[][] loop) {                                    //створюємо метод для виводу результатів у консоль
        for (int i = 0; i < loop.length; i++) {
            System.out.println();
            for (int j = 0; j < loop[i].length; j++) {
                if (loop[i][j] % 1 == 0) {
                    System.out.printf("%-10.0f", loop[i][j]);
                } else {
                    System.out.printf("%-10.3f", loop[i][j]);
                }
            }
        }
    }

    public static void task14(double[] f) {                                         //створюємо метод для виводу результатів у консоль
        for (int i = 0; i < f.length; i++) {
            if (f[i] % 1 == 0) {
                System.out.printf("%-11.0f\t", f[i]);
            } else {
                System.out.printf("%-11.3f\t", f[i]);
            }
        }
    }

    public static int task2(int value) {                                              //створюємо метод для обрахунку другого завдання
        int quantity = 0;
        int i = 0;
        int[] array = new int [value];
        if (value > 0){
            while ( value > 0){
                array[i] = value%10;
                value=value/10;
                i++;
            }
        } else {
            return 0;
        }

        for (int j : array){                                                          //використовуємо цикл for each
            if (j%2 == 1){
                quantity++;
            }
        }

        return quantity;                                                               //повертаємо кількість цифр що є непарними
    }

}
