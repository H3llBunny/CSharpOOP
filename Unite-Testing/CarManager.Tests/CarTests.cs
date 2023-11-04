using NUnit.Framework;
using System;
using System.Reflection;

namespace CarManager.Tests
{
    public class CarTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void CarMakeIsEmpty()
        {
            string make = string.Empty;
            Assert.That(() => new Car(make, "Model", 10.0, 50.0), Throws.ArgumentException
                .With.Message.Contains("Make cannot be null or empty!"));
        }


        [Test]
        public void CarModelIsEmpty()
        {
            string model = string.Empty;
            Assert.That(() => new Car("Make", model, 10.0, 50.0), Throws.ArgumentException
                .With.Message.Contains("Model cannot be null or empty!"));
        }

        [Test]
        public void FuelConsumptionIsZeroOrNegative()
        {
            int fuelConsumption = -1;
            Assert.That(() => new Car("Make", "Model", fuelConsumption, 50.0), Throws.ArgumentException
                .With.Message.Contains("Fuel consumption cannot be zero or negative!"));
        }

        [Test]
        public void FuelCapacityIsZeroOrNegative()
        {
            int fuelCapacity = -1;
            Assert.That(() => new Car("Make", "Model", 10.0, fuelCapacity), Throws.ArgumentException
                .With.Message.Contains("Fuel capacity cannot be zero or negative!"));
        }

        [Test]
        public void RefuelAmountIsZeroOrNegative()
        {
            var car = new Car("Make", "Model", 10.0, 50.0);
            double fuel = -1;
            Assert.That(() => car.Refuel(fuel), Throws.ArgumentException
                .With.Message.Contains("Fuel amount cannot be zero or negative!"));
        }

        [Test]
        public void DriveWithouthEnoughFuel()
        {
            var car = new Car("Make", "Model", 10.0, 50.0);
            car.Refuel(10.0);
            Assert.That(() => car.Drive(100.1), Throws.InvalidOperationException
                .With.Message.EqualTo("You don't have enough fuel to drive!"));
        }

        [Test]
        public void RefuelAddsFuelToFuelAmount()
        {
            var car = new Car("Make", "Model", 10.0, 50.0);

            car.Refuel(20.0);

            Assert.AreEqual(20.0, car.FuelAmount);
        }

        [Test]
        public void DriveDecreasesFuelAmount()
        {
            var car = new Car("Make", "Model", 10.0, 50.0);
            car.Refuel(30.0);

            car.Drive(100.0);

            Assert.AreEqual(20.0, car.FuelAmount);
        }

        [Test]
        public void RefuelAmountGreaterThanFurlCapacity()
        {
            var car = new Car("Make", "Model", 10.0, 50.0);

            car.Refuel(60.0);

            Assert.AreEqual(50.0, car.FuelAmount);
        }

        [Test]
        public void CarReturnsMakeAndModel()
        {
            var car = new Car("Make", "Model", 10.0, 50.0);

            Assert.AreEqual(car.Make, "Make");
            Assert.AreEqual(car.Model, "Model");
        }
    }
}