package structural.decorator;

import java.util.ArrayList;

/**
 * @author Alterranius
 */
public class PizzaMargarita extends PizzaBase {
    private Pizza pizza;

    public PizzaMargarita(Pizza pizza) {
        this.pizza = pizza;
        name = pizza.getName().concat(" Margarita");
        toppings = pizza.getToppings();
        toppings.add("cheese");
        toppings.add("tomato");
    }
}
