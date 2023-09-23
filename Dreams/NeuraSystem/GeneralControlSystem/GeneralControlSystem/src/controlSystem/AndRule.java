package controlSystem;

/**
 * @author Alterranius
 */
public class AndRule<T, R> extends Rule<T, R> {
    protected AndRule(Condition<T> condition, Activity<R> activity) {
        super(condition, activity);
    }
}
