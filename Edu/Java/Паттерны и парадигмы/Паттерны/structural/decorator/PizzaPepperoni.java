package structural.decorator;

import java.util.ArrayList;

/**
 * @author Alterranius
 */
public class PizzaPepperoni extends PizzaBase {
    private Pizza pizza;

    public PizzaPepperoni(Pizza pizza) {
        this.pizza = pizza;
        name = pizza.getName() + " Pepperoni";
        toppings = pizza.getToppings();
        toppings.add("cheese");
        toppings.add("pepperoni");
        toppings.add("tomato");
    }
}
