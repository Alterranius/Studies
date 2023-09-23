package behavior.observer;

/**
 * @author Alterranius
 */
public class Main {
    public static void main(String[] args) {
        City sunvill = new City();
        City springfield = new City();
        var trafficUpdates = new TrafficUpdates();

        sunvill.addPropertyChangeListener(trafficUpdates);
        springfield.addPropertyChangeListener(trafficUpdates);

        sunvill.updateTraffic("Stop traffic event");
        springfield.updateTraffic("Accident on the highway");

        System.out.println(trafficUpdates.getUpdates());

        // Получает уведомление об изменении состояния наблюдаемого
        // АНАЛОГ: Наблюдение за своими сообщениями, INotifyPropertyChanged
        // Pub-Sub (Издатель-подписчик) является одной из вариаций
    }
}