using System;
using System.Collections.Generic;

using NUnit.Framework;

namespace TestApp.Tests;

[TestFixture]
public class GradesTests
{
    [Test]
    public void Test_GetBestStudents_ReturnsBestThreeStudents()
    {
        //Arrange
        Dictionary<string, int> input = new()
        {
            {"Ana", 6},
            {"Bobo", 5},
            {"Cico", 4},
            {"Desi", 3},
        };


        // Act
        string result = Grades.GetBestStudents(input);
        string expected = $"Ana with average grade 6.00" +
            $"{Environment.NewLine}Bobo with average grade 5.00" +
            $"{Environment.NewLine}Cico with average grade 4.00";

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_GetBestStudents_EmptyGrades_ReturnsEmptyString()
    {
        //Arrange
        Dictionary<string, int> input = new() 
        {

        };


        // Act
        string result = Grades.GetBestStudents(input);
        string expected = ""; 

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_GetBestStudents_LessThanThreeStudents_ReturnsAllStudents()
    {
        //Arrange
        Dictionary<string, int> input = new()
        {
            {"Ana", 6},
            {"Bobo", 5},
         };



        // Act
        string result = Grades.GetBestStudents(input);
        string expected = $"Ana with average grade 6.00" +
            $"{Environment.NewLine}Bobo with average grade 5.00";

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_GetBestStudents_SameGrade_ReturnsInAlphabeticalOrder()
    {

        //Arrange
        Dictionary<string, int> input = new()
        {
            {"Ana", 5},
            {"Bobo", 5},
            {"Cica", 5},
            {"Desi", 5},
            {"Emma", 5 }

        };

        // Act
        string result = Grades.GetBestStudents(input);
        string expected = $"Ana with average grade 5.00" +
            $"{Environment.NewLine}Bobo with average grade 5.00" +
            $"{Environment.NewLine}Cica with average grade 5.00";

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }
}
