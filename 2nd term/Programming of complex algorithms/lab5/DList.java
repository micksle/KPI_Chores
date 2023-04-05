class DoubleList {
    public int data;
    public DoubleList next;
    public DoubleList previous;


    public DoubleList(int data) {
        this.data = data;
        next = null;
        previous = null;
    }
}

public class DList {
    private DoubleList head = null;
    private DoubleList tail = null;

    public void execution(int key) {
        findKey(key);
        int length = print();
        System.out.println("\nmoving zero-value elements to the right");
        transferZeros(length);
    }

    public void transferZeros(int length) {
        DoubleList list = head;
        int counter = 0;

        while (counter != length) {
            if (list.data == 0) {
                delete(list.data);
                insert(list.data);
            }
            counter++;
            list = list.next;
        }
        print();
    }

    public void findKey(int key) {
        int index = find(key);
        if (index != -1) {
            System.out.println("key [" + key + "] " + "was found at index " + (index + 1));
            delete(key);
        } else {
            System.out.println("key [" + key + "] " + "was not found");
        }
    }

    public int find(int key) {
        DoubleList list = head;
        int index = -1;

        while (list != null) {
            index++;
            if (list.data == key) {
                return index;
            }
            list = list.next;
        }
        return -1;
    }

    public void delete(int key) {
        if (head.data == key) {
            head = head.next;
            head.next.previous = null;
            return;
        }
        DoubleList list = head;

        while (list.next.next != null) {
            if (list.next.data == key) {
                list.next = list.next.next;
                list.next.previous = list.previous;
                return;
            }
            list = list.next;
        }

        if (tail.data == key) {
            tail.previous.next = null;
            tail = tail.previous;
            tail.next = null;
        }
    }

    public void insert(int data) {
        DoubleList insert = new DoubleList(data);

        if (head == null) {
            head = insert;
        } else {
            tail.next = insert;
            insert.previous = tail;
        }
        tail = insert;
        tail.next = null;
    }

    public int print() {
        DoubleList list = head;
        int length = 0;

        while (list != null) {
            System.out.print(list.data + "\t");
            length++;
            list = list.next;
        }
        System.out.println();
        return length;
    }
}