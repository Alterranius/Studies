package behavior.state;

/**
 * @author Alterranius
 */
public class Fan {
    private FanState state = new LowFan();

    public void turnUp() {
        state.turnUp(this);
    }

    public void turnDown() {
        state.turnDown(this);
    }

    public FanState getState() {
        return state;
    }

    public void setState(FanState state) {
        this.state = state;
    }
}
