package behavior.mediator;

/**
 * @author Alterranius
 */
public class Plane {
    private int id;
    private boolean isInTheAir;

    public Plane(int id) {
        this.id = id;
    }

    public int getId() {
        return id;
    }

    public boolean isInTheAir() {
        return isInTheAir;
    }

    public void setInTheAir(boolean inTheAir) {
        isInTheAir = inTheAir;
    }
}
