/**
 * Tests for the GetIndentation method in GeneralUtils class.
 * Validates string indentation generation with various nesting levels.
 *
 * Bugs: None known
 *
 * @author Mridul
 * @date January 21, 2026
 */

namespace AssignmentProject1;

public class GetIndentationTests
{
    [Fact]
    public void GetIndentation_LevelZero_ReturnsEmptyString()
    {
        // Arrange & Act
        string result = GeneralUtils.GetIndentation(0);
        
        // Assert
        Assert.Equal("", result);
    }

    [Fact]
    public void GetIndentation_LevelOne_ReturnsFourSpaces()
    {
        // Arrange & Act
        string result = GeneralUtils.GetIndentation(1);
        
        // Assert
        Assert.Equal("    ", result);
        Assert.Equal(4, result.Length);
    }

    [Fact]
    public void GetIndentation_LevelTwo_ReturnsEightSpaces()
    {
        // Arrange & Act
        string result = GeneralUtils.GetIndentation(2);
        
        // Assert
        Assert.Equal("        ", result);
        Assert.Equal(8, result.Length);
    }

    [Fact]
    public void GetIndentation_LevelThree_ReturnsTwelveSpaces()
    {
        // Arrange & Act
        string result = GeneralUtils.GetIndentation(3);
        
        // Assert
        Assert.Equal("            ", result);
        Assert.Equal(12, result.Length);
    }

    [Fact]
    public void GetIndentation_LevelFive_ReturnsTwentySpaces()
    {
        // Arrange & Act
        string result = GeneralUtils.GetIndentation(5);
        
        // Assert
        Assert.Equal(20, result.Length);
        Assert.True(result.All(c => c == ' '));
    }

    [Fact]
    public void GetIndentation_LargeLevel_ReturnsCorrectLength()
    {
        // Arrange & Act
        string result = GeneralUtils.GetIndentation(10);
        
        // Assert
        Assert.Equal(40, result.Length);
        Assert.True(result.All(c => c == ' '));
    }

    [Fact]
    public void GetIndentation_OnlyContainsSpaces()
    {
        // Arrange & Act
        string result = GeneralUtils.GetIndentation(3);
        
        // Assert
        foreach (char c in result)
        {
            Assert.Equal(' ', c);
        }
    }

    [Theory]
    [InlineData(0, 0)]
    [InlineData(1, 4)]
    [InlineData(2, 8)]
    [InlineData(3, 12)]
    [InlineData(4, 16)]
    [InlineData(10, 40)]
    public void GetIndentation_VariousLevels_ReturnsCorrectLength(int level, int expectedLength)
    {
        // Act
        string result = GeneralUtils.GetIndentation(level);
        
        // Assert
        Assert.Equal(expectedLength, result.Length);
    }
}
