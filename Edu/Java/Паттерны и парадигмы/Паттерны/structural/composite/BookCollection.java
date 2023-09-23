package structural.composite;

import java.util.ArrayList;
import java.util.List;

/**
 * @author Alterranius
 */
public class BookCollection implements Checkable {
    private List<Checkable> books = new ArrayList<>();

    @Override
    public void checkout() {
        books.forEach(Checkable::checkout);
    }

    @Override
    public void returnBook() {
        books.forEach(Checkable::returnBook);
    }
}
