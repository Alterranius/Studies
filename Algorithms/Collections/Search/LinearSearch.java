package Search;

import java.util.Map;

/**
 * @author Alterranius
 */
public class LinearSearch<T> implements Search<T> {
    @Override
    public Map.Entry<Integer, ? extends T> search(T[] in, T element) {
        for (int i = 0; i < in.length; i++) {
            if (in[i].equals(element)) {
                return Map.entry(i, in[i]);
            }
        }
        return null;
    }
}
