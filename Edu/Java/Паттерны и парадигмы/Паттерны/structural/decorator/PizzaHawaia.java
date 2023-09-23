package structural.decorator;

import java.util.ArrayList;

/**
 * @author Alterranius
 */
public class PizzaHawaia extends PizzaBase {
    private Pizza pizza;

    public PizzaHawaia(Pizza pizza) {
        this.pizza = pizza;
        name = pizza.getName() + " Hawai";
        toppings = pizza.getToppings();
        toppings.add("ham");
        toppings.add("pineapple");
    }
}
