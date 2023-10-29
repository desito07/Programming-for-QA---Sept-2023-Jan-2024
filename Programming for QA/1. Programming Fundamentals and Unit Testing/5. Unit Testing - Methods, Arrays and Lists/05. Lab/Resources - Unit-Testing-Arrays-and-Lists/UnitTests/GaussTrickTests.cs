using NUnit.Framework;

using System.Collections.Generic;

namespace TestApp.UnitTests;

public class GaussTrickTests
{
    [Test]
    public void Test_SumPairs_InputIsEmptyList_ShouldReturnEmptyList()
    {
        // Arrange
        List<int> emptyList = new();

        // Act
        List<int> result = GaussTrick.SumPairs(emptyList);

        // Assert
        CollectionAssert.AreEqual(emptyList, result);
    }

    [Test]
    public void Test_SumPairs_InputHasSingleElement_ShouldReturnSameElement()
    {
        // Arrange
        List<int> singleElement = new List<int>(4);

        // Act
        List<int> result = GaussTrick.SumPairs(singleElement);

        // Assert
        CollectionAssert.AreEqual(singleElement, result);
    }

    [Test]
    public void Test_SumPairs_InputHasEvenCountElements_ShouldReturnSumPairs()
    {
        // Arrange
        List<int> evenElements = new List<int>{2, 4, 6, 8};

        // Act
        List<int> result = GaussTrick.SumPairs(evenElements);

        // Assert
        List<int> assertResultEven = new List<int> { 10, 10 };
       CollectionAssert.AreEqual(assertResultEven, result);
    }

    [Test]
    public void Test_SumPairs_InputHasOddCountElements_ShouldReturnWithMiddleElement()
    {
        // Arrange
        List<int> oddElements = new List<int> { 1, 3, 5, 7, 9 };

        // Act
        List<int> result = GaussTrick.SumPairs(oddElements);

        // Assert
        List<int> assertResultOdd = new List<int> { 10, 10, 5 };
        CollectionAssert.AreEqual(assertResultOdd, result);
    }

    [Test]
    public void Test_SumPairs_InputHasLargeEvenCountElements_ShouldReturnSumPairs()
    {
        // Arrange
        List<int> evenElementsMiddle = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9 , 10 };

        // Act
        List<int> result = GaussTrick.SumPairs(evenElementsMiddle);

        // Assert
        List<int> assertResultEven = new List<int> { 11, 11, 11, 11, 11 };
        CollectionAssert.AreEqual(assertResultEven, result);
    }

    [Test]
    public void Test_SumPairs_InputHasLargeOddCountElements_ShouldReturnWithMiddleElement()
    {
        // Arrange
        List<int> oddElementsMiddle = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11 };

        // Act
        List<int> result = GaussTrick.SumPairs(oddElementsMiddle);

        // Assert
        List<int> assertResultOdd = new List<int> { 12, 12, 12, 12, 12, 6 };
        CollectionAssert.AreEqual(assertResultOdd, result);
    }
}
