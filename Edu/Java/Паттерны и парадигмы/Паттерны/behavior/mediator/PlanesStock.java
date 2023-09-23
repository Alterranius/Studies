package behavior.mediator;

import java.util.HashSet;
import java.util.Set;

/**
 * @author Alterranius
 */
public abstract class PlanesStock {
    private final Set<Plane> planes = new HashSet<>();

    public void addPlane(Plane plane) {
        planes.add(plane);
    }

    public void remove(Plane plane) {
        planes.remove(plane);
    }
}
