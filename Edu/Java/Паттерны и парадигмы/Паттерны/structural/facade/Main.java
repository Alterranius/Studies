package structural.facade;

/**
 * @author Alterranius
 */
public class Main {
    public static void main(String[] args) {
        CarStarter starterFacade = new CarStarter();
        starterFacade.start(
                new Car(),
                new Accelerator(),
                new Handbrake(),
                new Ignition()
        );

        // Нужен для выдачи чёткой логики взаимодействия
        // АНАЛОГ: изолированный API
    }
}
