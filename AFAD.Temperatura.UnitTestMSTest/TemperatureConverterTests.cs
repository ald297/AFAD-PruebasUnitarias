using Microsoft.VisualStudio.TestTools.UnitTesting;
using AFAD.Temperatura;

namespace AFAD.Temperatura.UnitTestMSTest
{
    [TestClass]
    public class TemperatureConverterTests
    {
        [TestMethod]
        public void CelsiusToFahrenheit_FreezingPoint_Returns32()
        {
            // Arrange
            var converter = new TemperatureConverter();

            // Act
            double result = converter.CelsiusToFahrenheit(0);

            // Assert
            Assert.AreEqual(32.0, result, 0.001);
        }

        [TestMethod]
        public void CelsiusToFahrenheit_BoilingPoint_Returns212()
        {
            // Arrange
            var converter = new TemperatureConverter();

            // Act
            double result = converter.CelsiusToFahrenheit(100);

            // Assert
            Assert.AreEqual(212.0, result, 0.001);
        }

        [TestMethod]
        public void CelsiusToFahrenheit_BelowZeroPoint_ReturnsMinus40()
        {
            // Arrange
            var converter = new TemperatureConverter();

            // Act
            double result = converter.CelsiusToFahrenheit(-40);

            // Assert
            Assert.AreEqual(-40.0, result, 0.001);
        }

        [TestMethod]
        public void FahrenheitToCelsius_FreezingPoint_ReturnsZero()
        {
            // Arrange
            var converter = new TemperatureConverter();

            // Act
            double result = converter.FahrenheitToCelsius(32);

            // Assert
            Assert.AreEqual(0.0, result, 0.001);
        }

        [TestMethod]
        public void FahrenheitToCelsius_BoilingPoint_Returns100()
        {
            // Arrange
            var converter = new TemperatureConverter();

            // Act
            double result = converter.FahrenheitToCelsius(212);

            // Assert
            Assert.AreEqual(100.0, result, 0.001);
        }

        [TestMethod]
        public void FahrenheitToCelsius_EqualPoint_ReturnsMinus40()
        {
            // Arrange
            var converter = new TemperatureConverter();

            // Act
            double result = converter.FahrenheitToCelsius(-40);

            // Assert
            Assert.AreEqual(-40.0, result, 0.001);
        }
    }
}
