package structural.flyweight;

import java.util.HashMap;

/**
 * @author Alterranius
 */
public class VehicleWeight {
    HashMap<Integer, Vehicle> vehicles = new HashMap<>();

    public Vehicle getVehicle(int type) {
        if (vehicles.containsKey(type)) {
            return vehicles.get(type);
        } else {
            Vehicle vehicle;
            if (type == 0) {
                vehicle = new Car();
            } else {
                vehicle = new Truck();
            }
            vehicles.put(type, vehicle);
            return vehicle;
        }
    }
}
