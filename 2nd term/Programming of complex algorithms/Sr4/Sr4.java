import java.text.DecimalFormat;

public class Sr4 {
    public static void main(String[] args) {
        System.out.println("\n\tTASK 1");
        task1();
        System.out.println("\n\n\tTASK 2");
        task2();
    }

    public static void task1() {
        int[] array = new int[16];
        int max = 78, min = -12;
        long mult = 1;
        int sum = 0;

        System.out.println("\n\t\tINITIAL ARRAY");
        for (int i = 0; i < array.length; i++) {
            array[i] = (int) (Math.random() * (max - min + 1) + min);
            System.out.printf("%3d,", array[i]);
            if (i < 10) mult *= array[i];
            else sum+= array[i];
        }
        printMult(mult);
        System.out.println("the sum of the remaining units is [" + sum + "]");
    }

    public static void task2() {
        int[][] array = new int[5][5];
        int max = 78, min = -12;
        int sum = 0;

        System.out.println("\n\tINITIAL ARRAY");
        for (int i = 0; i < array.length; i++) {
            for (int j = 0; j < array.length; j++) {
                array[i][j] = (int) (Math.random() * (max - min + 1) + min);
                System.out.printf("%4d", array[i][j]);
                if (i == j) sum += array[i][j];
            }
            System.out.println();
        }
        System.out.println("\nthe sum of units placed on the main diagonal is [" + sum + "]");
    }

    public static void printMult(long mult) {
        String result;
        if (mult == 0) {
            result = "0";
        } else {
            result = new DecimalFormat("#000,000,000").format(mult);
        }
        System.out.println("\n\nthe multiplication of the first 10 units is [" + result + "]");
    }
}