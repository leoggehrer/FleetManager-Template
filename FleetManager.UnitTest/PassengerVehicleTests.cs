namespace FleetManager.UnitTest
{
    [TestClass]
    public class PassengerVehicleTests
    {
        [TestMethod]
        public void ItShouldCalculateRevenue_GivenValidPassengerCountAndTicketPrice()
        {
            // Arrange
            var vehicle = new PassengerVehicle("123456789X", 2000, 30, 10.0);

            // Act
            var revenue = vehicle.GetRevenue();

            // Assert
            Assert.AreEqual(300.0, revenue);
        }

        [TestMethod]
        public void ItShouldCapPassengerCount_GivenExcessPassengerCount()
        {
            // Arrange
            var vehicle = new PassengerVehicle("123456789X", 2000, 60, 10.0);

            // Act
            var passengerCount = vehicle.PassengerCount;

            // Assert
            Assert.AreEqual(50, passengerCount);
        }

        [TestMethod]
        public void ItShouldAssignDefaultPassengerCount_GivenNoPassengerCount()
        {
            // Arrange
            var vehicle = new PassengerVehicle("123456789X", 2000, ticketPrice: 10.0);

            // Act
            var passengerCount = vehicle.PassengerCount;

            // Assert
            Assert.AreEqual(20, passengerCount);
        }

        [TestMethod]
        public void ItShouldCalculateTotalWeight_GivenPassengerCount()
        {
            // Arrange
            var vehicle = new PassengerVehicle("123456789X", 2000, 30, 10.0);

            // Act
            var totalWeight = vehicle.GetTotalWeight();

            // Assert
            Assert.AreEqual(2000 + 30 * 70, totalWeight);
        }

        // Add a useful test to the test

    }
}
