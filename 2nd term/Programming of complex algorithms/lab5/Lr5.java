import java.util.Scanner;

public class Lr5 {
    public static final String ANSI_PURPLE = "\u001B[35m";
    public static final String ANSI_RESET = "\u001B[0m";

    public static void main(String[] args) {
        System.out.println(ANSI_PURPLE + "\n\tSingle-list implementation" + ANSI_RESET);
        SList SList = new SList();

        SList.insert(8);
        SList.insert(13);
        SList.insert(0);
        SList.insert(15);
        SList.insert(-3);
        SList.insert(0);
        SList.insert(-7);

        SList.print();
        SList.execution(keyValue());

        System.out.println(ANSI_PURPLE + "\n\t\tDouble-list implementation" + ANSI_RESET);
        DList DList = new DList();

        DList.insert(0);
        DList.insert(4);
        DList.insert(0);
        DList.insert(-2);
        DList.insert(12);
        DList.insert(0);
        DList.insert(47);
        DList.insert(-8);

        DList.print();
        DList.execution(keyValue());
    }

    public static int keyValue() {
        Scanner scan = new Scanner(System.in);
        System.out.print("\nenter the value you want to find: ");
        return scan.nextInt();
    }
}