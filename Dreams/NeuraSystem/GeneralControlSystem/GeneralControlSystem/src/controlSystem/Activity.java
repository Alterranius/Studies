package controlSystem;

/**
 * @author Alterranius
 */
@FunctionalInterface
public interface Activity<R> {
    AbstractActivity<R> get();
}
