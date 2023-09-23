package structural.adapter;

/**
 * @author Alterranius
 */
public interface City {
    String getName();
    double getTemperature();
    String getTemperatureScale();
    boolean getHasWeatherWarning();
    void setHasWeatherWarning(boolean hasWeatherWarning);
}
