package Sort;

/**
 * @author Alterranius
 */
public class QuickSort {
    public static void sort(int[] arr, int low, int high) {
        if (arr.length == 0 || low >= high) return;
        int i = low, j = high;
        int pivot = arr[(i + j) / 2];
        while (i <= j) {
            while (arr[i] < pivot) i++;
            while (arr[j] > pivot) j--;
            if (i <= j) {
                int temp = arr[i];
                arr[i] = arr[j];
                arr[j] = temp;
                i++;
                j--;
            }
        }
        if (low < j) sort(arr, low, j);
        if (high > i) sort(arr, i, high);
    }
}
