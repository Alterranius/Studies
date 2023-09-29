package Sort;

/**
 * @author Alterranius
 */
public class InsertionsSort {
    public static void sort(int[] arr, int low, int high) {
        int j, swap;
        for (int i = 1; i < arr.length; i++) {
            swap = arr[i];
            for (j = i; j > 0 && swap < arr[j - 1]; j--) {
                arr[j] = arr[j - 1];
            }
            arr[j] = swap;
        }
    }
}
