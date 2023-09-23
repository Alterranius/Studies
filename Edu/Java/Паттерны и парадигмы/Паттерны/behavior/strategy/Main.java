package behavior.strategy;

/**
 * @author Alterranius
 */
public class Main {
    public static void main(String[] args) {
        Customer customer = new Customer();
        customer.makePayment(100, PaymentStrategy.webMoney);
        customer.makePayment(250, PaymentStrategy.payPal);

        // Динамическая с точки зрения Runtime подстановка поведения
        // АНАЛОГ: различный выбор шифрования под разные расширения файлов
    }
}
