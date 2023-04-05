/**
 * list for the spare matrix with the representation of a list
 */

class ArrList {
    public int row;
    public int column;
    public int data;
    public ArrList next = null;

    public ArrList(int data) {
        this.data = data;
    }
}

public class Lr6_ArrayList {
    private ArrList head = null;

    public void add(int row, int column, int data) {
        ArrList insert = new ArrList(data);

        if (head == null) {
            head = insert;
        } else {
            ArrList list = head;
            while (list.next != null) {
                list = list.next;
            }
            list.next = insert;
        }
        insert.row = row;
        insert.column = column;
        insert.data = data;
        insert.next = null;
    }

    private int[] findMax(int length) {
        int[] maxValues = new int[length];
        ArrList list = head;
        int max = Integer.MIN_VALUE;
        int row = 0;

        while (list.next != null) {
            while (list.next != null && list.row == row) {
                if (list.data > max) {
                    max = list.data;
                }
                list = list.next;
            }
            maxValues[row] = max;
            max = Integer.MIN_VALUE;
            row++;
        }
        return maxValues;
    }

    public void toMainDiagonal(int length) {
        int[] maxValues = findMax(length);
        for (int i = 0; i < length; i++) {
            for (int j = 0; j < length; j++) {
                if (i == j) {
                    add(i, j, maxValues[i]);
                }
            }
        }
        print();
    }

    public int[][] finalArray(int length) {
        int[][] array = new int[length][length];
        ArrList list = head;

        while (list != null) {
            array[list.row][list.column] = list.data;
            list = list.next;
        }
        return array;
    }

    public void print() {
        printRows();
        printColumns();
        printData();
        System.out.println();
    }

    private void printRows() {
        ArrList row = head;
        System.out.print("row:    ");

        while (row != null) {
            System.out.printf("%3d ", row.row);
            row = row.next;
        }
    }

    private void printColumns() {
        ArrList column = head;
        System.out.print("\ncolumn: ");

        while (column != null) {
            System.out.printf("%3d ", column.column);
            column = column.next;
        }
    }

    private void printData() {
        ArrList data = head;
        System.out.print("\ndata:   ");

        while (data != null) {
            System.out.printf("%3d ", data.data);
            data = data.next;
        }
    }
}