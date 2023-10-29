using NUnit.Framework;
namespace TestApp.UnitTests;

public class StringReverseTests
{
    [Test]
    public void Test_Reverse_WhenGivenEmptyString_ReturnsEmptyString()
    {
        // Arrange
        string input = "";

        // Act
        string actual = StringReverse.Reverse(input);

        // Assert
        Assert.AreEqual("", actual);
    }

    [Test]
    public void Test_Reverse_WhenGivenSingleCharacterString_ReturnsSameCharacter()
    {
        // Arrange
        string input = "s";

        // Act
        string actual = StringReverse.Reverse(input);

        // Assert
        Assert.AreEqual("s", actual);
        Assert.AreEqual(1, actual.Length);
    }

    [Test]
    public void Test_Reverse_WhenGivenNormalString_ReturnsReversedString()
    {
        // Arrange
        string input = "test";

        // Act
        string actual = StringReverse.Reverse(input);

        // Assert
        Assert.AreEqual("tset", actual);
        Assert.AreEqual(input.Length, actual.Length);
    }
}
