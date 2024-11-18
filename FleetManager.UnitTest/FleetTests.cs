namespace FleetManager.UnitTest
{
    [TestClass]
    public class FleetTests
    {
        [TestMethod]
        public void ItShouldAddVehicle_GivenValidFleetWeightLimit()
        {
            // Arrange
            var fleet = new Fleet(5000);
            var vehicle = new PassengerVehicle("123456789X", 2000, 30, 10.0);

            // Act
            var result = fleet.AddVehicle(vehicle);

            // Assert
            Assert.IsTrue(result);
            Assert.AreEqual(1, fleet.Vehicles.Count);
        }

        [TestMethod]
        public void ItShouldNotAddVehicle_GivenExcessFleetWeight()
        {
            // Arrange
            var fleet = new Fleet(4000);
            var vehicle = new CargoVehicle("123456789X", 3000, 15, 50.0);

            // Act
            var result = fleet.AddVehicle(vehicle);

            // Assert
            Assert.IsFalse(result);
            Assert.AreEqual(0, fleet.Vehicles.Count);
        }

        [TestMethod]
        public void ItShouldCalculateTotalFleetWeight_GivenMultipleVehicles()
        {
            // Arrange
            var fleet = new Fleet(10000);
            fleet.AddVehicle(new PassengerVehicle("123456789X", 2000, 30, 10.0));
            fleet.AddVehicle(new CargoVehicle("987654321X", 3000, 10, 50.0));

            // Act
            var totalWeight = fleet.GetFleetWeight();

            // Assert
            Assert.AreEqual(2000 + 30 * 70 + 3000 + 10, totalWeight);
        }

        [TestMethod]
        public void ItShouldReturnMostProfitableVehicle_GivenMultipleVehicles()
        {
            // Arrange
            var fleet = new Fleet(10000);
            var vehicle1 = new PassengerVehicle("123456789X", 2000, 30, 10.0); // Revenue = 300
            var vehicle2 = new CargoVehicle("987654321X", 3000, 10, 50.0);    // Revenue = 500
            fleet.AddVehicle(vehicle1);
            fleet.AddVehicle(vehicle2);

            // Act
            var mostProfitable = fleet.GetMostProfitableVehicle();

            // Assert
            Assert.AreEqual(vehicle2, mostProfitable);
        }

        [TestMethod]
        public void ItShouldAddPassengersToVehicle_GivenValidVehicleID()
        {
            // Arrange
            var fleet = new Fleet(10000);
            var vehicle = new PassengerVehicle("123456789X", 2000, 30, 10.0);
            fleet.AddVehicle(vehicle);

            // Act
            var result = fleet.AddPassengersToVehicle("123456789X", 10);

            // Assert
            Assert.IsTrue(result);
            Assert.AreEqual(40, vehicle.PassengerCount);
        }

        [TestMethod]
        public void ItShouldNotAddPassengers_GivenInvalidVehicleID()
        {
            // Arrange
            var fleet = new Fleet(10000);
            fleet.AddVehicle(new PassengerVehicle("123456789X", 2000, 30, 10.0));

            // Act
            var result = fleet.AddPassengersToVehicle("INVALID_ID", 10);

            // Assert
            Assert.IsFalse(result);
        }
    }
}
