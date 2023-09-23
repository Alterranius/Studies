package creational.factoryMethod;

/**
 * @author Alterranius
 */
public class ChocolateFactory implements CandyFactory {
    @Override
    public Candy create() {
        return new Chocolate();
    }
}
