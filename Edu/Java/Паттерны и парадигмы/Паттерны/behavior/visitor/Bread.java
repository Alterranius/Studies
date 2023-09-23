package behavior.visitor;

/**
 * @author Alterranius
 */
public class Bread implements Groceries {
    private double price = 1d;

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
