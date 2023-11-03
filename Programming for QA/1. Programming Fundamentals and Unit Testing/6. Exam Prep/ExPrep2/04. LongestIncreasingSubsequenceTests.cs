using NUnit.Framework;
using System;

namespace TestApp.Tests;

public class LongestIncreasingSubsequenceTests
{
    [Test]
    public void Test_GetLis_NullArray_ThrowsArgumentNullException()
    {
        //Arrange
        int[]? input = null;
        // Act & Assert
        Assert.That(() => LongestIncreasingSubsequence.GetLis(input), Throws.ArgumentNullException);

    }

    [Test]
    public void Test_GetLis_EmptyArray_ReturnsEmptyString()
    {
        // Arrange
        int[] input =  Array.Empty<int>();

        //Act
        string result = LongestIncreasingSubsequence.GetLis(input);

        //Assert
        Assert.That(result, Is.EqualTo(string.Empty));
    }

    [Test]
    public void Test_GetLis_SingleElementArray_ReturnsElement()
    {
        // Arrange
        int[] input = new[] { 40 };

        //Act
        string result = LongestIncreasingSubsequence.GetLis(input);

        //Assert
        Assert.That(result, Is.EqualTo("40"));
    }

    [Test]
    public void Test_GetLis_UnsortedArray_ReturnsLongestIncreasingSubsequence()
    {
        // Arrange
       int[] input = new[] { 1, 2, 1, 3, 4, 10, 12, 15, 12, 45, 78 };

        //Act
        string result = LongestIncreasingSubsequence.GetLis(input);

        //Assert
        Assert.That(result, Is.EqualTo("1 2 3 4 10 12 15 45 78"));
    }

    [Test]
    public void Test_GetLis_SortedArray_ReturnsItself()
    {
        // Arrange
        int[] input = new[] { 1, 2, 3, 4, 10, 12, 15, 12, 45, 78 };

        //Act
        string result = LongestIncreasingSubsequence.GetLis(input);

        //Assert
        Assert.That(result, Is.EqualTo("1 2 3 4 10 12 15 45 78")); 
    }
}
