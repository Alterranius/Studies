package controlSystem;

/**
 * @author Alterranius
 */
public class DivCondition<T> implements Condition<T> {
    private final T value;

    public DivCondition(T value) {
        this.value = value;
    }

    @Override
    public boolean isTrue(T o) {
        return o instanceof Number && ((Integer) o % (Integer) value) == 0;
    }
}
