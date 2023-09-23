package creational.factoryMethod;

/**
 * @author Alterranius
 */
public class PieFactory implements CandyFactory {

    @Override
    public Candy create() {
        return new Pie();
    }
}
