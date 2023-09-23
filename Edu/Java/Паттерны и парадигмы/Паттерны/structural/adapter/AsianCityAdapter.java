package structural.adapter;

/**
 * @author Alterranius
 */
public class AsianCityAdapter implements City {
    private AsianCity asianCity;

    public AsianCityAdapter(AsianCity asianCity) {
        this.asianCity = asianCity;
    }

    @Override
    public String getName() {
        return asianCity.getName();
    }

    @Override
    public double getTemperature() {
        return asianCity.getTemperature() + 18;
    }

    @Override
    public String getTemperatureScale() {
        return "Fahrenheit";
    }

    @Override
    public boolean getHasWeatherWarning() {
        return asianCity.getHasWeatherWarning();
    }

    @Override
    public void setHasWeatherWarning(boolean hasWeatherWarning) {
        asianCity.setHasWeatherWarning(hasWeatherWarning);
    }
}
