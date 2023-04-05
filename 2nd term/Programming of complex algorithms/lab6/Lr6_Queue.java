import java.util.Iterator;

class Lr6_Que<Item> {
    public Item data;
    public Lr6_Que<Item> next;

    public Lr6_Que(Item data) {
        this.data = data;
        next = null;
    }
}

    public class Lr6_Queue<Item> implements Iterable<Item> {
        private Lr6_Que<Item> head = null;
        private Lr6_Que<Item> tail = null;

        public void enqueue(Item data) {
            Lr6_Que<Item> insert = new Lr6_Que<>(data);

            if (isEmpty()) {
                head = insert;
            } else {
                tail.next = insert;
            }
            tail = insert;
            tail.next = null;
        }

        public Item dequeue() {
            if (isEmpty()) {
                return null;
            }
            Item temp = head.data;

            if (head == tail) {
                head = null;
                tail = null;
                return temp;
            }
            if (head.next != null) {
                head = head.next;
                return temp;
            }
            return null;
        }

        public boolean isEmpty() {
            return head == null;
        }

        public Iterator<Item> iterator()  {
            return new QueueIterator<>(head);
        }

        private static class QueueIterator<Item> implements Iterator<Item> {
            private Lr6_Que<Item> current;

            public QueueIterator(Lr6_Que<Item> head) {
                current = head;
            }

            public boolean hasNext()  {
                return current != null;
            }

            public Item next() {
                if (!hasNext()) {
                    return null;
                }
                Item temp = current.data;
                current = current.next;
                return temp;
            }
        }
    }
