public class Lr6 {
    public static final String ANSI_PURPLE = "\u001B[35m";
    public static final String ANSI_RESET = "\u001B[0m";

    public static void main(String[] args) {
        System.out.println(ANSI_PURPLE + "\n\tINITIAL ARRAY" + ANSI_RESET);
        int[][] array = {{0, 2, -3, 0, 0}, {0, 0, 1, 4, -2, 1}, {-1, 0, 0, -6, -3}, {-2, 0, 6, 0, 0}, {0, -2, 7, 0, 3}};
        print(array);

        System.out.println(ANSI_PURPLE + "\n\tINITIAL SPARE MATRIX" + ANSI_RESET);
        Lr6_ArrayList list = getList(array);
        list.print();

        System.out.println(ANSI_PURPLE + "\n\tFINAL SPARE MATRIX" + ANSI_RESET);
        list.toMainDiagonal(array.length);

        System.out.println(ANSI_PURPLE + "\n\tFINAL ARRAY" + ANSI_RESET);
        array = list.finalArray(array.length);
        print(array);

        System.out.println();
        int[][] randomArray = randomArray(10);

        if (isSpare(randomArray)) {
            System.out.println("given random matrix is spare");
            System.out.println(ANSI_PURPLE + "\n\tINITIAL RANDOM ARRAY" + ANSI_RESET);
            print(randomArray);

            System.out.println(ANSI_PURPLE + "\n\tINITIAL SPARE RANDOM MATRIX" + ANSI_RESET);
            Lr6_ArrayList randomList = getList(randomArray);
            randomList.print();

            System.out.println(ANSI_PURPLE + "\n\tFINAL SPARE RANDOM MATRIX" + ANSI_RESET);
            randomList.toMainDiagonal(randomArray.length);

            System.out.println(ANSI_PURPLE + "\n\tFINAL RANDOM ARRAY" + ANSI_RESET);
            randomArray = randomList.finalArray(randomArray.length);
            print(randomArray);
        } else {
            System.out.println("given random matrix is not spare");
        }

    }

    public static Lr6_ArrayList getList(int[][] array) {
        Lr6_ArrayList list = new Lr6_ArrayList();
        for (int i = 0; i < array.length; i++) {
            for (int j = 0; j < array.length; j++) {
                if (array[i][j] != 0) {
                    list.add(i, j, array[i][j]);
                }
            }
        }
        return list;
    }

    public static int[][] randomArray(int length) {
        int[][] array = new int[length][length];
        int min = -10;
        int max = 15;
        int chance;
        int random;

        for (int i = 0; i < array.length; i++) {
            for (int j = 0; j < array.length; j++) {
                chance = (int) (Math.random() * (max - min + 1) + min);
                random = (int) (Math.random() * (max - min + 1) + min);
                if (random >= ( (chance * 2) - 4)) {
                    array[i][j] = random;
                }
            }
        }
        return array;
    }

    public static boolean isSpare(int[][] array) {
        boolean result = false;
        int zero = (array.length * array.length) / 2;
        int value = 0;
        for (int[] arr : array) {
            for (int j = 0; j < array.length; j++) {
                if (arr[j] != 0) value++;
            }
        }
        if (value > zero) {
            return true;
        }
        return result;
    }

    public static void print(int[][] array) {
        for (int[] arr : array) {
            for (int j = 0; j < array.length; j++) {
                System.out.printf("%4d", arr[j]);
            }
            System.out.println();
        }
    }
}