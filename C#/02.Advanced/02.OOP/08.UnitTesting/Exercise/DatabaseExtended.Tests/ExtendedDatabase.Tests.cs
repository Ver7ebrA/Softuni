//using ExtendedDatabase;
using NUnit.Framework;
using System;

namespace Tests
{
    [TestFixture]
    public class ExtendedDatabaseTests
    {
        private ExtendedDatabase database;
        private Person firstPerson;
        private Person secondPerson;

        [SetUp]
        public void Setup()
        {
            this.firstPerson = new Person(1, "Pesho");
            this.secondPerson = new Person(2, "Gosho");
            this.database = new ExtendedDatabase(new Person[] { this.firstPerson, this.secondPerson });
        }

        [Test]
        public void TestIfConstructorWorksCorrectly()
        {
            // Arrange
            Person[] persons = new Person[] { this.firstPerson, this.secondPerson };

            // Act
            this.database = new ExtendedDatabase(persons);

            // Assert
            Assert.AreEqual(persons.Length, this.database.Count);
        }

        [Test]
        public void ConstructorShouldThrowExceptionWhenInitializingWithBiggerCollection()
        {
            // Arrange
            Person[] persons = new Person[17];
            for (int i = 0; i < 17; i++)
            {
                persons[i] = new Person(i, i.ToString());
            }

            // Assert
            Assert.Throws<ArgumentException>(() =>
            {
                this.database = new ExtendedDatabase(persons); // Act
            });
        }

        [Test]
        public void AddShouldIncreaseCountWhenSuccessful()
        {
            // Arrange
            Person thirdPerson = new Person(3, "Stamat");
            int expectedCount = this.database.Count + 1;

            // Act
            this.database.Add(thirdPerson);

            // Assert
            Assert.AreEqual(expectedCount, this.database.Count);
        }

        [Test]
        public void AddShouldThrowExceptionWhenDatabaseIsFull()
        {
            // Arrange
            Person[] persons = new Person[16];
            for (int i = 0; i < 16; i++)
            {
                persons[i] = new Person(i, i.ToString());
            }

            this.database = new ExtendedDatabase(persons);
            Person newPerson = new Person(3, "Stamat");

            // Assert
            Assert.Throws<InvalidOperationException>(() =>
            {
                this.database.Add(newPerson); // Act
            });
        }

        [Test]
        public void AddShouldThrowExceptionWhenAddingPersonWithTheSameName()
        {
            //Arrange
            Person newPerson = new Person(3, this.firstPerson.UserName);

            // Assert
            Assert.Throws<InvalidOperationException>(() =>
            {
                this.database.Add(newPerson); // Act
            });
        }

        [Test]
        public void AddShouldThrowExceptionWhenAddingPersonWithTheSameId()
        {
            // Arrange
            Person newPerson = new Person(firstPerson.Id, "Stamat");

            // Assert
            Assert.Throws<InvalidOperationException>(() =>
            {
                this.database.Add(newPerson); // Act
            });
        }

        [Test]
        public void RemoveShouldDecreaseCountWhenSuccessful()
        {
            //Arrange
            int expectedCount = this.database.Count - 1;

            // Act
            this.database.Remove();

            // Assert
            Assert.AreEqual(expectedCount, this.database.Count);
        }

        [Test]
        public void RemoveShouldThrowExceptionWhenDatabaseIsEmpty()
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

        [Test]
        public void FindByUsernameShouldReturnPersonWhenSuccessful()
        {
            // Arrange
            Person expectedPerson = this.firstPerson;

            // Act
            Person foundPerson = this.database.FindByUsername(this.firstPerson.UserName);

            // Assert
            Assert.AreEqual(expectedPerson, foundPerson);
        }

        [Test]
        public void FindByUsernameShouldThrowExceptionWhenUsernameIsNull()
        {
            // Arrange
            string name = null;

            // Assert
            Assert.Throws<ArgumentNullException>(() =>
            {
                this.database.FindByUsername(name); // Act
            });
        }

        [Test]
        public void FindByUsernameShouldThrowExceptionWhenUsernameIsEmpty()
        {
            // Arrange
            string name = String.Empty;

            // Assert
            Assert.Throws<ArgumentNullException>(() =>
            {
                this.database.FindByUsername(name); // Act
            });
        }

        [Test]
        public void FindByUsernameShouldThrowExceptionWhenSuchNameDoesntExist()
        {
            // Arrange
            string name = "Stamat";

            // Assert
            Assert.Throws<InvalidOperationException>(() =>
            {
                this.database.FindByUsername(name); // Act
            });
        }

        [Test]
        public void FindMyUsernameShouldThrowExceptionBecauseIsCaseSensitive()
        {
            // Arrange
            string name = this.firstPerson.UserName.ToUpper();

            // Assert
            Assert.Throws<InvalidOperationException>(() =>
            {
                this.database.FindByUsername(name); // Act
            });
        }

        [Test]
        public void FindByIdShouldReturnPersonWhenSuccessful()
        {
            // Arrange
            long id = this.firstPerson.Id;
            Person expectedPerson = this.firstPerson;

            // Act
            Person foundPerson = this.database.FindById(id);

            // Assert
            Assert.AreEqual(expectedPerson, foundPerson);
        }

        [Test]
        public void FindByIdShouldThrowExceptionWhenIdIsNegative()
        {
            // Arrange
            int id = -3;

            // Assert
            Assert.Throws<ArgumentOutOfRangeException>(() =>
            {
                this.database.FindById(id); // Act
            });
        }

        [Test]
        public void FindByIdShouldThrowExceptionWhenNoPersonWithThisIdExist()
        {
            // Arrange
            int id = 3;

            // Assert
            Assert.Throws<InvalidOperationException>(() =>
            {
                this.database.FindById(id); // Act
            });
        }
    }
}