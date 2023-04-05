import java.util.ArrayList;
import java.util.Scanner;

public class Sr2 {
    public static void main(String[] args) {
        Scanner scan = new Scanner(System.in);
        ArrayList<String> list = new ArrayList<>();
        list.add("some");
        list.add("words");
        list.add("to");
        list.add("find");
        System.out.print("enter the searching string key: ");
        String sKey = scan.next();
        linearSearch(list, sKey);
        if (linearSearch(list, sKey) != -1){
            System.out.println("the string key is found at index " + linearSearch(list, sKey));
        } else {
            System.out.println("the string key was not found");
        }
        System.out.println();

        int[] arr = {3, -2, 17, 27, 0, -67, 2};
        System.out.print("enter the searching number key: ");
        int dKey = scan.nextInt();
        linearSearch(arr, dKey);
        if (linearSearch(arr, dKey) != -1){
            System.out.println("the number key is found at index " + linearSearch(arr, dKey));
        } else {
            System.out.println("the number key was not found");
        }
    }

    public static int linearSearch(int[] arr, int dKey) {
        for (int i = 0; i < arr.length; i++) {
            if (arr[i] == dKey) {
                return i;
            }
        }
        return -1;
    }

    public static int linearSearch(ArrayList list, String sKey) {
        for (int i = 0; i < list.size(); i++) {
            if (list.contains(sKey)) {
                return list.indexOf(sKey);
            }
        }
        return -1;
    }
}
