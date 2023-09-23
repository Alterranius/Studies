package behavior.strategy;

/**
 * @author Alterranius
 */
public class Customer {
    public void makePayment(int amount, PaymentStrategy via) {
        System.out.println("Payment for $" + amount + " was made via " + via.pay());
    }
}
