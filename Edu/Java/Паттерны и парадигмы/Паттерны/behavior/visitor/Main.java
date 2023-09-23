package behavior.visitor;

/**
 * @author Alterranius
 */
public class Main {
    public static void main(String[] args) {
        GroceryList groceryList = new GroceryList();
        System.out.println(groceryList.getPrice());

        groceryList.accept(new DiscountVisitor());
        System.out.println(groceryList.getPrice());
        // Проводит операцию над посещаемыми элементами БЕЗ изменения их состояния
        // АНАЛОГ: посещение автомеханика разными автомобилями, получение скидки
    }
}
