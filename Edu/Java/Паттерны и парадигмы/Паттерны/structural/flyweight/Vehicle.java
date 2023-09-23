package structural.flyweight;

/**
 * @author Alterranius
 */
public interface Vehicle {
    String getType();
    int[] getLocation();
    void setLocation(int latitude, int longitude);
}
