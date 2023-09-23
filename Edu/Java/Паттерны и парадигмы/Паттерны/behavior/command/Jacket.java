package behavior.command;

/**
 * @author Alterranius
 */
public class Jacket {
    private int orders;

    public void placeOrder() {
        orders++;
    }

    public void returnOrder() {
        orders--;
    }
}
