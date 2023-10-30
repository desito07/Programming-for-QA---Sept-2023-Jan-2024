using NUnit.Framework;

namespace TestApp.UnitTests;

public class EmailTests
{
    [Test]
    public void Test_IsValidEmail_ValidEmail()
    {
        // Arrange
        string validEmail = "test@example.com";

        // Act
        bool result = Email.IsValidEmail(validEmail);

        // Assert
        Assert.That(result, Is.True);
    }

    [Test]
    public void Test_IsValidEmail_InvalidEmail()
    {
        // Arrange
        string notValidEmail = "test.example.com";

        // Act
        bool result = Email.IsValidEmail(notValidEmail);

        // Assert
        Assert.IsFalse(result);
    }

    [Test]
    public void Test_IsValidEmail_NullInput()
    {
        // Arrange
        string? nullEmail = null;

        // Act
        bool result = Email.IsValidEmail(nullEmail);

        // Assert
        Assert.That(result, Is.False);
    }
}
