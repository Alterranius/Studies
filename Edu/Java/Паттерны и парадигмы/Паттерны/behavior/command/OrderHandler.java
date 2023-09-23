package behavior.command;

/**
 * @author Alterranius
 */
public class OrderHandler {
    public void invoke(Command command) {
        command.execute();
    }
}
