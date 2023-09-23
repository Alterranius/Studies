package creational.factoryMethod;

import java.util.ArrayList;
import java.util.stream.Stream;

/**
 * @author Alterranius
 */
public class Chocolate extends Candy {
    @Override
    ArrayList<Candy> makePackage(int quantity) {
        return new ArrayList<>(Stream.iterate(new Chocolate(), c -> new Chocolate()).limit(quantity).toList());
    }
}
