package creational.abstractFactory;

/**
 * @author Alterranius
 */
public class Main {
    public static void main(String[] args) {
        BikeFactory bikeStock = new ForestBikeFactory();

        Bike forestBike = new Bike(bikeStock);

        bikeStock = new NiceBikeFactory();

        Bike speedBike = new Bike(bikeStock);

        // Ось изменения проходит через семейство классов, требуется расширение иерархии. Особенно подходит для различных сочетаний
        // АНАЛОГ: Построение разного типа велосипеда из одинаковыми ключевыми частями с разной реализацией
    }
}
