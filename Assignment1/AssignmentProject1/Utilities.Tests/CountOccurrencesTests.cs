/**
 * Tests for the CountOccurrences method in GeneralUtils class.
 * Validates counting of character occurrences in strings.
 *
 * Bugs: None known
 *
 * @author Mridul
 * @date January 21, 2026
 */

namespace AssignmentProject1;

public class CountOccurrencesTests
{
    [Fact]
    public void CountOccurrences_CharacterExists_ReturnsCorrectCount()
    {
        // Arrange
        string text = "hello";
        char target = 'l';
        
        // Act
        int result = GeneralUtils.CountOccurrences(text, target);
        
        // Assert
        Assert.Equal(2, result);
    }

    [Fact]
    public void CountOccurrences_CharacterNotExists_ReturnsZero()
    {
        // Arrange
        string text = "hello";
        char target = 'z';
        
        // Act
        int result = GeneralUtils.CountOccurrences(text, target);
        
        // Assert
        Assert.Equal(0, result);
    }

    [Fact]
    public void CountOccurrences_EmptyString_ReturnsZero()
    {
        // Arrange
        string text = "";
        char target = 'a';
        
        // Act
        int result = GeneralUtils.CountOccurrences(text, target);
        
        // Assert
        Assert.Equal(0, result);
    }

    [Fact]
    public void CountOccurrences_SingleCharacterMatch_ReturnsOne()
    {
        // Arrange
        string text = "a";
        char target = 'a';
        
        // Act
        int result = GeneralUtils.CountOccurrences(text, target);
        
        // Assert
        Assert.Equal(1, result);
    }

    [Fact]
    public void CountOccurrences_SingleCharacterNoMatch_ReturnsZero()
    {
        // Arrange
        string text = "a";
        char target = 'b';
        
        // Act
        int result = GeneralUtils.CountOccurrences(text, target);
        
        // Assert
        Assert.Equal(0, result);
    }

    [Fact]
    public void CountOccurrences_AllCharactersMatch_ReturnsLength()
    {
        // Arrange
        string text = "aaaa";
        char target = 'a';
        
        // Act
        int result = GeneralUtils.CountOccurrences(text, target);
        
        // Assert
        Assert.Equal(4, result);
    }

    [Fact]
    public void CountOccurrences_CaseSensitive_ReturnsCorrectCount()
    {
        // Arrange
        string text = "HeLLo";
        char targetLower = 'l';
        char targetUpper = 'L';
        
        // Act
        int resultLower = GeneralUtils.CountOccurrences(text, targetLower);
        int resultUpper = GeneralUtils.CountOccurrences(text, targetUpper);
        
        // Assert
        Assert.Equal(0, resultLower);
        Assert.Equal(2, resultUpper);
    }

    [Fact]
    public void CountOccurrences_SpaceCharacter_ReturnsCorrectCount()
    {
        // Arrange
        string text = "hello world test";
        char target = ' ';
        
        // Act
        int result = GeneralUtils.CountOccurrences(text, target);
        
        // Assert
        Assert.Equal(2, result);
    }

    [Fact]
    public void CountOccurrences_SpecialCharacter_ReturnsCorrectCount()
    {
        // Arrange
        string text = "hello@world@test";
        char target = '@';
        
        // Act
        int result = GeneralUtils.CountOccurrences(text, target);
        
        // Assert
        Assert.Equal(2, result);
    }

    [Fact]
    public void CountOccurrences_DigitCharacter_ReturnsCorrectCount()
    {
        // Arrange
        string text = "abc123def456";
        char target = '3';
        
        // Act
        int result = GeneralUtils.CountOccurrences(text, target);
        
        // Assert
        Assert.Equal(1, result);
    }

    [Fact]
    public void CountOccurrences_LongString_ReturnsCorrectCount()
    {
        // Arrange
        string text = "abcabcabcabcabc";
        char target = 'a';
        
        // Act
        int result = GeneralUtils.CountOccurrences(text, target);
        
        // Assert
        Assert.Equal(5, result);
    }

    [Fact]
    public void CountOccurrences_NewlineCharacter_ReturnsCorrectCount()
    {
        // Arrange
        string text = "line1\nline2\nline3";
        char target = '\n';
        
        // Act
        int result = GeneralUtils.CountOccurrences(text, target);
        
        // Assert
        Assert.Equal(2, result);
    }

    [Fact]
    public void CountOccurrences_TabCharacter_ReturnsCorrectCount()
    {
        // Arrange
        string text = "col1\tcol2\tcol3";
        char target = '\t';
        
        // Act
        int result = GeneralUtils.CountOccurrences(text, target);
        
        // Assert
        Assert.Equal(2, result);
    }
}
