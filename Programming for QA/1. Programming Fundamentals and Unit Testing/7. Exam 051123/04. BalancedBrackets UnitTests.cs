using System;
using NUnit.Framework;

namespace TestApp.Tests;

public class BalancedBracketsTests
{
    [Test]
    public void Test_IsBalanced_EmptyInput_ShouldReturnTrue()
    {
        //Arrange
        string[] someSymbols = new[] {""};

        //Act
        bool result = BalancedBrackets.IsBalanced(someSymbols);

        //Assert
        Assert.That(result, Is.True);
    }

    [Test]
    public void Test_IsBalanced_BalancedBrackets_ShouldReturnTrue()
    {
        //Arrange
        string[] someSymbols = new[] { "(", ")", "(", ")" };

        //Act
        bool result = BalancedBrackets.IsBalanced(someSymbols);

        //Assert
        Assert.That(result, Is.True);
    }

    [Test]
    public void Test_IsBalanced_UnbalancedBrackets_ShouldReturnFalse()
    {
        //Arrange
        string[] someSymbols = new[] { "(", ")", "(", ")", ")" };

        //Act
        bool result = BalancedBrackets.IsBalanced(someSymbols);

        //Assert
        Assert.That(result, Is.False);
    }

    [Test]
    public void Test_IsBalanced_MoreClosingBrackets_ShouldReturnFalse()
    {
        //Arrange
        string[] someSymbols = new[] { "(", ")", "(", ")", ")", ")" };

        //Act
        bool result = BalancedBrackets.IsBalanced(someSymbols);

        //Assert
        Assert.That(result, Is.False);
    }

    [Test]
    public void Test_IsBalanced_NoClosingBrackets_ShouldReturnFalse()
    {
        //Arrange
        string[] someSymbols = new[] { "(", ")", "(" };

        //Act
        bool result = BalancedBrackets.IsBalanced(someSymbols);

        //Assert
        Assert.That(result, Is.False);
    }
}
