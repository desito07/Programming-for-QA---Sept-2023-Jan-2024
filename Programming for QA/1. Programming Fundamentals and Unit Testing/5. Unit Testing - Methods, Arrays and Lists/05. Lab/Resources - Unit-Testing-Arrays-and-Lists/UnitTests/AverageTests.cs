using Newtonsoft.Json.Linq;
using NUnit.Framework;

using System;

namespace TestApp.UnitTests;

public class AverageTests
{
    
    [Test]
    public void Test_CalculateAverage_InputIsEmptyArray_ShouldThrowArgumentException()
    {
        // Arrange
        int[] emptyArray = Array.Empty<int>();

        // Act & Assert
        Assert.That(() => Average.CalculateAverage(emptyArray), Throws.ArgumentException);
       
    }

    [Test]
    public void Test_CalculateAverage_InputHasOneElement_ShouldReturnSameElement()
    {
        // Arrange
        int[] array = new [] { 42 };

        // Act
        double result = Average.CalculateAverage(array);

        // Assert
        Assert.That(result, Is.EqualTo(42));
    }

    [Test]
    public void Test_CalculateAverage_InputHasPositiveIntegers_ShouldReturnCorrectAverage()
    {
        // Arrange
        int[] ArrayPositiveElements = new[] { 1, 2, 3 };

        // Act
        double result = Average.CalculateAverage(ArrayPositiveElements);

        // Assert
        Assert.That(result, Is.EqualTo(2));

    }

    [Test]
    public void Test_CalculateAverage_InputHasNegativeIntegers_ShouldReturnCorrectAverage()
    {
        // Arrange
        int[] ArrayNegativeElements = new[] { -1, -2, -3 };

        // Act
        double result = Average.CalculateAverage(ArrayNegativeElements);

        // Assert
        Assert.That(result, Is.EqualTo(-2));
    }

    [Test]
    public void Test_CalculateAverage_InputHasMixedIntegers_ShouldReturnCorrectAverage()
    {
        // Arrange
        int[] ArrayNegativeElements = new[] { -1, 1, -3 };

        // Act
        double result = Average.CalculateAverage(ArrayNegativeElements);

        // Assert
        Assert.That(result, Is.EqualTo(-1));
    }
}
