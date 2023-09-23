package behavior.command;

/**
 * @author Alterranius
 */
public class ReturnOrderCommand implements Command {
    private Jacket jacket;

    public ReturnOrderCommand(Jacket jacket) {
        this.jacket = jacket;
    }

    @Override
    public void execute() {
        jacket.returnOrder();
    }
}
