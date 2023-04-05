class SingleList {
    public int data;
    public SingleList next;

    public SingleList(int data) {
        this.data = data;
        next = null;
    }
}

public class SList {
    private SingleList head = null;

    public void execution(int key) {                                // main (driver) method for the task
        findKey(key);
        int length = print();
        System.out.println("\nmoving zero-value elements to the right");
        transferZeros(length);
    }

    public void transferZeros(int length) {
        SingleList list = head;
        int counter = 0;

        while (counter != length) {
            if (list.data == 0) {
                insert(list.data);
                delete(list.data);
            }
            counter++;
            list = list.next;
        }
        print();
    }

    public void reverse(int m, int n) {                                 // reversing the values before and after the pivot
        SingleList prevM = null, prevN = null;
        SingleList curM = head, curN = head;

        int counterM = 0;
        while (curM != null && counterM != m) {
            prevM = curM;
            counterM++;
            curM = curM.next;
        }

        int counterN = 0;
        while (curN != null && counterN != n) {
            prevN = curN;
            counterN++;
            curN = curN.next;
        }

        if (curM != null && curN != null) {
            //If previous node to node1 is not null then, it will point to node2
            if (prevM != null) {
                prevM.next = curN;
            } else {
                head = curN;
            }

            if (prevN != null) {
                prevN.next = curM;
            } else {
                head = curM;
            }

            SingleList temp = curM.next;
            curM.next = curN.next;
            curN.next = temp;
        }
    }

    public void findKey(int key) {
        int index = find(key);
        if (index != -1) {
            System.out.println("key [" + key + "] " + "was found at index " + (index + 1));
            delete(key);                                                // deleting given key
            reverse(index - 1, index);                              // reversing values
        } else {
            System.out.println("key [" + key + "] " + "was not found");
        }
    }

    public int find(int key) {
        SingleList list = head;
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
            return;
        }
        SingleList list = head;

        while (list.next != null) {
            if (list.next.data == key) {
                list.next = list.next.next;
                return;
            }
            list = list.next;
        }
    }

    public void insert(int data) {
        SingleList insert = new SingleList(data);

        if (head == null) {
            head = insert;
        } else {
            insert.next = null;
            SingleList list = head;

            while (list.next != null) {
                list = list.next;
            }
            list.next = insert;
        }
    }


    public int print() {
        SingleList list = head;
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