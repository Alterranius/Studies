package behavior.state;

/**
 * @author Alterranius
 */
public class HighFan implements FanState {
    @Override
    public void turnUp(Fan fan) {
        System.out.println("MAX_STATE");
    }

    @Override
    public void turnDown(Fan fan) {
        fan.setState(new MediumFan());
        System.out.println("MEDIUM_STATE");
    }
}
