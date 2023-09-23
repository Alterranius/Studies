package behavior.template;

/**
 * @author Alterranius
 */
public class Main {
    public static void main(String[] args) {
        Pirate pirate = new Pirate();
        Troll troll = new Troll();

        pirate.defend();
        troll.defend();

        // Разделение одного алгоритма на различные части
        // АНАЛОГ: сборка продукта по проивзодствам всего мира
    }
}
