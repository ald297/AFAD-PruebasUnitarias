using System;
using Xunit;
using AFAD.Cadenas;

namespace AFAD.Cadenas.UnitTestAppxUnit
{
    public class StringManipulatorTests
    {
        [Fact]
        public void ReverseString_ShouldReturnReversedString()
        {
            // Arrange
            var manipulator = new StringManipulator();
            string input = "hola";

            // Act
            string result = manipulator.ReverseString(input);

            // Assert
            Assert.Equal("aloh", result);
        }

        [Fact]
        public void ReverseString_Palindrome_ShouldReturnSameString()
        {
            // Arrange
            var manipulator = new StringManipulator();
            string input = "reconocer";

            // Act
            string result = manipulator.ReverseString(input);

            // Assert
            Assert.Equal("reconocer", result);
        }

        [Fact]
        public void ReverseString_EmptyString_ShouldReturnEmptyString()
        {
            // Arrange
            var manipulator = new StringManipulator();
            string input = "";

            // Act
            string result = manipulator.ReverseString(input);

            // Assert
            Assert.Equal("", result);
        }

        [Fact]
        public void ReverseString_NullInput_ShouldThrowArgumentNullException()
        {
            // Arrange
            var manipulator = new StringManipulator();

            // Act & Assert
            Assert.Throws<ArgumentNullException>(() => manipulator.ReverseString(null!));
        }

        [Fact]
        public void RemoveSpaces_ShouldRemoveAllSpaces()
        {
            // Arrange
            var manipulator = new StringManipulator();
            string input = "Hola Mundo Desde CSharp";

            // Act
            string result = manipulator.RemoveSpaces(input);

            // Assert
            Assert.Equal("HolaMundoDesdeCSharp", result);
        }

        [Fact]
        public void RemoveSpaces_MultipleConsecutiveSpaces_ShouldRemoveAll()
        {
            // Arrange
            var manipulator = new StringManipulator();
            string input = "   a   b    c   ";

            // Act
            string result = manipulator.RemoveSpaces(input);

            // Assert
            Assert.Equal("abc", result);
        }

        [Fact]
        public void RemoveSpaces_NullInput_ShouldThrowArgumentNullException()
        {
            // Arrange
            var manipulator = new StringManipulator();

            // Act & Assert
            Assert.Throws<ArgumentNullException>(() => manipulator.RemoveSpaces(null!));
        }
    }
}
