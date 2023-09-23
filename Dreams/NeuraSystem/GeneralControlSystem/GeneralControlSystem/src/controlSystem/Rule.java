package controlSystem;

/**
 * @author Alterranius
 */
public abstract class Rule<T, R> {
    private final Condition<T> condition;
    private final Activity<R> activity;

    protected Rule(Condition<T> condition, Activity<R> activity) {
        this.condition = condition;
        this.activity = activity;
    }

    public Condition<T> getCondition() {
        return condition;
    }

    public Activity<R> getActivity() {
        return activity;
    }
}
