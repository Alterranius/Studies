package behavior.command;

/**
 * @author Alterranius
 */
public class SalesOrderClient {
    private static final Jacket jacket = new Jacket();

    public static void main(String[] args) {
        OrderHandler placeOrderHandler = new OrderHandler();
        OrderHandler returnOrderHandler = new OrderHandler();

        placeOrderHandler.invoke(new PlaceOrderCommand(jacket));
        returnOrderHandler.invoke(new ReturnOrderCommand(jacket));

        // Инкапсуляция обрабатывающего кода в команду, возможность создания цепочки обработок
        // АНАЛОГ: нажатие на кнопку
    }
}
