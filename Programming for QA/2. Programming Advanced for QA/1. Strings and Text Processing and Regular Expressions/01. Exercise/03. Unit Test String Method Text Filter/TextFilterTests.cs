using NUnit.Framework;

using System;

namespace TestApp.UnitTests;

public class TextFilterTests
{
    [Test]
    public void Test_Filter_WhenNoBannedWords_ShouldReturnOriginalText()
    {
        // Arrange
        string text = "Az iskam da polychavam po-dolqma zaplata!";
        string[] banned = new[] { "kinti" };

        // Act
        string result = TextFilter.Filter(banned, text);

        // Assert
        Assert.That(result, Is.EqualTo("Az iskam da polychavam po-dolqma zaplata!"));
    }

    [Test]
    public void Test_Filter_WhenBannedWordExists_ShouldReplaceBannedWordWithAsterisks()
    {
        // Arrange
        string text = "Az iskam da polychavam po-dolqma zaplata!";
        string[] banned = new[] {"zaplata"};
        string expected = "Az iskam da polychavam po-dolqma *******!";

        // Act
        string result = TextFilter.Filter(banned, text);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_Filter_WhenBannedWordsAreEmpty_ShouldReturnOriginalText()
    {
        // Arrange
        string text = "Az iskam da polychavam po-dolqma zaplata!";
        string[] banned = Array.Empty<string>();

        // Act
        string result = TextFilter.Filter(banned, text);

        // Assert
        Assert.That(result, Is.EqualTo("Az iskam da polychavam po-dolqma zaplata!"));
    }

    [Test]
    public void Test_Filter_WhenBannedWordsContainWhitespace_ShouldReplaceBannedWord()
    {
        // Arrange
        string text = "Az iskam da polychavam po-dolqma zaplata!";
        string[] banned = new[] { "zap la ta" };
        string expected = "Az iskam da polychavam po-dolqma *******!";

        // Act
        string result = TextFilter.Filter(banned, text);

        // Assert
        Assert.That(result, Is.EqualTo("Az iskam da polychavam po-dolqma zaplata!"));
    }
}
