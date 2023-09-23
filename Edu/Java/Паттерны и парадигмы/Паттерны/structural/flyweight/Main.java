package structural.flyweight;

import java.util.ArrayList;
import java.util.Random;
import java.util.concurrent.Executors;
import java.util.concurrent.ScheduledExecutorService;
import java.util.concurrent.TimeUnit;

/**
 * @author Alterranius
 */
public class Main {
    static ArrayList<Vehicle> vehicles = new ArrayList<>();
    static VehicleWeight weigth = new VehicleWeight();

    public static void main(String[] args) {
        Runnable createVehicles = Main::createRandomCar;
        Runnable removeVehicles = Main::removeCar;

        ScheduledExecutorService executorService = Executors.newScheduledThreadPool(1);
        executorService.scheduleAtFixedRate(createVehicles, 0, 3, TimeUnit.SECONDS);
        executorService.scheduleAtFixedRate(removeVehicles, 5, 5, TimeUnit.SECONDS);


        // Множество малых объектов во избежание OutOfMemory должно быть упрощено
        // АНАЛОГ: символы в тексте: intrinsic-значение и extrinsic-положение. Имеет смысл задавать только положение
    }

    private static void removeCar() {
        System.out.println("Removing " + vehicles.get(0));
        vehicles.remove(0);
    }

    private static void createRandomCar() {
        Random random = new Random();
        int rand = random.nextInt(2);
        Vehicle vehicle = weigth.getVehicle(rand);
        vehicle.setLocation(random.nextInt(1000), random.nextInt(1000));
        System.out.println("Created " + vehicle + "type " + vehicle.getType() +
                "location " + vehicle.getLocation()[0] + ":" + vehicle.getLocation()[1]);
        vehicles.add(vehicle);
    }
}
