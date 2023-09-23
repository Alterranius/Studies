package creational.prototype;

/**
 * @author Alterranius
 */
public class Main {
    public static void main(String[] args) {
        Rabbit rabbit = new Rabbit();
        Rabbit secondRabbit = rabbit.clone();

        // Позволяет получать объект на основе некоторого прототипа
        // АНАЛОГ: динамическое клонирование объектов
    }
}
