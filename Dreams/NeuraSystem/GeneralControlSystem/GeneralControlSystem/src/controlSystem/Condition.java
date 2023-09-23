package controlSystem;

/**
 * @author Alterranius
 */
@FunctionalInterface
public interface Condition<T> {
    boolean isTrue(T o);
}
