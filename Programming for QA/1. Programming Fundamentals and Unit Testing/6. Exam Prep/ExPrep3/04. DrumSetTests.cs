using NUnit.Framework;
using System;

using System.Collections.Generic;

namespace TestApp.Tests;

public class DrumSetTests
{
    [Test]
    public void Test_Drum_TerminateCommandNotGiven_ThrowsArgumentException()
    {
        //Arrange
        decimal money = 100;
        List<int> output = new() { 2, 3 };
        List<string> result = new() { "1", "1" };

        // Act & Assert
        Assert.That(() => DrumSet.Drum(money, output, result), Throws.ArgumentException);
    }

    [Test]
    public void Test_Drum_StringGivenAsCommand_ThrowsArgumentException()
    {
        decimal money = 100;
        List<int> output = new() { 2, 3 };
        List<string> result = new() { "1", "drum", "Hit it again, Gabsy!" };

        // Act & Assert
        Assert.That(() => DrumSet.Drum(money, output, result), Throws.ArgumentException);
    }

    [Test]
    public void Test_Drum_ReturnsCorrectQualityAndAmount()
    {
        //Arrange
        decimal money = 100;
        List<int> output = new() { 3, 4 };
        List<string> result = new() { "1", "1", "Hit it again, Gabsy!" };

        string expected = "1 2\nGabsy has 100.00lv.";

        //Act
        string act = DrumSet.Drum(money, output, result);

        //Assert
        Assert.That(act, Is.EqualTo(expected));

    }

    [Test]
    public void Test_Drum_BalanceZero_WithOneDrumLeftOver_ReturnsCorrectQualityAndAmount()
    {
        //Arrange
        decimal money = 0;
        List<int> output = new() { 3, 4, 5 };
        List<string> result = new() { "2", "2", "Hit it again, Gabsy!" };

        string expected = "1\nGabsy has 0.00lv.";

        //Act
        string act = DrumSet.Drum(money, output, result);

        //Assert
        Assert.That(act, Is.EqualTo(expected));

    }

    [Test]
    public void Test_Drum_NotEnoughBalance_RemovesAllDrums_ReturnsCorrectQualityAndAmount()
    {
        //Arrange
        decimal money = 2;
        List<int> output = new() { 3, 4, 5 };
        List<string> result = new() { "3", "3", "Hit it again, Gabsy!" };

        string expected = "\nGabsy has 2.00lv.";

        //Act
        string act = DrumSet.Drum(money, output, result);

        //Assert
        Assert.That(act, Is.EqualTo(expected));
    }


    [Test]
    public void Test_Drum_BrokenDrums_ReturnsCorrectQualityAndAmount()
    {
        //Arrange
        decimal money = 100;
        List<int> output = new() { 3, 10 };
        List<string> result = new() { "2", "2", "Hit it again, Gabsy!" };

        string expected = "3 6\nGabsy has 91.00lv.";

        //Act
        string act = DrumSet.Drum(money, output, result);

        //Assert
        Assert.That(act, Is.EqualTo(expected));
    }
}
