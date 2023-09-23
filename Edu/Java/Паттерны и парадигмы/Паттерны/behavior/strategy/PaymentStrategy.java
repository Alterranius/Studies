package behavior.strategy;

/**
 * @author Alterranius
 */
@FunctionalInterface
public interface PaymentStrategy {
    String pay();
    PaymentStrategy payPal = () -> "payPal";
    PaymentStrategy webMoney = () -> "webMoney";
    PaymentStrategy hackers = String::new;
}
