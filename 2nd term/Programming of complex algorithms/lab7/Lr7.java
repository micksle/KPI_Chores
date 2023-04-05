public class Lr7 {
    public static final String ANSI_PURPLE = "\u001B[35m";
    public static final String ANSI_RESET = "\u001B[0m";

    public static void main(String[] args) {
        System.out.println(ANSI_PURPLE + "\n\tINITIAL TREE" + ANSI_RESET);
        BinaryTree tree = fillTree();
        tree.print();

        System.out.println("\n\n\tascending bypass of the tree:");
        tree.printPostOrder();

        tree.isAlmostComplete();

        System.out.println(ANSI_PURPLE + "\n\tSECOND INITIAL TREE" + ANSI_RESET);
        BinaryTree secondTree = fillSecondTree();
        secondTree.print();

        System.out.println("\n\n\tascending bypass of the tree:");
        secondTree.printPostOrder();

        secondTree.isAlmostComplete();
    }

    public static BinaryTree fillTree() {
        BinaryTree tree = new BinaryTree();
        tree.put(17);
        tree.put(13);
        tree.put(19);
        tree.put(2);
        tree.put(1);
        tree.put(60);
        tree.put(9);
        tree.put(14);
        tree.put(25);
        tree.put(81);
        return tree;
    }

    public static BinaryTree fillSecondTree() {
        BinaryTree tree = new BinaryTree();
        tree.put(8);
        tree.put(4);
        tree.put(16);
        tree.put(6);
        tree.put(3);
        tree.put(9);
        tree.put(0);
        return tree;
    }
}