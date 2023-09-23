package structural.adapter;

/**
 * @author Alterranius
 */
public class AsianCity implements City {
    private String name;
    private double temperature;
    private boolean hasWeatherWarning = false;

    public AsianCity(String name, double temperature) {
        this.name = name;
        this.temperature = temperature;
    }

    @Override
    public String getName() {
        return name;
    }

    @Override
    public double getTemperature() {
        return temperature;
    }

    @Override
    public String getTemperatureScale() {
        return "Celsius";
    }

    @Override
    public boolean getHasWeatherWarning() {
        return hasWeatherWarning;
    }

    @Override
    public void setHasWeatherWarning(boolean hasWeatherWarning) {
        this.hasWeatherWarning = hasWeatherWarning;
    }
}
