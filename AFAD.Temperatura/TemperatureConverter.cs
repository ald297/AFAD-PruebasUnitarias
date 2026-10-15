namespace AFAD.Temperatura
{
    public class TemperatureConverter
    {
        public double CelsiusToFahrenheit(double celsius)
        {
            // Implementa la conversión de Celsius a Fahrenheit: (C * 9 / 5) + 32
            return (celsius * 9.0 / 5.0) + 32.0;
        }

        public double FahrenheitToCelsius(double fahrenheit)
        {
            // Implementa la conversión de Fahrenheit a Celsius: (F - 32) * 5 / 9
            return (fahrenheit - 32.0) * 5.0 / 9.0;
        }
    }
}
