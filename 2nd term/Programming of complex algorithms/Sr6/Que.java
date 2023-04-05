package yearFIRST.termTWO.Queues;

public class Que {
    private Queue head = null;
    private Queue tail = null;

    public void enqueue(int data) {
        Queue queue = new Queue(data);

        if (isEmpty()) {
            head = queue;
        } else {
            tail.next = queue;
        }
        tail = queue;
        tail.next = null;
    }

    public void dequeue() {
        if (isEmpty()) {
            return;
        }
        if (head == tail) {
            head = null;
            tail = null;
            return;
        }
        if (head.next != null) {
            head = head.next;
        }
    }

    public void deleteAt(int key) {
        int index = info(key);
        if (index == -1) {
            return;
        }

        Que temp = new Que();       //temporary queue for storing elements before the deleted one
        Queue smt = head;           // represents the data that enqueues

        while (smt != null) {
            if (smt.data == key) {
                smt = smt.next;
                continue;
            }
            temp.enqueue(smt.data);
            dequeue();
            smt = smt.next;
        }
        dequeue();

        smt = temp.head;
        while (smt != null) {
            enqueue(smt.data);
            temp.dequeue();
            smt = smt.next;
        }
    }

    public int info(int key) {
        Queue queue = head;
        int index = 1;

        while (!isEmpty() && queue != null) {
            if (queue.data == key) {
                System.out.println("\nkey [" + key + "] " + "was found at index " + index);
                return index;
            }
            index++;
            queue = queue.next;
        }
        System.out.println("\nkey [" + key + "] " + "was not found");
        return -1;
    }

    public boolean isEmpty() {
        return head == null;
    }

    public void print() {
        if (isEmpty()) {
            System.out.println("\nqueue is empty");
            return;
        }
        Queue queue = head;

        while (queue != null) {
            System.out.print(queue.data + "  ");
            queue = queue.next;
        }
        System.out.println();
    }
}