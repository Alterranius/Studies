package behavior.visitor;

/**
 * @author Alterranius
 */
public class Milk implements Groceries {
    private double price = 2d;

    public double getPrice() {
        return price;
    }

    public void setPrice(double price) {
        this.price = price;
    }

    @Override
    public void accept(Visitor visitor) {
        visitor.visit(this);
    }
}
