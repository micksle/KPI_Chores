package yearFIRST.termTWO.Stacks;

public class Stack<T> {
    public T data;
    public Stack<T> next;


    public Stack(T data) {
        this.data = data;
        next = null;
    }
}