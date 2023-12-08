using NUnit.Framework;

namespace TestApp.UnitTests;

public class EmailValidatorTests
{
    [TestCase("desi_andreeva@abv.bg")]
    [TestCase("heyho@strat.co.uk")]
    [TestCase("desi+test@unicursal.group")]
    public void Test_ValidEmails_ReturnsTrue(string email)
    {
        // Arrange


        // Act
        bool result = EmailValidator.IsValidEmail(email);

        // Assert
        Assert.That(result, Is.True);
    }

    [TestCase("desi_^?=andreeva. @abv.bg")]
    [TestCase("heyho@strat.co.u")]
    [TestCase("desi+test-.unicursal.group")]
    public void Test_InvalidEmails_ReturnsFalse(string email)
    {
        // Arrange
        

        // Act
        bool result = EmailValidator.IsValidEmail(email);
        
        // Assert
        Assert.That(result, Is.False);
    }
}
