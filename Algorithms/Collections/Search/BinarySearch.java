package Search;

import java.util.Map;

/**
 * @author Alterranius
 */
public class BinarySearch<T extends Comparable<T>> implements Search<T> {
    @Override
    public Map.Entry<Integer, ? extends T> search(T[] sortedIn, T element) {
        int low = 0;
        int high = sortedIn.length - 1;
        int mid;
        while (low <= high) {
            mid = low + (high - low) / 2;
            if (sortedIn[mid].equals(element)) return Map.entry(mid, element);
            if (element.compareTo(sortedIn[mid]) > 0) {
                low = mid + 1;
            } else {
                high = mid - 1;
            }
        }
        return null;
    }
}
