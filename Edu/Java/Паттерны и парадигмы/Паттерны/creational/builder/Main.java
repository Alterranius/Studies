package creational.builder;

import java.awt.*;

/**
 * @author Alterranius
 */
public class Main {
    public static void main(String[] args) {
        BedroomBuilder builder = new BedroomBuilder();
        builder
                .setHeight(15)
                .setFloors(2)
                .setOfMetal(true)
                .setIsDouble(true)
                .setWindows(3)
                .createBedroom();

        // Способ избежать сложных больших конструкторов или множества конструкторов
        // АНАЛОГ: сборочная мастерская, StringBuilder
    }
}
