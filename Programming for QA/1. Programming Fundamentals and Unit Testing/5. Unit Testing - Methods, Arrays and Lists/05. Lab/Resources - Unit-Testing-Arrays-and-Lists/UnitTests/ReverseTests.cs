using NUnit.Framework;

using System;

namespace TestApp.UnitTests;

public class ReverseTests
{
    [Test]
    public void Test_ReverseArray_InputIsEmpty_ShouldReturnEmptyString()
    {
        // Arrange
        int[] emptyArray = Array.Empty<int>();

        // Act
        string result = Reverse.ReverseArray(emptyArray);

        // Assert
        Assert.That(result, Is.EqualTo(string.Empty));
    }

    [Test]
    public void Test_ReverseArray_InputHasOneElement_ShouldReturnTheSameElement()
    {
        // Arrange
        int[] ArrayWithSingleElement = new int[] { 42 };

        // Act
        string result = Reverse.ReverseArray(ArrayWithSingleElement);

        // Assert
        Assert.That(result, Is.EqualTo("42"));
    }

    [Test]
    public void Test_ReverseArray_InputHasMultipleElements_ShouldReturnReversedString()
    {
        // Arrange
        int[] ArrayWithMultipleElements = new int[4] { 1, 2, 3, 42 };

        //Act
        string result = Reverse.ReverseArray(ArrayWithMultipleElements);

        // Assert
        Assert.That(result, Is.EqualTo("42 3 2 1"));
    }
}
