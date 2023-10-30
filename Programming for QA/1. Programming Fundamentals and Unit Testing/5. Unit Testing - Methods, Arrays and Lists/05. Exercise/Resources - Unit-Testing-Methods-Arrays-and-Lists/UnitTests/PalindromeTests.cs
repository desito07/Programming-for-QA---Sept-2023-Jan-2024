using NUnit.Framework;

using System.Collections.Generic;
using System.ComponentModel;

namespace TestApp.UnitTests;

public class PalindromeTests
{
    [Test]
    public void Test_IsPalindrome_ValidPalindrome_ReturnsTrue()
    {
        // Arrange
        List<string> words = new() { "aha", "heh"};

        // Act
        bool result = Palindrome.IsPalindrome(words);

        // Assert
       Assert.That(result, Is.True);
    }

    [Test]
    public void Test_IsPalindrome_EmptyList_ReturnsTrue()
    {
        // Arrange
        List<string> words = new();

        // Act
        bool result = Palindrome.IsPalindrome(words);

        // Assert
        Assert.That(result, Is.True);

    }

    [Test]
    public void Test_IsPalindrome_SingleWord_ReturnsTrue()
    {
        // Arrange
        List<string> words = new() { "aha" };

        // Act
        bool result = Palindrome.IsPalindrome(words);

        // Assert
        Assert.IsTrue(result);
    }

    [Test]
    public void Test_IsPalindrome_NonPalindrome_ReturnsFalse()
    {
        // Arrange
        List<string> words = new() { "aham", "hello" };

        // Act
        bool result = Palindrome.IsPalindrome(words);

        // Assert
        Assert.That(result, Is.False);
    }

    [Test]
    public void Test_IsPalindrome_MixedCasePalindrome_ReturnsTrue()
    {
        // Arrange
        List<string> words = new() { "aha", "heH" };

        // Act
        bool result = Palindrome.IsPalindrome(words);

        // Assert
        Assert.That(result, Is.True);
    }
}
