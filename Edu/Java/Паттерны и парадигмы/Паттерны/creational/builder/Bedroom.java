package creational.builder;

import java.awt.*;

/**
 * @author Alterranius
 */
public class Bedroom {
    private Dimension dimension;
    private int height;
    private int floors;
    private Color wallColor;
    private int windows;
    private int doors;
    private boolean isDouble;
    private boolean ofMetal;

    public Bedroom(Dimension dimension, int height, int floors, Color wallColor, int windows, int doors, boolean isDouble, boolean ofMetal) {
        this.dimension = dimension;
        this.height = height;
        this.floors = floors;
        this.wallColor = wallColor;
        this.windows = windows;
        this.doors = doors;
        this.isDouble = isDouble;
        this.ofMetal = ofMetal;
    }
}
