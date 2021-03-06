using System;

using NUnit.Framework;

namespace Tests
{
    [TestFixture]
    public class DatabaseTests
    {
        private Database database;
        private readonly int[] initialData = new int[] { 1, 2 };

        [SetUp]
        public void Setup()
        {
            this.database = new Database(initialData);
        }

        [Test]
        public void TestIfConstructorWorksCorrectly()
        {
            // Arrange
            int[] data = new int[] { 1, 2, 3 };
            this.database = new Database(data);

            // Act
            int expectedCount = data.Length;
            int actualCount = this.database.Count;

            // Assert
            Assert.AreEqual(expectedCount, actualCount);
        }

        [Test]
        public void ConstructorShouldThrowExceptionWhenInitializinWithBiggerCollection()
        {
            // Arrange
            int[] data = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17 };

            // Assert
            Assert.Throws<InvalidOperationException>(() =>
            {
                this.database = new Database(data); // Act
            });
        }

        [Test]
        public void AddShouldIncreaseCountWhenAddedSuccessfully()
        {
            // Act
            this.database.Add(3);

            int expextedCount = 3;
            int actualCount = this.database.Count;

            // Assert
            Assert.AreEqual(expextedCount, actualCount);
        }

        [Test]
        public void AddShoulThrowExceptionWhenDatabaseIsFull()
        {
            // Arrange
            for (int i = 3; i <= 16; i++)
            {
                this.database.Add(i);
            }

            // Assert
            Assert.Throws<InvalidOperationException>(() =>
            {
                this.database.Add(17); // Act
            });
        }

        [Test]
        public void RemoveShouldDecreaseCountWhenSuccessful()
        {
            // Act
            this.database.Remove();

            // Arrange
            int expectedCount = 1;
            int actualCount = this.database.Count;

            // Assert
            Assert.AreEqual(expectedCount, actualCount);
        }

        [Test]
        public void REmoveShouldThrowExceptionWhenDatabaseIsEmpty()
        {
            // Arrange
            this.database.Remove();
            this.database.Remove();

            // Assert
            Assert.Throws<InvalidOperationException>(() =>
            {
                this.database.Remove(); // Act
            });
        }

        [TestCase(new int[] { 1, 2, 3 })]
        [TestCase(new int[] { })]
        [TestCase(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15 ,16 })]
        public void FetchShouldReturnCopyOfData(int[] expectedData)
        {
            // Arrange
            this.database = new Database(expectedData);

            // Act
            int[] actualData = this.database.Fetch();

            // Assert
            CollectionAssert.AreEqual(expectedData, actualData);
        }
    }
}