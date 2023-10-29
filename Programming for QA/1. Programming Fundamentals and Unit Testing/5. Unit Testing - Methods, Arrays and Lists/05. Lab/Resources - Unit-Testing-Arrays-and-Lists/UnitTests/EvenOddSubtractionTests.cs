using NUnit.Framework;

using System;

namespace TestApp.UnitTests;

public class EvenOddSubtractionTests
{
    [Test]
    public void Test_FindDifference_InputIsEmpty_ShouldReturnZero()
    {
        // Arrange
        int[] emptyArray = Array.Empty<int>();

        // Act
        int result = EvenOddSubtraction.FindDifference(emptyArray);

        // Assert
        Assert.That(result, Is.EqualTo(0));
    }

   
    [Test]
    public void Test_FindDifference_InputHasOnlyEvenNumbers_ShouldReturnEvenSum()
    {
        // Arrange
        int[] EvenNumberArray = new[] { 20 }; 

        // Act
        int result = EvenOddSubtraction.FindDifference(EvenNumberArray);

        // Assert
        Assert.That(result, Is.EqualTo(20));
    }

    [Test]
    public void Test_FindDifference_InputHasOnlyOddNumbers_ShouldReturnSum()
    {
        // Arrange
        int[] OddNumbersArray = new[] { 1, 3, 5, 7 };

        // Act
        int result = EvenOddSubtraction.FindDifference(OddNumbersArray);

        // Assert
        Assert.That(result, Is.EqualTo(16));
    }

    [Test]
    public void Test_FindDifference_InputHasMixedNumbers_ShouldReturnDifference()
    {
        // Arrange
        int[] MixedumbersArray = new[] { 1, 10, 15, 20 };

        // Act
        int result = EvenOddSubtraction.FindDifference(MixedumbersArray);

        // Assert
        Assert.That(result, Is.EqualTo(14));
    }
}
