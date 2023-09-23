package creational.factoryMethod;

import java.util.ArrayList;

/**
 * @author Alterranius
 */
public class CandyStore {
    public static ArrayList<Candy> getCandyPackage(int quantity, Candy candy) {
        return candy.makePackage(quantity);
    }
}
