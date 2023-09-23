package controlSystem;

import java.util.Set;

/**
 * @author Alterranius
 */
public class Controller<T, R> {
    private final Executor<R> executor;
    private final RulesPool<Rule<T, R>, T, R> rules;

    protected Controller(Executor<R> executor, RulesPool<Rule<T, R>, T, R> rules) {
        this.executor = executor;
        this.rules = rules;
    }

    public static <T, R> Controller<T, R> of(Executor<R> executor, RulesPool<Rule<T, R>, T, R> rules) {
        return new Controller<T, R>(executor, rules);
    }

    // Над объектом проводятся все удовлетворительные рулы. Можно заменить специальным рул-пулом forAll
    public void controlFlat(T o) {
        rules.stream()/*.filter(r -> r.getCondition().isTrue(o))*/.forEach(r -> {
            if (r.getCondition().isTrue(o)) executor.execute(r.getActivity()); else executor.execute(new SupplyTActivity<>((R) o));
        });
    }
    // Над объектом проводятся все рулы, заданные логикой рулпула
    public void controlAll(T o) {
        if (rules.isTrue(o)) rules.getActivities().forEach(executor::execute); else executor.execute(new SupplyTActivity<>((R) o));
    }
}
