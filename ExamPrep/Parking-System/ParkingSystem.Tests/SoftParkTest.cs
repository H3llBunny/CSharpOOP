namespace ParkingSystem.Tests
{
    using NUnit.Framework;

    public class SoftParkTest
    {
        SoftPark parking;
        Car car;

        [SetUp]
        public void Setup()
        {
            this.parking = new SoftPark();
            this.car = new Car("CyberTruck", "H 6969 AA");
        }

        [Test]
        public void Parking_ReturnsDictionaryWithParkingSpots()
        {
            Assert.AreEqual(12, this.parking.Parking.Count);
        }

        [Test]
        public void ParkCar_ThrowsArgumentExceptionWhenParkSpotDoesNotExist()
        {
            Assert.That(() => this.parking.ParkCar("A5", this.car), Throws.ArgumentException
                .With.Message.Contains("Parking spot doesn't exists!"));
        }

        [Test]
        public void ParkCar_ThrowsArgumentExceptionWhenCarSpotAlreadyTaken()
        {
            this.parking.ParkCar("A1", this.car);
            Car car2 = new Car("Tesla", "H 420 XX");

            Assert.That(() => this.parking.ParkCar("A1", car2), Throws.ArgumentException
                .With.Message.Contains("Parking spot is already taken!"));
        }

        [Test]
        public void ParkCar_ThrowsArgumentExceptionWhenCarAlreadyExist()
        {
            this.parking.ParkCar("A1", this.car);

            Assert.That(() => this.parking.ParkCar("A2", this.car), Throws.InvalidOperationException
                .With.Message.Contains("Car is already parked!"));
        }

        [Test]
        public void ParkCar_ParksCarAtSpecificSpot()
        {
            this.parking.ParkCar("A1", this.car);

            Assert.AreEqual(this.car, this.parking.Parking["A1"]);
        }

        [Test]
        public void ParkCar_ReturnsMessageWhenCarIsParkedSuccessfully()
        {
            Assert.AreEqual($"Car:{this.car.RegistrationNumber} parked successfully!",
                this.parking.ParkCar("A1", this.car));
        }

        [Test]
        public void RemoveCar_ThrowsArgumentExceptionWhenParkSpotDoesNotExist()
        {
            Assert.That(() => this.parking.RemoveCar("A5", this.car), Throws.ArgumentException
                .With.Message.Contains("Parking spot doesn't exists!"));
        }

        [Test]
        public void RemoveCar_ThrowsArgumenExceptionWhenCarDoesNotExist()
        {
            Assert.That(() => this.parking.RemoveCar("A1", this.car), Throws.ArgumentException
                .With.Message.Contains("Car for that spot doesn't exists!"));
        }

        [Test]
        public void RemoveCar_RemovesCar()
        {
            this.parking.ParkCar("A1", this.car);
            this.parking.RemoveCar("A1", this.car);

            Assert.AreEqual(null, this.parking.Parking["A1"]);
        }

        [Test]
        public void RemoveCar_ReturnsMessageWhenCarIsRemovedSuccessfully()
        {
            this.parking.ParkCar("A1", this.car);

            Assert.AreEqual($"Remove car:{this.car.RegistrationNumber} successfully!",
                this.parking.RemoveCar("A1", this.car));
        }
    }
}