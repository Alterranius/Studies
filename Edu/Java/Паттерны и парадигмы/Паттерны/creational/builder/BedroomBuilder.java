package creational.builder;

import java.awt.*;

public class BedroomBuilder {
    private Dimension dimension;
    private int height;
    private int floors;
    private Color wallColor;
    private int windows;
    private int doors;
    private boolean isDouble;
    private boolean ofMetal;

    public BedroomBuilder setDimension(Dimension dimension) {
        this.dimension = dimension;
        return this;
    }

    public BedroomBuilder setHeight(int height) {
        this.height = height;
        return this;
    }

    public BedroomBuilder setFloors(int floors) {
        this.floors = floors;
        return this;
    }

    public BedroomBuilder setWallColor(Color wallColor) {
        this.wallColor = wallColor;
        return this;
    }

    public BedroomBuilder setWindows(int windows) {
        this.windows = windows;
        return this;
    }

    public BedroomBuilder setDoors(int doors) {
        this.doors = doors;
        return this;
    }

    public BedroomBuilder setIsDouble(boolean isDouble) {
        this.isDouble = isDouble;
        return this;
    }

    public BedroomBuilder setOfMetal(boolean ofMetal) {
        this.ofMetal = ofMetal;
        return this;
    }

    public Bedroom createBedroom() {
        return new Bedroom(dimension, height, floors, wallColor, windows, doors, isDouble, ofMetal);
    }
}