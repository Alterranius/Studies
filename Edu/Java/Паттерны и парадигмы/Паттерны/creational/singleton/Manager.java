package creational.singleton;

/**
 * @author Alterranius
 */
public class Manager {
    private static Manager manager;

    private Manager() {

    }

    public static Manager getInstance() {
        return manager == null ? new Manager() : manager;
    }
}
