using NUnit.Framework;
using System;
using static System.Net.Mime.MediaTypeNames;

namespace TestApp.Tests;

public class ExtractFileTests
{
    [Test]
    public void Test_GetFile_NullPath_ThrowsArgumentNullException()
    {
        //Arrange
        string[]? input = null;

        // Act & Assert
        Assert.That(() => ExtractFile.GetFile(null), Throws.ArgumentNullException);
    }

    [Test]
    public void Test_GetFile_EmptyPath_ThrowsArgumentNullException()
    {
        //Arrange
        string[] input = {""};

        // Act & Assert
        Assert.That(() => ExtractFile.GetFile(""), Throws.ArgumentNullException);
    }

    [Test]
    public void Test_GetFile_ValidPath_ReturnsFileNameAndExtension()
    {
        // Arrange
        string[] input = new [] { "demo.txt" };

        //Act
        string result = ExtractFile.GetFile("demo.txt");

        //Assert
        Assert.That(result, Is.EqualTo("File name: demo\nFile extension: txt"));
    }

    [Test]
    public void Test_GetFile_PathWithNoExtension_ReturnsFileNameOnly()
    {
        // Arrange
        string[] input = new[] { "demo" };

        //Act
        string result = ExtractFile.GetFile("demo");

        //Assert
        Assert.That(result, Is.EqualTo("File name: demo"));
    }

    [Test]
    public void Test_GetFile_PathWithSpecialCharacters_ReturnsFileNameAndExtension()
    {
        // Arrange
        string[] input = new[] { "demo.txt" };

        //Act
        string result = ExtractFile.GetFile("demo.txt");

        //Assert
        Assert.That(result, Is.EqualTo("File name: demo\nFile extension: txt"));
    }
}
