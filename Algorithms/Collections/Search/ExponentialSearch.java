package Search;

import java.util.Arrays;
import java.util.Map;

/**
 * @author Alterranius
 */
public class ExponentialSearch<T extends Comparable<T>> implements Search<T> {
    @Override
    public Map.Entry<Integer, ? extends T> search(T[] in, T element) {
        int range = 1;
        while (range < in.length && element.compareTo(in[range]) >= 0) range <<= 2;
        return new BinarySearch<T>().search(Arrays.copyOfRange(in, range / 2, Math.min(range, in.length)), element);
    }
}
