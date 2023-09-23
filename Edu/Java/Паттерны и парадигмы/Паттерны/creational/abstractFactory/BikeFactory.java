package creational.abstractFactory;

/**
 * @author Alterranius
 */
public interface BikeFactory {
    Wheel createWheel();
    Chain createChain();
    Tire createTire();
}
