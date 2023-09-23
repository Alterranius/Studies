package behavior.state;

/**
 * @author Alterranius
 */
public class Main {
    public static void main(String[] args) {
        Fan fan = new Fan();
        fan.turnUp();
        fan.turnUp();
        fan.turnUp();
        fan.turnDown();

        // Меняет поведение объекта динамически при смене состояния
        // АНАЛОГ: switch для Enumов
    }
}
