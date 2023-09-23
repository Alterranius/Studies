package creational.abstractFactory;

/**
 * @author Alterranius
 */
public class ForestBikeFactory implements BikeFactory {
    @Override
    public Wheel createWheel() {
        return new SpeedWheel();
    }

    @Override
    public Chain createChain() {
        return new MountainChain();
    }

    @Override
    public Tire createTire() {
        return new MountainTire();
    }
}
