package yearFIRST.termTWO.Queues;

/**
 *  queue in representation of the matrix, not list
 */

public class ArrayQueue {
    private int[] queue;
    private final int length;
    private int n;
    private int front;
    private int rear;

    public ArrayQueue(int length) {
        this.length = length;
        queue = new int[length];
        front = 0;
        n = 0;
        rear = -1;
    }

    public void enqueue(int data) {
        if (isFull()) {
            System.out.printf("unable to enqueue [%d], queue is full\n", data);
            return;
        }

        rear = (rear + 1) % length;
        queue[rear] = data;
        n++;
    }

    public void dequeue() {
        if (isEmpty()) {
            System.out.println("queue is empty");
            return;
        }
        n--;
        front %= length;
        queue[front] = queue[front++];
    }

    public void deleteAt(int key) {
        int index = info(key)-1;
        if (index == -1) {
            return;
        }
        int[] arr = new int[n];
        int j = front;

        for (int i = 0; i < arr.length; i++) {
            if (i == index) {
                j++;
                continue;
            }
            arr[i] = queue[j];
            j++;
        }

        j = front;
        for (int i = 0; i < arr.length-1; i++) {
            if (j == index) {
                j++;
                continue;
            }
            queue[j] = arr[i];
            j++;
        }
    }

    public int info(int key) {
        int i = front;
        int index = 1;

        while (!isEmpty() && i <= n+1) {
            System.out.println(i);
            if (queue[i] == key) {
                System.out.println("\nkey [" + key + "] " + "was found at index " + index);
                return index;
            }
            index++;
            i++;
        }
        System.out.println("\nkey [" + key + "] " + "was not found");
        return -1;
    }

    public boolean isFull() {
        return n == length;
    }

    public boolean isEmpty() {
        return n == 0;
    }

    public void print() {
        if (isEmpty()) {
            System.out.println("\nqueue is empty");
            return;
        }
        int i = front;

        while (i != rear) {                     //i != n ||
            System.out.print(queue[i] + "  ");
            i = (i + 1) % length;
        }
        System.out.println(queue[i] + "\n");
    }
}