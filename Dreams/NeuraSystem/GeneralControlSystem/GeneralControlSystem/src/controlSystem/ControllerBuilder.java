package controlSystem;

/**
 * @author Alterranius
 */
public class ControllerBuilder<T, R> {
    private Executor<R> executor;
    private final RulesPool<Rule<T, R>, T, R> rules = new RulesPool<>();

    public ControllerBuilder<T, R> addRule(Rule<T, R> rule) {
        rules.add(rule);
        return this;
    }

    public ControllerBuilder<T, R> setExecutor(Executor<R> executor) {
        this.executor = executor;
        return this;
    }

    public Controller<T, R> toController() {
        return Controller.of(executor, rules);
    }
}
