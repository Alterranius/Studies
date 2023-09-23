package controlSystem;

import java.util.*;

/**
 * @author Alterranius
 */
// Абстрагировав RulePool, можно легко перейти к оси изменения по рул-пулам
public class RulesPool<C extends Rule<T, R>, T, R> extends HashSet<C> implements Condition<T> {
    private List<Activity<R>> lastActivities = new ArrayList<>();

    // Метод в каждом отдельном рул-пуле будет определять логику агрегации рулов в пуле
    @Override
    public boolean isTrue(T o) {
        lastActivities.clear();
        this.stream().filter(s -> s instanceof AndRule<?,?>)
                .filter(s -> ((C) s).getCondition().isTrue( o))
                .collect(
                        () -> lastActivities,
                        (r, t) -> r.add(t.getActivity()),
                        List::addAll
                );
        return lastActivities.size() == 1;
    }

    public List<Activity<R>> getActivities() {
        return lastActivities;
    }
}
