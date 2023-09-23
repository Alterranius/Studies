package controlSystem;

/**
 * @author Alterranius
 */
public class AbstractActivity<R> implements Activity<R> {
    @Override
    public AbstractActivity<R> get() {
        return this;
    }
}
