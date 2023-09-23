package behavior.state;

/**
 * @author Alterranius
 */
public class LowFan implements FanState {
    @Override
    public void turnUp(Fan fan) {
        fan.setState(new MediumFan());
        System.out.println("MEDIUM_STATE");
    }

    @Override
    public void turnDown(Fan fan) {
        System.out.println("LOW_STATE");
    }
}
