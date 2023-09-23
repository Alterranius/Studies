package creational.prototype;

/**
 * @author Alterranius
 */
public class Rabbit implements Cloneable {
    public enum Breed {
        AMERICAN,
        RUSSIAN,
        DUTCH
    }

    private int age;
    private Breed breed;

    @Override
    public Rabbit clone() {
        try {
            return (Rabbit) super.clone();
        } catch (CloneNotSupportedException e) {
            throw new AssertionError();
        }
    }
}
