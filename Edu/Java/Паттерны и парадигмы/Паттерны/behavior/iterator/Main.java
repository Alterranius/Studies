package behavior.iterator;

/**
 * @author Alterranius
 */
public class Main {
    public static void main(String[] args) {
        Employee bill = new Employee("Bill", true);
        Employee kate = new Employee("Kate", true);
        Employee john = new Employee("John", false);
        Employee bob = new Employee("Bob", true);
        Staff staff = new Staff();
        staff.add(bill, kate, john, bob);

        for (Employee e : staff) {
            System.out.println(e);
        }

        // Итерируется по элементам с условием прохода
        // АНАЛОГ: фильтрующий манипулятор
    }
}
