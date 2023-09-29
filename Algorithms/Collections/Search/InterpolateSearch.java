package Search;

import java.util.Map;
import java.util.Objects;

/**
 * @author Alterranius
 */
public class InterpolateSearch implements Search<Integer> {
    @Override
    public Map.Entry<Integer, ? extends Integer> search(Integer[] in, Integer element) {
        int startIndex = 0;
        int lastIndex = in.length - 1;
        int pos;

        while (startIndex <= lastIndex &&
                element >= in[startIndex] &&
                element <= in[lastIndex]) {
            pos = startIndex + (((lastIndex - startIndex) / (in[lastIndex] - in[startIndex])) *
                    (element - in[startIndex]));
            if (Objects.equals(in[pos], element)) return Map.entry(pos, in[pos]);

            if (in[pos] < element) startIndex = pos + 1; else lastIndex = pos - 1;
        }
        return null;
    }
}
