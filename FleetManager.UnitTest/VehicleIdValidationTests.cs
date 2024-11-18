namespace FleetManager.UnitTest
{
    public class VehicleIdValidationTests
    {
        [TestMethod]
        public void ItShouldReturnTrue_GivenValidIdWithNumericCheckDigit8()
        {
            // Arrange
            var id = "3499135998"; // Prüfziffer: 8

            // Act
            var isValid = Vehicle.CheckId(id);

            // Assert
            Assert.IsTrue(isValid);
        }

        [TestMethod]
        public void ItShouldReturnTrue_GivenValidIdWithNumericCheckDigit6()
        {
            // Arrange
            var id = "0747551006"; // Prüfziffer: 6

            // Act
            var isValid = Vehicle.CheckId(id);

            // Assert
            Assert.IsTrue(isValid);
        }

        [TestMethod]
        public void ItShouldReturnTrue_GivenValidIdWithNumericCheckDigit2()
        {
            // Arrange
            var id = "1572314222"; // Prüfziffer: 2

            // Act
            var isValid = Vehicle.CheckId(id);

            // Assert
            Assert.IsTrue(isValid);
        }

        [TestMethod]
        public void ItShouldReturnTrue_GivenValidIdWithCheckDigitX()
        {
            // Arrange
            var id = "349913599X"; // Prüfziffer: X

            // Act
            var isValid = Vehicle.CheckId(id);

            // Assert
            Assert.IsTrue(isValid);
        }

        [TestMethod]
        public void ItShouldReturnFalse_GivenIdWithIncorrectCheckDigit()
        {
            // Arrange
            var id = "3499135995"; // Prüfziffer ist falsch

            // Act
            var isValid = Vehicle.CheckId(id);

            // Assert
            Assert.IsFalse(isValid);
        }

        [TestMethod]
        public void ItShouldReturnFalse_GivenIdWithInvalidLength()
        {
            // Arrange
            var id = "12345"; // Weniger als 10 Zeichen

            // Act
            var isValid = Vehicle.CheckId(id);

            // Assert
            Assert.IsFalse(isValid);
        }

        [TestMethod]
        public void ItShouldReturnFalse_GivenIdWithNonAlphanumericCharacters()
        {
            // Arrange
            var id = "34991!@599"; // Enthält ungültige Zeichen

            // Act
            var isValid = Vehicle.CheckId(id);

            // Assert
            Assert.IsFalse(isValid);
        }

        [TestMethod]
        public void ItShouldReturnFalse_GivenIdWithNoDigits()
        {
            // Arrange
            var id = "ABCDEFGHIJ"; // Keine Ziffern enthalten

            // Act
            var isValid = Vehicle.CheckId(id);

            // Assert
            Assert.IsFalse(isValid);
        }

        [TestMethod]
        public void ItShouldReturnFalse_GivenIdWithNoLetters()
        {
            // Arrange
            var id = "1234567890"; // Keine Buchstaben enthalten

            // Act
            var isValid = Vehicle.CheckId(id);

            // Assert
            Assert.IsFalse(isValid);
        }

        [TestMethod]
        public void ItShouldReturnFalse_GivenEmptyId()
        {
            // Arrange
            var id = ""; // Leerer String

            // Act
            var isValid = Vehicle.CheckId(id);

            // Assert
            Assert.IsFalse(isValid);
        }

        [TestMethod]
        public void ItShouldReturnFalse_GivenNullId()
        {
            // Arrange
            string id = null; // Null-Wert

            // Act
            var isValid = Vehicle.CheckId(id);

            // Assert
            Assert.IsFalse(isValid);
        }

        // Add a useful test to the test

    }
}
