package creational.abstractFactory;

/**
 * @author Alterranius
 */
public class Bike {
    protected Wheel wheel;
    protected Tire tire;
    protected Chain chain;

    public Bike(BikeFactory factory) {
        wheel = factory.createWheel();
        tire = factory.createTire();
        chain = factory.createChain();
    }
}
