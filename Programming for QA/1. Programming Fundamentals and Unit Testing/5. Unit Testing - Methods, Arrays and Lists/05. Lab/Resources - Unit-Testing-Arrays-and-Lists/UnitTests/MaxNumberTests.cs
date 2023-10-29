using NUnit.Framework;

using System.Collections.Generic;

namespace TestApp.UnitTests;

public class MaxNumberTests
{
    [Test]
    public void Test_FindMax_InputIsNull_ShouldThrowArgumentException()
    {
        // Arrange
        List<int>? nullList = null;

        // Act & Assert
        Assert.That(() => MaxNumber.FindMax(nullList), Throws.ArgumentException);

    }

    [Test]
    public void Test_FindMax_InputIsEmptyList_ShouldThrowArgumentException()
    {
        // Arrange
        List<int> EmptyList = new();

        // Act & Assert
        Assert.That(() => MaxNumber.FindMax(EmptyList), Throws.ArgumentException);

    }

    [Test]
    public void Test_FindMax_InputHasOneElement_ShouldReturnTheElement()
    {
        // Arrange
        List<int> oneElement = new() { 4 };

        // Act
        int result = MaxNumber.FindMax(oneElement);

        //Assert
        Assert.That(result, Is.EqualTo(4));
    }

    [Test]
    public void Test_FindMax_InputHasPositiveIntegers_ShouldReturnMaximum()
    {
        // Arrange
        List<int> positiveElements = new() { 1, 2, 3 };

        // Act
        int result = MaxNumber.FindMax(positiveElements);

        //Assert
        Assert.That(result, Is.EqualTo(3)); ;
    }

    [Test]
    public void Test_FindMax_InputHasNegativeIntegers_ShouldReturnMaximum()
    {
        // Arrange
        List<int> negativeElements = new() { -1, -2, -3 };

        // Act
        int result = MaxNumber.FindMax(negativeElements);

        //Assert
        Assert.That(result, Is.EqualTo(-1)); ;
    }

    [Test]
    public void Test_FindMax_InputHasMixedIntegers_ShouldReturnMaximum()
    {
        // Arrange
        List<int> mixedElements = new() { -1, 2, -3, 5 };

        // Act
        int result = MaxNumber.FindMax(mixedElements);

        //Assert
        Assert.That(result, Is.EqualTo(5));
    }

    [Test]
    public void Test_FindMax_InputHasDuplicateMaxValue_ShouldReturnMaximum()
    {
        // Arrange
        List<int> duplicateElements = new() { -1, 2, -3, 5, 5, 5 };

        // Act
        int result = MaxNumber.FindMax(duplicateElements);

        //Assert
        Assert.That(result, Is.EqualTo(5));
    }
}
