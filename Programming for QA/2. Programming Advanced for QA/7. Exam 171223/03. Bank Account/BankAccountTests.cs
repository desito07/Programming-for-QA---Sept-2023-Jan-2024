using NUnit.Framework;
using System;

namespace TestApp.Tests;

[TestFixture]
public class BankAccountTests
{
    [Test]
    public void Test_Constructor_InitialBalanceIsSet()
    {
        // Arrange
        double initialBalance = 100.0;

        //Act
        BankAccount account = new BankAccount(initialBalance);

        // Assert
        Assert.AreEqual(initialBalance, account.Balance);
    }

    [Test]
    public void Test_Deposit_PositiveAmount_IncreasesBalance()
    {
        // Arrange
        double initialBalance = 100.0;
        double depositAmount = 50.0;
        BankAccount account = new BankAccount(initialBalance);

        // Act
        account.Deposit(depositAmount);

        // Assert
        Assert.AreEqual(initialBalance + depositAmount, account.Balance);
    }

    [Test]
    public void Test_Deposit_NegativeAmount_ThrowsArgumentException()
    {
        // Arrange
        double initialBalance = 100.0;
        double depositAmount = -50.0;
        BankAccount account = new BankAccount(initialBalance);

        // Act & Assert
        Assert.Throws<ArgumentException>(() => account.Deposit(depositAmount));
    }

    [Test]
    public void Test_Withdraw_ValidAmount_DecreasesBalance()
    {
        // Arrange
        double initialBalance = 100.0;
        double withdrawAmount = 30.0;
        BankAccount account = new BankAccount(initialBalance);

        // Act
        account.Withdraw(withdrawAmount);

        // Assert
        Assert.AreEqual(initialBalance - withdrawAmount, account.Balance);
    }

    [Test]
    public void Test_Withdraw_NegativeAmount_ThrowsArgumentException()
    {
        // Arrange
        double initialBalance = 100.0;
        double withdrawAmount = -30.0;
        BankAccount account = new BankAccount(initialBalance);

        // Act & Assert
        Assert.Throws<ArgumentException>(() => account.Withdraw(withdrawAmount));
    }

    [Test]
    public void Test_Withdraw_AmountGreaterThanBalance_ThrowsArgumentException()
    {
        // Arrange
        double initialBalance = 100.0;
        double withdrawAmount = 150.0;
        BankAccount account = new BankAccount(initialBalance);

        // Act & Assert
        Assert.Throws<ArgumentException>(() => account.Withdraw(withdrawAmount));
    }
}
