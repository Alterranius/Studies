package behavior.state;

/**
 * @author Alterranius
 */
public class MediumFan implements FanState {
    @Override
    public void turnUp(Fan fan) {
        fan.setState(new HighFan());
        System.out.println("MAX_STATE");
    }

    @Override
    public void turnDown(Fan fan) {
        fan.setState(new LowFan());
        System.out.println("LOW_STATE");
    }
}
