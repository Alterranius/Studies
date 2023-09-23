package structural.composite;

/**
 * @author Alterranius
 */
public class Main {
    public static void main(String[] args) {
        Checkable bookCollection = new BookCollection();
        Checkable fictionBook = new FictionBook("Book1", true, false);
        Checkable nonfictionBook = new NonfictionBook("Book2", false, true);

        bookCollection.checkout();
        fictionBook.checkout();
        nonfictionBook.checkout();


        // Идея обрабатывать разные объекты под грифом единой группы свойств
        // АНАЛОГ: Обощение понятий
    }
}
