namespace FleetManager.UnitTest
{
    [TestClass]
    public class CargoVehicleTests
    {
        [TestMethod]
        public void ItShouldCalculateRevenue_GivenValidCargoWeightAndRate()
        {
            // Arrange
            var vehicle = new CargoVehicle("123456789X", 3000, 10, 50.0);

            // Act
            var revenue = vehicle.GetRevenue();

            // Assert
            Assert.AreEqual(500.0, revenue);
        }

        [TestMethod]
        public void ItShouldCapCargoWeight_GivenExcessCargoWeight()
        {
            // Arrange
            var vehicle = new CargoVehicle("123456789X", 3000, 30, 50.0);

            // Act
            var cargoWeight = vehicle.CargoWeight;

            // Assert
            Assert.AreEqual(20.0, cargoWeight);
        }

        [TestMethod]
        public void ItShouldCalculateTotalWeight_GivenCargoWeight()
        {
            // Arrange
            var vehicle = new CargoVehicle("123456789X", 3000, 15, 50.0);

            // Act
            var totalWeight = vehicle.GetTotalWeight();

            // Assert
            Assert.AreEqual(3000 + 15, totalWeight);
        }

        // Add a useful test to the test
    }
}
