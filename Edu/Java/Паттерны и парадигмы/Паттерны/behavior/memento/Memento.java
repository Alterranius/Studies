package behavior.memento;

/**
 * @author Alterranius
 */
public class Memento {
    private int state;

    public void setState(int state) {
        this.state = state;
    }

    public int getState() {
        return state;
    }
}
