using System;

using NUnit.Framework;

namespace Tests
{
    [TestFixture]
    public class WarriorTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void TestIfConstructorWorksCorrectly()
        {
            // Arrange
            string expectedName = "Pesho";
            int expectedDmg = 50;
            int expectedHP = 100;

            // Act
            Warrior warrior = new Warrior(expectedName, expectedDmg, expectedHP);

            string actualName = warrior.Name;
            int actualDamage = warrior.Damage;
            int actualHP = warrior.HP;

            // Assert
            Assert.AreEqual(expectedName, actualName);
            Assert.AreEqual(expectedDmg, actualDamage);
            Assert.AreEqual(expectedHP, actualHP);
        }

        [Test]
        public void TestWithLikeNullName()
        {
            // Arrange
            string name = null;
            int dmg = 50;
            int hp = 100;

            // Assert
            Assert.Throws<ArgumentException>(() =>
            {
                Warrior warrior = new Warrior(name, dmg, hp); // Act
            });
        }

        [Test]
        public void TestWithLikeEmptyName()
        {
            // Arrange
            string name = String.Empty;
            int dmg = 50;
            int hp = 100;

            // Assert
            Assert.Throws<ArgumentException>(() =>
            {
                Warrior warrior = new Warrior(name, dmg, hp); // Act
            });
        }

        [Test]
        public void TestWithLikeWhitespaceName()
        {
            // Arrange
            string name = "       ";
            int dmg = 50;
            int hp = 100;

            // Assert
            Assert.Throws<ArgumentException>(() =>
            {
                Warrior warrior = new Warrior(name, dmg, hp); // Act
            });
        }

        [Test]
        public void TestWithLikeZeroDamage()
        {
            // Arrange

            string name = "Pesho";
            int dmg = 0;
            int hp = 100;

            // Assert
            Assert.Throws<ArgumentException>(() =>
            {
                Warrior warrior = new Warrior(name, dmg, hp); // Act
            });
        }

        [Test]
        public void TestWithLikeNegativeNumber()
        {
            // Arrange
            string name = "Pesho";
            int dmg = -10;
            int hp = 100;

            // Assert
            Assert.Throws<ArgumentException>(() =>
            {
                Warrior warrior = new Warrior(name, dmg, hp); // Act
            });
        }

        [Test]
        public void TestWithLikeNegativeHP()
        {
            string name = "Pesho";
            int dmg = 10;
            int hp = -10;

            // Assert
            Assert.Throws<ArgumentException>(() =>
            {
                Warrior warrior = new Warrior(name, dmg, hp); // Act
            });
        }

        [Test]
        [TestCase(25)]
        [TestCase(30)]
        public void AttackingEnemyWhenLowHPShouldThrowException(int attackerHP)
        {
            // Arrange
            string attackerName = "Pesho";
            int attackerDmg = 10;

            string defenderName = "Gosho";
            int defenderDmg = 10;
            int defenderHP = 40;

            Warrior attacker = new Warrior(attackerName, attackerDmg, attackerHP);
            Warrior defender = new Warrior(defenderName, defenderDmg, defenderHP);

            // Assert
            Assert.Throws<InvalidOperationException>(() =>
            {
                attacker.Attack(defender); // Act
            });
        }

        [Test]
        [TestCase(25)]
        [TestCase(30)]
        public void AttackingEnemyWithLowHPShouldThrowException(int deffenderHP)
        {
            // Arrange
            string attackerName = "Pesho";
            int attackerDmg = 10;
            int attackerHP = 100;

            string defenderName = "Gosho";
            int defenderDmg = 10;

            Warrior attacker = new Warrior(attackerName, attackerDmg, attackerHP);
            Warrior deffender = new Warrior(defenderName, defenderDmg, deffenderHP);

            // Assert
            Assert.Throws<InvalidOperationException>(() =>
            {
                attacker.Attack(deffender); // Act
            });
        }

        [Test]
        public void AttackingStrongerEnemyShouldThrowException()
        {
            // Arrange
            string attackerName = "Pesho";
            int attackerDmg = 10;
            int attackerHP = 35;

            string defenderName = "Gosho";
            int defenderDmg = 40;
            int deffenderHP = 35;

            Warrior attacker = new Warrior(attackerName, attackerDmg, attackerHP);
            Warrior deffender = new Warrior(defenderName, defenderDmg, deffenderHP);

            // Assert
            Assert.Throws<InvalidOperationException>(() =>
            {
                attacker.Attack(deffender); // Act
            });
        }

        [Test]
        public void AttackingShouldDecreaseHPWhenSuccessfull()
        {
            // Arrange
            string attackerName = "Pesho";
            int attackerDmg = 10;
            int attackerHP = 40;

            string defenderName = "Gosho";
            int defenderDmg = 5;
            int deffenderHP = 50;

            Warrior attacker = new Warrior(attackerName, attackerDmg, attackerHP);
            Warrior deffender = new Warrior(defenderName, defenderDmg, deffenderHP);

            int expectedAttackerHP = attackerHP - defenderDmg;
            int expectedDeffenderHP = deffenderHP - attackerDmg;

            // Act
            attacker.Attack(deffender);

            // Assert
            Assert.AreEqual(expectedAttackerHP, attacker.HP);
            Assert.AreEqual(expectedDeffenderHP, deffender.HP);
        }

        [Test]
        public void TestKillingEnemyWithAttack()
        {
            // Arrange
            string attackerName = "Pesho";
            int attackerDmg = 80;
            int attackerHP = 100;

            string defenderName = "Gosho";
            int defenderDmg = 5;
            int deffenderHP = 50;

            Warrior attacker = new Warrior(attackerName, attackerDmg, attackerHP);
            Warrior deffender = new Warrior(defenderName, defenderDmg, deffenderHP);

            int expectedAttackerHP = attackerHP - defenderDmg;
            int expectedDeffenderHP = 0;

            // Act
            attacker.Attack(deffender);

            // Assert
            Assert.AreEqual(expectedAttackerHP, attacker.HP);
            Assert.AreEqual(expectedDeffenderHP, deffender.HP);
        }
    }
}