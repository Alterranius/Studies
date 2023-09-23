package behavior.mediator;

/**
 * @author Alterranius
 */
public class PlanesMediator {
    private Runway runway;
    private PlanesInFlight flightStock;
    private PlanesOnGround groundStock;

    public PlanesMediator(Runway runway, PlanesInFlight flightStock, PlanesOnGround groundStock) {
        this.runway = runway;
        this.flightStock = flightStock;
        this.groundStock = groundStock;
    }

    public void takeOff(Plane plane) {
        if (runway.isAvailable()) {
            runway.setAvailable(false);
            System.out.println("Ready to take off");
            try {
                Thread.sleep(3000);
            } catch (InterruptedException e) {
                throw new RuntimeException(e);
            }
            plane.setInTheAir(true);
            groundStock.remove(plane);
            flightStock.addPlane(plane);
            System.out.println("Complete");
            runway.setAvailable(true);
        }
    }
}
