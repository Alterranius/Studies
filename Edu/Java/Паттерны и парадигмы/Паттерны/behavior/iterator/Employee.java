package behavior.iterator;

/**
 * @author Alterranius
 */
public class Employee {
    private String name;
    public boolean active;

    public Employee(String name, boolean active) {
        this.name = name;
        this.active = active;
    }

    @Override
    public String toString() {
        return "Employee{" +
                "name='" + name + '\'' +
                ", active=" + active +
                '}';
    }
}
