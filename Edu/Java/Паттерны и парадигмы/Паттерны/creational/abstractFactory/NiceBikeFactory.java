package creational.abstractFactory;

/**
 * @author Alterranius
 */
public class NiceBikeFactory implements BikeFactory {

    @Override
    public Wheel createWheel() {
        return new SpeedWheel();
    }

    @Override
    public Chain createChain() {
        return new SpeedChain();
    }

    @Override
    public Tire createTire() {
        return new SpeedTire();
    }
}
