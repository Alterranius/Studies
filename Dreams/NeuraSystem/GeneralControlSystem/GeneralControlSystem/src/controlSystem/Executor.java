package controlSystem;

/**
 * @author Alterranius
 */
@FunctionalInterface
public interface Executor<R> {
    void execute(Activity<R> activity);
    Executor<String> printer = a -> System.out.println(a.get());
}
