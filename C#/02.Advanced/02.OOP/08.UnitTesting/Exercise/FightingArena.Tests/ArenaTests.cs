using System;

using NUnit.Framework;

namespace Tests
{
    [TestFixture]
    public class ArenaTests
    {
        private Arena arena;
        private Warrior warrior;
        private Warrior attacker;
        private Warrior defender;

        [SetUp]
        public void Setup()
        {
            this.arena = new Arena();
            this.warrior = new Warrior("Pesho", 5, 50);
            this.attacker = new Warrior("Pesho", 10, 80);
            this.defender = new Warrior("Gosho", 5, 60);
        }

        [Test]
        public void TestIfConstructorWorksCorrectly()
        {
            // Assert
            Assert.IsNotNull(this.arena.Warriors);
        }

        [Test]
        public void EnrollShouldAddTheWarriorToTheArena()
        {
            // Act
            this.arena.Enroll(warrior);

            // Assert
            Assert.That(this.arena.Warriors, Has.Member(this.warrior));
        }

        [Test]
        public void EnrollShouldEncraseCount()
        {
            // Arrange
            int expectedCount = 2;
            
            // Act
            this.arena.Enroll(this.warrior);
            this.arena.Enroll(new Warrior("Gosho", 5, 60));
            int actualCount = this.arena.Count;

            // Assert
            Assert.AreEqual(expectedCount, actualCount);
        }

        [Test]
        public void EnrollingTheSameWarriorShouldThrowException()
        {
            // Arrange
            this.arena.Enroll(this.warrior);

            // Assert
            Assert.Throws<InvalidOperationException>(() =>
            {
                this.arena.Enroll(this.warrior); // Act
            });
        }

        [Test]
        public void EnrollTwoWarriorsWithSameNameShouldThrowException()
        {
            // Arrange
            this.arena.Enroll(this.warrior);

            // Assert
            Assert.Throws<InvalidOperationException>(() =>
            {
                this.arena.Enroll(attacker); // Act
            });
        }

        [Test]
        public void TestWithFightingWithMissingAttacker()
        {
            // Arrange
            this.arena.Enroll(this.defender);

            // Assert
            Assert.Throws<InvalidOperationException>(() =>
            {
                this.arena.Fight(this.attacker.Name, this.defender.Name); // Act
            });
        }

        [Test]
        public void TestFightingWithMissingDefender()
        {
            // Arrange
            this.arena.Enroll(this.attacker);

            // Assert
            Assert.Throws<InvalidOperationException>(() =>
            {
                this.arena.Fight(this.attacker.Name, this.defender.Name); // Act
            });
        }

        [Test]
        public void TestFoghtingBetweenTwoWarriors()
        {
            // Arrange
            this.arena.Enroll(this.attacker);
            this.arena.Enroll(this.defender);

            int expectedAttackerHP = this.attacker.HP - this.defender.Damage;
            int expectedDefenderHP = this.defender.HP - this.attacker.Damage;

            // Act
            this.arena.Fight(this.attacker.Name, this.defender.Name);

            // Assert
            Assert.AreEqual(expectedAttackerHP, this.attacker.HP);
            Assert.AreEqual(expectedDefenderHP, this.defender.HP);
        }
    }
}
