package Collects;

import Search.LinearSearch;

import java.util.Arrays;

/**
 * @author Alterranius
 */
public class DynamicArrayList<E> {
    public static final int INITIAL_SIZE = 20;

    private Object[] value = new Object[INITIAL_SIZE];
    private int label = 0;

    public int add(E e) {
        if (label >= value.length) value = Arrays.copyOf(value, (int) (value.length * 1.5));

        value[++label] = e;
        return label;
    }

    public E get(int index) {
        if (index > value.length - 1 || index < 0) return null;
        return (E) value[index];
    }

    public int size() { return value.length; }

    public int remove(E e) {
        final int i, newSize;
        if ((newSize = value.length - 1) > (i = new LinearSearch<E>().search((E[]) value, e).getKey()))
            System.arraycopy(value, i + 1, value, i, newSize - i);
        value[newSize] = null;
        return i;
    }
}
