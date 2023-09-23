package structural.composite;

/**
 * @author Alterranius
 */
public class NonfictionBook implements Checkable {
    String name;
    boolean checkedOut;
    boolean isAPlay;

    public NonfictionBook(String name, boolean checkedOut, boolean isAPlay) {
        this.name = name;
        this.checkedOut = checkedOut;
        this.isAPlay = isAPlay;
    }

    public void checkout() {
        if (!checkedOut) {
            System.out.println("Checking out " + name + "\n");
            checkedOut = true;
        } else {
            System.out.println(name + "is already checked out\n");
        }
    }

    public void returnBook() {
        if (checkedOut) {
            System.out.println("Returning " + name + "\n");
        } else {
            System.out.println(name + "is not checked out\n");
        }
    }
}
