using NUnit.Framework;

namespace TestApp.Tests;

[TestFixture]
public class CamelCaseConverterTests
{
    [Test]
    public void Test_ConvertToCamelCase_EmptyString_ReturnsEmptyString()
    {
        //Arrange
        string input = "";
        

        //Act
        string result = CamelCaseConverter.ConvertToCamelCase(input);

        //Assert
        Assert.That(result, Is.EqualTo(string.Empty));
    }

    [Test]
    public void Test_ConvertToCamelCase_SingleWord_ReturnsLowercaseWord()
    {
        //Arrange
        string input = "Desi";
        string expected = "desi";

        //Act
        string result = CamelCaseConverter.ConvertToCamelCase(input);

        //Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_ConvertToCamelCase_MultipleWords_ReturnsCamelCase()
    {
        //Arrange
        string input = "desi hello";
        string expected = "desiHello";

        //Act
        string result = CamelCaseConverter.ConvertToCamelCase(input);

        //Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_ConvertToCamelCase_MultipleWordsWithMixedCase_ReturnsCamelCase()
    {
        //Arrange
        string input = "DeSi HeLlO";
        string expected = "desiHello";

        //Act
        string result = CamelCaseConverter.ConvertToCamelCase(input);

        //Assert
        Assert.That(result, Is.EqualTo(expected));
    }
}
