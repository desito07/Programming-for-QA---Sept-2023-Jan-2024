using NUnit.Framework;
using System;

namespace TestApp.Tests;

public class CharacterRangeTests
{
    [Test]
    public void Test_GetRange_WithAAndBInOrder_ReturnsEmptyString()
    {
        //Arrange
        char a = 'a';
        char b = 'b';

        //Act
        string result = CharacterRange.GetRange(a, b);

        //Assert
        Assert.That(result, Is.Empty);
    }

    [Test]
    public void Test_GetRange_WithBAndAInOrder_ReturnsEmptyString()
    {
        //Arrange
        char a = 'a';
        char b = 'b';

        //Act
        string result = CharacterRange.GetRange(b, a);

        //Assert
        Assert.That(result, Is.Empty);
    }

    [Test]
    public void Test_GetRange_WithAAndCInOrder_ReturnsB()
    {
        //Arrange
        char a = 'a';
        char c = 'c';

        //Act
        string result = CharacterRange.GetRange(a, c);

        //Assert
        Assert.That(result, Is.EqualTo("b"));
    }

    [Test]
    public void Test_GetRange_WithDAndGInOrder_Returns_E_F()
    {
        //Arrange
        char a = 'd';
        char c = 'g';

        //Act
        string result = CharacterRange.GetRange(a, c);

        //Assert
        Assert.AreEqual(result, ("e f"));
    }

    [Test]
    public void Test_GetRange_WithXAndZInOrder_Returns_Y()
    {
        //Arrange
        char a = 'x';
        char c = 'z';

        //Act
        string result = CharacterRange.GetRange(a, c);

        //Assert
        Assert.That(result, Is.EqualTo("y"));
    }
}
