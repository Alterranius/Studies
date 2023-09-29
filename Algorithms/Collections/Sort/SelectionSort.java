package Sort;

/**
 * @author Alterranius
 */
public class SelectionSort {
    public static void sort(int[] arr, int low, int high) {
        int pos, min;
        for (int i = 0; i < arr.length; i++) {
            pos = i;
            min = arr[i];
            for (int j = i + 1; j < arr.length; j++) {
                if (arr[j] < min) {
                    pos = j;
                    min = arr[j];
                }
            }
            arr[pos] = arr[i];
            arr[i] = min;
        }
    }
}