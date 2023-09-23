package behavior.visitor;

/**
 * @author Alterranius
 */
public interface Groceries {
    double getPrice();
    void accept(Visitor visitor);
}
