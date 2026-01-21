/**
 * Tests for the ToCamelCase method in GeneralUtils class.
 * Validates conversion of space-separated strings to camelCase format.
 *
 * Bugs: None known
 *
 * @author Mridul
 * @date January 21, 2026
 */

namespace AssignmentProject1;

public class ToCamelCaseTests
{
    [Fact]
    public void ToCamelCase_TwoWords_ReturnsCorrectFormat()
    {
        // Arrange
        string input = "hello world";
        
        // Act
        string result = GeneralUtils.ToCamelCase(input);
        
        // Assert
        Assert.Equal("helloWorld", result);
    }

    [Fact]
    public void ToCamelCase_ThreeWords_ReturnsCorrectFormat()
    {
        // Arrange
        string input = "hello world test";
        
        // Act
        string result = GeneralUtils.ToCamelCase(input);
        
        // Assert
        Assert.Equal("helloWorldTest", result);
    }

    [Fact]
    public void ToCamelCase_FourWords_ReturnsCorrectFormat()
    {
        // Arrange
        string input = "Hello world test string";
        
        // Act
        string result = GeneralUtils.ToCamelCase(input);
        
        // Assert
        Assert.Equal("helloWorldTestString", result);
    }

    [Fact]
    public void ToCamelCase_SingleWord_ReturnsLowerCase()
    {
        // Arrange
        string input = "Hello";
        
        // Act
        string result = GeneralUtils.ToCamelCase(input);
        
        // Assert
        Assert.Equal("hello", result);
    }

    [Fact]
    public void ToCamelCase_EmptyString_ReturnsEmpty()
    {
        // Arrange
        string input = "";
        
        // Act
        string result = GeneralUtils.ToCamelCase(input);
        
        // Assert
        Assert.Equal("", result);
    }

    [Fact]
    public void ToCamelCase_OnlySpaces_ReturnsEmpty()
    {
        // Arrange
        string input = "   ";
        
        // Act
        string result = GeneralUtils.ToCamelCase(input);
        
        // Assert
        Assert.Equal("", result);
    }

    [Fact]
    public void ToCamelCase_MultipleSpacesBetweenWords_ReturnsCorrectFormat()
    {
        // Arrange
        string input = "hello  world";
        
        // Act
        string result = GeneralUtils.ToCamelCase(input);
        
        // Assert
        Assert.Equal("helloWorld", result);
    }

    [Fact]
    public void ToCamelCase_LeadingSpace_ReturnsCorrectFormat()
    {
        // Arrange
        string input = " hello world";
        
        // Act
        string result = GeneralUtils.ToCamelCase(input);
        
        // Assert
        Assert.Equal("helloWorld", result);
    }

    [Fact]
    public void ToCamelCase_TrailingSpace_ReturnsCorrectFormat()
    {
        // Arrange
        string input = "hello world ";
        
        // Act
        string result = GeneralUtils.ToCamelCase(input);
        
        // Assert
        Assert.Equal("helloWorld", result);
    }

    [Fact]
    public void ToCamelCase_AllUpperCase_ReturnsCorrectFormat()
    {
        // Arrange
        string input = "HELLO WORLD";
        
        // Act
        string result = GeneralUtils.ToCamelCase(input);
        
        // Assert
        Assert.Equal("helloWorld", result);
    }

    [Fact]
    public void ToCamelCase_MixedCase_ReturnsCorrectFormat()
    {
        // Arrange
        string input = "HeLLo WoRLd";
        
        // Act
        string result = GeneralUtils.ToCamelCase(input);
        
        // Assert
        Assert.Equal("helloWorld", result);
    }

    [Fact]
    public void ToCamelCase_SingleCharacter_ReturnsLowerCase()
    {
        // Arrange
        string input = "A";
        
        // Act
        string result = GeneralUtils.ToCamelCase(input);
        
        // Assert
        Assert.Equal("a", result);
    }

    [Fact]
    public void ToCamelCase_TwoSingleCharacters_ReturnsCorrectFormat()
    {
        // Arrange
        string input = "a b";
        
        // Act
        string result = GeneralUtils.ToCamelCase(input);
        
        // Assert
        Assert.Equal("aB", result);
    }

    [Fact]
    public void ToCamelCase_WithNumbers_ReturnsCorrectFormat()
    {
        // Arrange
        string input = "test 123 string";
        
        // Act
        string result = GeneralUtils.ToCamelCase(input);
        
        // Assert
        Assert.Equal("test123String", result);
    }

    [Fact]
    public void ToCamelCase_LongString_ReturnsCorrectFormat()
    {
        // Arrange
        string input = "this is a very long test string";
        
        // Act
        string result = GeneralUtils.ToCamelCase(input);
        
        // Assert
        Assert.Equal("thisIsAVeryLongTestString", result);
    }
}
