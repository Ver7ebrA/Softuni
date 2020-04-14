namespace Robots.Tests
{
    using System;
    using System.Collections.Generic;
    using NUnit.Framework;

    [TestFixture]
    public class RobotsTests
    {
        private Robot firstRobot;
        private Robot secondRobot;
        private RobotManager robotManager;

        [SetUp]
        public void SetUp()
        {
            this.firstRobot = new Robot("Robot1", 100);
            this.secondRobot = new Robot("Robot2", 200);
            this.robotManager = new RobotManager(2);
        }

        [Test]
        public void RobotConstructorShouldInitializeCorrectInstance()
        {
            // Assert
            Assert.AreEqual("Robot1", firstRobot.Name);
            Assert.AreEqual(100, firstRobot.Battery);
            Assert.AreEqual(100, firstRobot.MaximumBattery);
        }

        [Test]
        public void RobotManagerConstructorShouldInitializeInstance()
        {
            // Assert
            Assert.IsNotNull(this.robotManager);
        }

        [Test]
        public void RobotMangerConstructorShouldHaveCorrectCapacity()
        {
            // Assert
            Assert.AreEqual(2, this.robotManager.Capacity);
        }

        [Test]
        public void RobotManagerConstructorThrowsArgumentForNegativeCapacity()
        {
            // Assert
            Assert.Throws<ArgumentException>(() =>
            {
                this.robotManager = new RobotManager(-3); // Act
            }, "Invalid capacity!");
        }

        [Test]
        public void RobotManagerCountShouldReturnCorrectValue()
        {
            // Arrange
            this.robotManager.Add(firstRobot);
            this.robotManager.Add(secondRobot);
            int expectedCount = 2;

            // Act
            int actialCount = this.robotManager.Count;

            // Assert
            Assert.AreEqual(expectedCount, actialCount);
        }

        [Test]
        public void AddMethodShouldAddWhenSuccessful()
        {
            // Arrange
            int expectedCount = 1;

            // Act
            this.robotManager.Add(firstRobot);

            // Assert
            Assert.AreEqual(expectedCount, this.robotManager.Count);
        }

        [Test]
        public void AddMethodShouldThrowExceptionWhenRobotAlreadyExist()
        {
            // Arrange
            this.robotManager.Add(firstRobot);

            // Assert
            Assert.Throws<InvalidOperationException>(() =>
            {
                this.robotManager.Add(firstRobot); // Act
            }, $"There is already a robot with name {this.firstRobot.Name}!");
        }

        [Test]
        public void AddMethodShouldThrowExceptionWhenNotEnoughCapacity()
        {
            // Arrange
            this.robotManager.Add(firstRobot);
            this.robotManager.Add(secondRobot);
            Robot thirdRobot = new Robot("Robot3", 300);

            // Assert
            Assert.Throws<InvalidOperationException>(() =>
            {
                this.robotManager.Add(thirdRobot); // Act
            }, "Not enough capacity!");
        }

        [Test]
        public void RemoveMethodShouldRemoveRobotWhenSuccessful()
        {
            // Arrange
            this.robotManager.Add(firstRobot);
            this.robotManager.Add(secondRobot);

            // Act
            this.robotManager.Remove(firstRobot.Name);
            int expectedCount = 1;

            // Assert
            Assert.AreEqual(expectedCount, this.robotManager.Count);
        }

        [Test]
        public void RemoveMethodShouldThrowExceptionWhenRobotDoesntExist()
        {
            // Arrange
            this.robotManager.Add(firstRobot);

            // Assert
            Assert.Throws<InvalidOperationException>(() =>
            {
                this.robotManager.Remove(secondRobot.Name);  // Act
            }, $"Robot with the name {secondRobot.Name} doesn't exist!");
        }

        [Test]
        public void WorkMethodShouldDecreaseRobotEnergy()
        {
            // Arrange
            this.robotManager.Add(firstRobot);

            // Act
            this.robotManager.Work(firstRobot.Name, "work", 10);

            // Assert
            Assert.AreEqual(90, this.firstRobot.Battery);
        }

        [Test]
        public void WorkMethodShouldThrowExceptionWhenRobotDoesntExist()
        {
            //Arrange
            this.robotManager.Add(firstRobot);

            // Assert
            Assert.Throws<InvalidOperationException>(() =>
            {
                this.robotManager.Work(secondRobot.Name, "work", 10); // Act
            }, $"Robot with the name {secondRobot.Name} doesn't exist!");
        }

        [Test]
        public void WorkMethodShouldThrowExceptionWhenNotEboughBattery()
        {
            // Arrange
            this.robotManager.Add(firstRobot);

            // Assert
            Assert.Throws<InvalidOperationException>(() =>
            {
                this.robotManager.Work(firstRobot.Name, "work", 150); // Act
            }, $"{firstRobot.Name} doesn't have enough battery!");
        }

        [Test]
        public void ChargeMethodShouldChargeBattery()
        {
            // Arrange
            this.robotManager.Add(firstRobot);
            this.robotManager.Work(firstRobot.Name, "Work", 50);

            // Act
            this.robotManager.Charge(firstRobot.Name);

            // Assert
            Assert.AreEqual(firstRobot.MaximumBattery, firstRobot.Battery);
        }

        [Test]
        public void ChargeMethodShouldThrowExceptionWhenRobotDoesntExist()
        {
            // Arrange
            this.robotManager.Add(firstRobot);

            // Assert
            Assert.Throws<InvalidOperationException>(() =>
            {
                this.robotManager.Charge(secondRobot.Name);  // Act
            }, $"Robot with the name {secondRobot.Name} doesn't exist!");
        }
    }
}
