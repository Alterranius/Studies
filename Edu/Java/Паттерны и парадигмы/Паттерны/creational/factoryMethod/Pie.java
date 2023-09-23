package creational.factoryMethod;

import java.util.ArrayList;
import java.util.stream.Stream;

/**
 * @author Alterranius
 */
public class Pie extends Candy {
    @Override
    ArrayList<Candy> makePackage(int quantity) {
        return new ArrayList<>(Stream.iterate(new Pie(), c -> new Pie()).limit(quantity).toList());
    }
}
