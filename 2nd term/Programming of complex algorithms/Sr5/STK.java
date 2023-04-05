package yearFIRST.termTWO.Stacks;

public class STK<T> {
    private Stack<T> top = null;

    public int search(T key) {
        Stack<T> stack = top;
        int index = 0;

        if (!isEmpty()) {
            while (stack != null) {
                if (stack.data == key) {
                    System.out.println("key [" + key + "] " + "was found at index " + (index + 1));
                    return index;
                }
                index++;
                stack = stack.next;
            }
            System.out.println("key [" + key + "] " + "was not found");
        } else {
            System.out.println("\nstack is empty");
        }
        return -1;
    }

    public void switchValues() {
        Stack<T> current = top;
        Stack<T> temp = top;
        Stack<T> previous = null;

        if (top == null || top.next == null) {
            return;
        }

        //After the loop, current will point to last element and index will point to second last element
        while (current.next != null) {
            previous = current;
            current = current.next;
        }

        //If list contains only two nodes, then swap the head node with current node
        if (top.next == current) {
            //head will point to last node i.e. current
            top = current;
            //node next to new head will be the last node
            top.next = temp;
            //Node next to last element will be null
            temp.next = null;
        } else {
            //head will point to last node i.e. current
            top = current;
            //Detach the list from previous head and add it after new head
            top.next = temp.next;
            //Previous head will become last node of the list
            previous.next = temp;
            //Node next to last element will be null
            temp.next = null;
        }
    }

    public void reverse() {
        if (top.next != null) {
            Stack<T> current = top.next;
            top.next = null;
            while (current != null) {
                Stack<T> next = current.next;
                current.next = top;
                top = current;
                current = next;
            }
        }
    }

//    public void insertAfterMin(int key) {
//        Stack stack = top;
//        Stack data = new Stack(key);
//        int min = minValue();
//
//        if (!isEmpty()) {
//            while (stack.data != min) {
//                stack = stack.next;
//            }
//
//            if (stack.next == null) {
//                stack.next = data;
//                stack.next.next = null;
//                return;
//            }
//
//            Stack prev = stack.next;
//            stack.next = data;
//            stack.next.next = prev;
//        } else {
//            System.out.println("\n\tstack is empty");
//        }
//    }

//    public int minValue() {
//        Stack count = top;
//        int min = top.data;
//
//        if (!isEmpty()) {
//            while (count != null) {
//                if (count.data < min) {
//                    min = count.data;
//                }
//                count = count.next;
//            }
//            System.out.println(min + "]");
//        }
//        return min;
//    }

    public void push(T data) {
        Stack<T> insert = new Stack<>(data);

        if (isEmpty()) {
            top = insert;
        } else {
            Stack<T> temp = top;
            top = insert;
            top.next = temp;
        }
    }

    public void pop() {
        if (isEmpty()) {
            System.out.println("\nunable to delete from the empty stack");
            return;
        }
        System.out.println("popping " + top.data);

        if (top.next == null) {
            top = null;
            return;
        }
        top = top.next;
    }

    public int size() {
        if (isEmpty()) {
            System.out.println("\nstack is empty");
            return -1;
        }
        Stack<T> stk = top;
        int size = 1;

        while (stk.next != null) {
            size++;
            stk = stk.next;
        }
        System.out.println("\nstack size is " + size);
        return size;
    }

    public void peek() {
        System.out.println("\ntop of the stack is " + top.data);
    }

    public boolean isEmpty() {
        return top == null;
    }

    public void print() {
        if (isEmpty()) {
            System.out.println("\nstack is empty");
            return;
        }
        Stack<T> stack = top;

        while (stack != null) {
            System.out.print(stack.data + "  ");
            stack = stack.next;
        }
        System.out.println();
    }
}