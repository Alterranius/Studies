package structural.flyweight;

/**
 * @author Alterranius
 */
public class Car implements Vehicle {
    private int[] location = new int[2];

    @Override
    public String getType() {
        return this.getClass().getName();
    }

    @Override
    public int[] getLocation() {
        return location;
    }

    @Override
    public void setLocation(int latitude, int longitude) {
        location[0] = latitude;
        location[1] = longitude;
    }
}
