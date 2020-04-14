//using CarManager;
using System;

using NUnit.Framework;

namespace Tests
{
    public class CarTests
    {
        private string make;
        private string model;
        private double fuelConsumption;
        private double fuelAmount;
        private double fuelCapacity;
        private Car car;

        [SetUp]
        public void Setup()
        {
            this.make = "Lada";
            this.model = "Samara";
            this.fuelConsumption = 1.0;
            this.fuelAmount = 0;
            this.fuelCapacity = 20.0;
            this.car = new Car(this.make, this.model, this.fuelConsumption, this.fuelCapacity);
        }

        [Test]
        public void TestIfConstructorWorksProperly()
        {
            // Assert
            Assert.AreEqual(this.make, this.car.Make);
            Assert.AreEqual(this.model, this.car.Model);
            Assert.AreEqual(this.fuelConsumption, this.car.FuelConsumption);
            Assert.AreEqual(this.fuelAmount, this.car.FuelAmount);
            Assert.AreEqual(this.fuelCapacity, this.car.FuelCapacity);
        }

        [Test]
        public void ConstructorShouldThrowExceptionWhenMakeIsNull()
        {
            // Arrange
            string nullMake = null;

            // Assert
            Assert.Throws<ArgumentException>(() =>
            {
                this.car = new Car(nullMake, this.model, this.fuelConsumption, this.fuelCapacity); // Act
            });
        }

        [Test]
        public void ConstructorShouldThrowExceptionWhenMakeIsEmpty()
        {
            // Arrange
            string emptyMake = String.Empty;

            // Assert
            Assert.Throws<ArgumentException>(() =>
            {
                this.car = new Car(emptyMake, this.model, this.fuelConsumption, this.fuelCapacity); // Act
            });
        }

        [Test]
        public void ConstructorShouldThrowExceptionWhenModelIsNull()
        {
            // Arrange
            string nullModel = null;

            // Assert
            Assert.Throws<ArgumentException>(() =>
            {
                this.car = new Car(this.make, nullModel, this.fuelConsumption, this.fuelCapacity); // Act
            });
        }

        [Test]
        public void ConstructorShouldThrowExceptionWhenModelIsEmpty()
        {
            // Arrange
            string emptyModel = String.Empty;

            // Assert
            Assert.Throws<ArgumentException>(() =>
            {
                this.car = new Car(this.make, emptyModel, this.fuelConsumption, this.fuelCapacity); // Act
            });
        }

        [TestCase(0)]
        [TestCase(-13.0)]
        public void ConstructorShouldThrowExceptionWhenFuelConsumptionIsZeroOrNEgative(double exFuelConsumption)
        {
            // Assert
            Assert.Throws<ArgumentException>(() =>
            {
                this.car = new Car(this.make, this.model, exFuelConsumption, this.fuelCapacity); // Act
            });
        }

        [TestCase(0)]
        [TestCase(-13.0)]
        public void ConstructorShouldThrowExceptionWhenFuelCapacityIsZeroOrNegative(double exFuelCapacity)
        {
            // Assert
            Assert.Throws<ArgumentException>(() =>
            {
                this.car = new Car(this.make, this.model, this.fuelConsumption, exFuelCapacity); // Act
            });
        }

        [Test]
        public void RefuelShoulIncreaseFuelWhenSuccessful()
        {
            // Arrange
            double fuel = 10.0;
            double expectedFuel = this.car.FuelAmount + fuel;

            // Act
            this.car.Refuel(fuel);
            double actualFuel = this.car.FuelAmount;

            // Assert
            Assert.AreEqual(expectedFuel, actualFuel);
        }

        [Test]
        public void RefuelShouldFillFuelCapacityWhenLarger()
        {
            // Arrange
            double fuel = 30.0;
            double expectedFuel = this.car.FuelCapacity;

            // Act
            this.car.Refuel(fuel);
            double actualFuel = this.car.FuelAmount;

            // Assert
            Assert.AreEqual(expectedFuel, actualFuel);
        }

        [TestCase(0)]
        [TestCase(-13.0)]
        public void RefuelShouldThrowExceptionWhenFuelIsZeroOrNegative(double exFuel)
        {
            // Assert
            Assert.Throws<ArgumentException>(() =>
            {
                this.car.Refuel(exFuel); //Act
            });
        }

        [Test]
        public void DriveShouldDecreaseFuelAmountWhenSuccessful()
        {
            // Arrange
            double distance = 200.0;
            this.car.Refuel(20.0);
            double expectedFuel = this.car.FuelAmount - ((distance/100) * this.car.FuelConsumption);

            // Act
            this.car.Drive(distance);
            double actualFuel = this.car.FuelAmount;
            // Assert
            Assert.AreEqual(expectedFuel, actualFuel);
        }

        [Test]
        public void DriveShouldThrowExceptionWhenFailed()
        {
            // Arrange
            double distance = 200.0;

            // Assert
            Assert.Throws<InvalidOperationException>(() =>
            {
                this.car.Drive(distance);
            });
        }
    }
    
}