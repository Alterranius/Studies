package Collects;

import org.jetbrains.annotations.NotNull;

import java.util.*;

/**
 * @author Alterranius
 */
public class SimpleMap {
    static Map<Integer, String> getStringMap(int count) {
        return new AbstractMap<Integer, String>() {
            @NotNull
            @Override
            public Set<Entry<Integer, String>> entrySet() {
                return new AbstractSet<Entry<Integer, String>>() {
                    @Override
                    public Iterator<Entry<Integer, String>> iterator() {
                        return new Iterator<Entry<Integer, String>>() {
                            int next = 0;

                            @Override
                            public boolean hasNext() {
                                return next < count;
                            }

                            @Override
                            public Entry<Integer, String> next() {
                                if (next == count) throw new NoSuchElementException();
                                return new AbstractMap.SimpleImmutableEntry<>(next, String.valueOf(next++));
                            }
                        };
                    }

                    @Override
                    public int size() {
                        return count;
                    }
                };
            }
        };
    }
}
