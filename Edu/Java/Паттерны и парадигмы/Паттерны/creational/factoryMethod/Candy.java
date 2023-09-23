package creational.factoryMethod;

import java.util.ArrayList;

/**
 * @author Alterranius
 */
public abstract class Candy {
    abstract ArrayList<Candy> makePackage(int quantity);
}
