package controlSystem;

/**
 * @author Alterranius
 */
public class SupplyTActivity<R> extends AbstractActivity<R> {
    private final R value;

    public SupplyTActivity(R value) {
        this.value = value;
    }

    @Override
    public String toString() {
        return value.toString();
    }
}
