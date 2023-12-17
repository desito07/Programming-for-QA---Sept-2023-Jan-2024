using System.Collections.Generic;

using NUnit.Framework;

namespace TestApp.Tests;

[TestFixture]
public class NumberFrequencyTests
{
    [Test]
    public void Test_CountDigits_ZeroNumber_ReturnsEmptyDictionary()
    {
        // Arrange
        int num = 0;
        Dictionary<int, int> expected = new Dictionary<int, int>();

        //Act
        var result = NumberFrequency.CountDigits(num);

        //Assert
        Assert.AreEqual(result, expected);
    }

    [Test]
    public void Test_CountDigits_SingleDigitNumber_ReturnsDictionaryWithSingleEntry()
    {
        int num = 11111;
        Dictionary<int, int> expected = new()
        {
            { 1, 5 }
        };
       
        //Act
        var result = NumberFrequency.CountDigits(num);

        //Assert
        Assert.AreEqual(result, expected);
    }

    [Test]
    public void Test_CountDigits_MultipleDigitNumber_ReturnsDictionaryWithDigitFrequencies()
    {
        int num = 335353266;
        Dictionary<int, int> expected = new()
        {
            { 3, 4 },
            { 5, 2 },
            { 2, 1 },
            { 6, 2 },
        };

        //Act
        var result = NumberFrequency.CountDigits(num);

        //Assert
        Assert.AreEqual(result, expected);
    }

    [Test]
    public void Test_CountDigits_NegativeNumber_ReturnsDictionaryWithDigitFrequencies()
    {
        int num = -2323233;
        Dictionary<int, int> expected = new()
        {
            { 2, 3 },
            { 3, 4 },
        };

        //Act
        var result = NumberFrequency.CountDigits(num);

        //Assert
        Assert.AreEqual(result, expected);
    }
 }
