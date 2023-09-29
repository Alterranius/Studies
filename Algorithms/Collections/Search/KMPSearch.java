package Search;

import java.lang.reflect.Array;
import java.util.ArrayList;
import java.util.List;

/**
 * @author Alterranius
 */
public class KMPSearch<T> {
    public static int[] compilePattern(String pattern) {
        int len = 0;
        int patternLength = pattern.length();
        int i = 1;
        int[] result = new int[pattern.length()];
        result[0] = 0;

        while (i < patternLength) {
            if (pattern.charAt(i) == (pattern.charAt(len))) {
                len++;
                result[i] = len;
                i++;
            } else {
                if (len != 0) {
                    len = result[len - 1];
                } else {
                    result[i] = len;
                    i++;
                }
            }
        }
        return result;
    }

    public static List<Integer> searchPattern(String text, String pattern) {
        int[] compiledPattern = compilePattern(pattern);
        int textIndex = 0, patternIndex = 0;
        int textLength = text.length(), patternLength = pattern.length();
        List<Integer> result = new ArrayList<>();

        while (textIndex < textLength) {
            if (pattern.charAt(patternIndex) == text.charAt(textIndex)) {
                patternIndex++;
                textIndex++;
            }
            if (patternIndex == patternLength) {
                result.add(textIndex - patternIndex);
                patternIndex = compiledPattern[patternIndex - 1];
            } else if (textIndex < textLength && pattern.charAt(patternIndex) != text.charAt(textIndex)) {
                if (patternIndex != 0) {
                    patternIndex = compiledPattern[patternIndex - 1];
                } else {
                    textIndex++;
                }
            }
        }
        return result;
    }
}
