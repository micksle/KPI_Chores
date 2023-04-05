import yearFIRST.termTWO.Queues.*;

public class Sr6 {
    public static void main(String[] args) {
        System.out.println("\n\tINITIAL QUEUE");
        Que queue = new Que();

        queue.enqueue(7);
        queue.enqueue(-2);
        queue.enqueue(4);
        queue.enqueue(25);
        queue.enqueue(0);
        queue.enqueue(-3);
        queue.enqueue(15);

        queue.print();

        System.out.println("\ndeleting the key value");
        queue.deleteAt(15);
        queue.print();

        System.out.println("\nqueue after dequeueing");
        queue.dequeue();
        queue.dequeue();
        queue.print();


        System.out.println("\n\n\tINITIAL ARRAY QUEUE");
        ArrayQueue arrQueue = new ArrayQueue(9);
        arrQueue.enqueue(11);
        arrQueue.enqueue(12);
        arrQueue.enqueue(-3);
        arrQueue.enqueue(0);
        arrQueue.enqueue(52);
        arrQueue.enqueue(6);
        arrQueue.enqueue(-18);
        arrQueue.enqueue(1);
        arrQueue.enqueue(24);

        arrQueue.print();

        System.out.println("\nqueue after dequeueing");
        arrQueue.dequeue();
        arrQueue.dequeue();
        arrQueue.print();

        System.out.println("\ndeleting the key value");
        arrQueue.deleteAt(-3);
        arrQueue.print();
    }
}