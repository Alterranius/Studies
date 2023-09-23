package behavior.visitor;

import java.util.ArrayList;
import java.util.List;

/**
 * @author Alterranius
 */
public class GroceryList implements Groceries {
    List<Groceries> groceries = new ArrayList<>();

    public GroceryList() {
        groceries.addAll(List.of(
                new Bread(),
                new Bread(),
                new Bread(),
                new Milk(),
                new Milk()));
    }

    public double getPrice() {
        return groceries.stream().mapToDouble(Groceries::getPrice).sum();
    }

    @Override
    public void accept(Visitor visitor) {
        groceries.forEach(g -> g.accept(visitor));
        visitor.visit(this);
    }
}
