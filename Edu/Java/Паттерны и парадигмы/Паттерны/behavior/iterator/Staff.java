package behavior.iterator;

import java.util.*;

/**
 * @author Alterranius
 */
public class Staff implements Iterable<Employee> {
    private List<Employee> employees = new ArrayList<>();

    public void add(Employee employee) {
        employees.add(employee);
    }
    public void add(Employee... employee) {
        employees.addAll(Arrays.asList(employee));
    }
    @Override
    public Iterator<Employee> iterator() {
        return new StaffIterator(this);
    }

    public List<Employee> getEmployees() {
        return employees;
    }
}
