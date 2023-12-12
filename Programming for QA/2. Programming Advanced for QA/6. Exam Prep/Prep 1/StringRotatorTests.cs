using NUnit.Framework;

namespace TestApp.Tests;

[TestFixture]
public class StringRotatorTests
{
    [Test]
    public void Test_RotateRight_EmptyString_ReturnsEmptyString()
    {
        //Arrange
        string input = "";
        int positions = 10;

        //Act
        string result = StringRotator.RotateRight(input, 10);

        //Assert
        Assert.AreEqual(input, result);
    }

    [Test]
    public void Test_RotateRight_RotateByZeroPositions_ReturnsOriginalString()
    {
        //Arrange
        string input = "Hello!";
        int positions = 0;

        //Act
        string result = StringRotator.RotateRight(input, 0);

        //Assert
        Assert.AreEqual(input, result);
    }

    [Test]
    public void Test_RotateRight_RotateByPositivePositions_ReturnsRotatedString()
    {
        //Arrange
        string input = "Hello!";
        int positions = 2;
        string expected = "o!Hell";

        //Act
        string result = StringRotator.RotateRight(input, 2);

        //Assert
        Assert.AreEqual(expected, result);
    }

    [Test]
    public void Test_RotateRight_RotateByNegativePositions_ReturnsRotatedString()
    {
        //Arrange
        string input = "Hello!";
        int positions = -2;
        string expected = "o!Hell";

        //Act
        string result = StringRotator.RotateRight(input, -2);

        //Assert
        Assert.AreEqual(expected, result);
    }

    [Test]
    public void Test_RotateRight_RotateByMorePositionsThanStringLength_ReturnsRotatedString()
    {
        //Arrange
        string input = "Hello!";
        int positions = 10;
        string expected = "llo!He";

        //Act
        string result = StringRotator.RotateRight(input, 10);

        //Assert
        Assert.AreEqual(expected, result);
    }
}
