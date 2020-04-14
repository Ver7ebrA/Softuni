using NUnit.Framework;

[TestFixture]
public class DummyTests
{
    [Test]
    public void DummyLosesHealthAfterAttack()
    {
        // Arrange
        Dummy dummy = new Dummy(20, 10);

        // Act
        dummy.TakeAttack(5);

        // Assert
        Assert.That(dummy.Health, Is.EqualTo(15));
    }

    [Test]
    public void DeadDummyCantBeAttacked()
    {
        // Arrange
        Dummy dummy = new Dummy(0, 10);

        // Assert
        Assert.That(() => dummy.TakeAttack(5), // Act
            Throws.InvalidOperationException
            .With.Message.EqualTo("Dummy is dead."));
    }

    [Test]
    public void DeadDummyGivesExperience()
    {
        // Arrange
        Dummy dummy = new Dummy(0, 10);

        // Act
        int experience = dummy.GiveExperience();

        // Assert
        Assert.That(experience, Is.EqualTo(10));
    }

    [Test]
    public void AlliveDummyDoesntGiveExperience()
    {
        // Arrange
        Dummy dummy = new Dummy(10, 10);     

        // Assert
        Assert.That(() => dummy.GiveExperience(), // Act
            Throws.InvalidOperationException
            .With.Message.EqualTo("Target is not dead."));
    }

}
