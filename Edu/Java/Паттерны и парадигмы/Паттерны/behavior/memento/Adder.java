package behavior.memento;

/**
 * @author Alterranius
 */
public class Adder {
    private int result;
    private final Memento memento = new Memento();

    public void add(int num) {
        result += num;
    }

    public int getResult() {
        return result;
    }

    public void save() {
        memento.setState(result);
    }

    public void undo() {
        result = memento.getState();
    }
}
