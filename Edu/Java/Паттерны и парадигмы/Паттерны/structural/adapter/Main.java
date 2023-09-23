package structural.adapter;

/**
 * @author Alterranius
 */
public class Main {
    public static void main(String[] args) {
        AsianCityAdapter asianCity = new AsianCityAdapter(new AsianCity("Bangkok", 82));
        NorthAmericanCity northCity = new NorthAmericanCity("Chicago", 16);

        WeatherWarning warning = new WeatherWarning();
        warning.postWarning(asianCity);
        warning.postWarning(northCity);

        // Соединение различной функциональности под единым флагом
        // АНАЛОГ: Розетка заряжает любые устройства, SqlAdapter
    }
}
