import yearFIRST.termTWO.Stacks.STK;

public class Sr5 {
    public static void main(String[] args) {
        System.out.println("\n\tINITIAL STACK");
        STK<Integer> stack = new STK<>();
        stack.push(7);
        stack.push(-2);
        stack.push(4);
        stack.push(25);
        stack.push(3);
        stack.push(-3);
        stack.push(15);
        stack.push(0);
        stack.push(-14);

        stack.print();
        stack.size();

        System.out.println("\nreversing the stack");
        stack.reverse();
        stack.print();

        System.out.println("\nreversing the top and the bottom of the stack");
        stack.switchValues();
        stack.print();

        stack.peek();
        stack.pop();
        stack.pop();
        stack.pop();
        stack.print();
        stack.peek();

        System.out.println("\nsearching for the values");
        stack.search(-2);
        Integer n = stack.search(7);

        System.out.printf("\ninserting the value [%d] after the min value [", n);
//        stack.insertAfterMin(n);
        stack.print();
    }
}