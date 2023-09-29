package Search;

import java.util.Map;

/**
 * @author Alterranius
 */
public class JumpSearch<T extends Comparable<T>> implements Search<T> {
    @Override
    public Map.Entry<Integer, ? extends T> search(T[] in, T element) {
        int jumpStep = (int) Math.sqrt(in.length);
        int previousStep = 0;
        int step = jumpStep;

        while (element.compareTo(in[Math.min(jumpStep, in.length) - 1]) > 0) {
            previousStep = jumpStep;
            jumpStep += step;
            if (previousStep >= in.length) return null;
        }
        while (element.compareTo(in[previousStep]) > 0) {
            previousStep++;
            if (previousStep == Math.min(jumpStep, in.length)) return null;
        }
        if (in[previousStep].equals(element)) return Map.entry(previousStep, in[previousStep]);
        return null;
    }
}
