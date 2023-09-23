package behavior.iterator;

import java.util.Iterator;

/**
 * @author Alterranius
 */
public class StaffIterator implements Iterator<Employee> {
    private Staff staff;
    private int index;

    public StaffIterator(Staff staff) {
        this.staff = staff;
    }

    @Override
    public boolean hasNext() {
        return staff.getEmployees().size() > index;
    }

    @Override
    public Employee next() {
        if (hasNext()) {
            Employee e = staff.getEmployees().get(index++);
            return e.active ? e : next();
        } else {
            return null;
        }
    }

    @Override
    public void remove() {
        staff.getEmployees().remove(index);
    }
}
