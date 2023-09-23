package structural.decorator;

import java.util.ArrayList;

/**
 * @author Alterranius
 */
public class PizzaBase implements Pizza {
    protected String name = "";
    protected ArrayList<String> toppings = new ArrayList<>();

    public String getName() {
        return name;
    }

    public ArrayList<String> getToppings() {
        return toppings;
    }
}
