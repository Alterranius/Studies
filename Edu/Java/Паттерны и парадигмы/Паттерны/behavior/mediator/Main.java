package behavior.mediator;

/**
 * @author Alterranius
 */
public class Main {
    public static void main(String[] args) {
        Plane plane1 = new Plane(123);
        Plane plane2 = new Plane(124);
        Plane plane3 = new Plane(125);

        PlanesInFlight flightStock = new PlanesInFlight();
        PlanesOnGround groundStock = new PlanesOnGround();

        groundStock.addPlane(plane1);
        groundStock.addPlane(plane2);
        groundStock.addPlane(plane3);

        PlanesMediator mediator = new PlanesMediator(
                new Runway(),
                flightStock,
                groundStock);
        mediator.takeOff(plane1);

        // Позволяет взаимодействовать между многими подсистемами через него
        // АНАЛОГ: официант в ресторане
    }
}
