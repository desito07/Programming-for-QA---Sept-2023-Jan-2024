using NUnit.Framework;

using System;

namespace TestApp.UnitTests;

public class FakeTests
{
    [Test]
    public void Test_RemoveStringNumbers_NullInput_ThrowsException()
    {
        // Arrange
        char[]? input = null;

        // Act + Assert
        Assert.That(() => Fake.RemoveStringNumbers(input), Throws.ArgumentException);
    }

    [Test]
    public void Test_RemoveStringNumbers_RemovesDigitsFromCharArray()
    {
        // Arrange
        char[] input = new char[] { '2', 'a', '6', 'd', 'D' };

        //Act 
        char[] result = Fake.RemoveStringNumbers(input);

        //Assert
        Assert.AreEqual(result, new char[] { 'a', 'd', 'D' });
    }

    [Test]
    public void Test_RemoveStringNumbers_NoDigitsInInput_ReturnsSameArray()
    {
        // Arrange
        char[] input = new char[] {'a', 'b', 'c', 'd' };

        //Act 
        char[] result = Fake.RemoveStringNumbers(input);

        //Assert
        Assert.AreEqual(result, new char[] { 'a', 'b', 'c', 'd' });
        //Assert.AreEqual(result, input});
    }

    [Test]
    public void Test_RemoveStringNumbers_EmptyArray_ReturnsEmptyArray()
    {
        // Arrange
        char[] input = new char[] { '0', '1', '2', '3' };

        //Act 
        char[] result = Fake.RemoveStringNumbers(input);

        //Assert
        Assert.That(result, Is.Empty);
    }
}
