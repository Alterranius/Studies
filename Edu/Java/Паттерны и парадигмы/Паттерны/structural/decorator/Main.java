package structural.decorator;

/**
 * @author Alterranius
 */
public class Main {
    public static void main(String[] args) {
        Pizza base = new PizzaHawaia(new PizzaMargarita(new PizzaBase()));
        System.out.println(base.getName());
        System.out.println(base.getToppings());

        // Навешивание дополнительных функцональностей и расширение состояния
        // АНАЛОГ: приготовление пиццы из основы для пиццы поэтапно, наращивание
    }
}
