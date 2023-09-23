package structural.facade;

/**
 * @author Alterranius
 */
public class CarStarter {
    public void start(Car car, Accelerator accelerator, Handbrake handbrake, Ignition ignition) {
        car.sit();
        ignition.ignite();
        handbrake.getOff();
        accelerator.accelerate();
    }
}
