/**
 * Tests for the IsPasswordStrong method in GeneralUtils class.
 * Validates password strength requirements including length, character types, and edge cases.
 *
 * Bugs: None known
 *
 * @author Mridul
 * @date January 21, 2026
 */

namespace AssignmentProject1;

public class IsPasswordStrongTests
{
    [Fact]
    public void IsPasswordStrong_NullPassword_ThrowsNullReferenceException()
    {
        // Arrange
        string password = null;
        
        // Act & Assert
        Assert.Throws<NullReferenceException>(() => GeneralUtils.IsPasswordStrong(password));
    }

    [Fact]
    public void IsPasswordStrong_ValidPassword_ReturnsTrue()
    {
        // Arrange
        string password = "P@ssw0rd";
        
        // Act
        bool result = GeneralUtils.IsPasswordStrong(password);
        
        // Assert
        Assert.True(result);
    }

    [Fact]
    public void IsPasswordStrong_TooShort_ReturnsFalse()
    {
        // Arrange
        string password = "P@ss0";
        
        // Act
        bool result = GeneralUtils.IsPasswordStrong(password);
        
        // Assert
        Assert.False(result);
    }

    [Fact]
    public void IsPasswordStrong_ExactlyEightCharactersValid_ReturnsTrue()
    {
        // Arrange
        string password = "P@ssw0rd";
        
        // Act
        bool result = GeneralUtils.IsPasswordStrong(password);
        
        // Assert
        Assert.True(result);
    }

    [Fact]
    public void IsPasswordStrong_SevenCharacters_ReturnsFalse()
    {
        // Arrange
        string password = "P@ssw0r";
        
        // Act
        bool result = GeneralUtils.IsPasswordStrong(password);
        
        // Assert
        Assert.False(result);
    }

    [Fact]
    public void IsPasswordStrong_NoUpperCase_ReturnsFalse()
    {
        // Arrange
        string password = "p@ssw0rd";
        
        // Act
        bool result = GeneralUtils.IsPasswordStrong(password);
        
        // Assert
        Assert.False(result);
    }

    [Fact]
    public void IsPasswordStrong_NoLowerCase_ReturnsFalse()
    {
        // Arrange
        string password = "P@SSW0RD";
        
        // Act
        bool result = GeneralUtils.IsPasswordStrong(password);
        
        // Assert
        Assert.False(result);
    }

    [Fact]
    public void IsPasswordStrong_NoDigit_ReturnsFalse()
    {
        // Arrange
        string password = "P@ssword";
        
        // Act
        bool result = GeneralUtils.IsPasswordStrong(password);
        
        // Assert
        Assert.False(result);
    }

    [Fact]
    public void IsPasswordStrong_NoSpecialCharacter_ReturnsFalse()
    {
        // Arrange
        string password = "Passw0rd";
        
        // Act
        bool result = GeneralUtils.IsPasswordStrong(password);
        
        // Assert
        Assert.False(result);
    }

    [Fact]
    public void IsPasswordStrong_EmptyString_ReturnsFalse()
    {
        // Arrange
        string password = "";
        
        // Act
        bool result = GeneralUtils.IsPasswordStrong(password);
        
        // Assert
        Assert.False(result);
    }

    [Fact]
    public void IsPasswordStrong_OnlyUpperCase_ReturnsFalse()
    {
        // Arrange
        string password = "ABCDEFGH";
        
        // Act
        bool result = GeneralUtils.IsPasswordStrong(password);
        
        // Assert
        Assert.False(result);
    }

    [Fact]
    public void IsPasswordStrong_OnlyLowerCase_ReturnsFalse()
    {
        // Arrange
        string password = "abcdefgh";
        
        // Act
        bool result = GeneralUtils.IsPasswordStrong(password);
        
        // Assert
        Assert.False(result);
    }

    [Fact]
    public void IsPasswordStrong_OnlyDigits_ReturnsFalse()
    {
        // Arrange
        string password = "12345678";
        
        // Act
        bool result = GeneralUtils.IsPasswordStrong(password);
        
        // Assert
        Assert.False(result);
    }

    [Fact]
    public void IsPasswordStrong_OnlySpecialCharacters_ReturnsFalse()
    {
        // Arrange
        string password = "!@#$%^&*";
        
        // Act
        bool result = GeneralUtils.IsPasswordStrong(password);
        
        // Assert
        Assert.False(result);
    }

    [Fact]
    public void IsPasswordStrong_LongValidPassword_ReturnsTrue()
    {
        // Arrange
        string password = "MyV3ry$ecureP@ssw0rd!";
        
        // Act
        bool result = GeneralUtils.IsPasswordStrong(password);
        
        // Assert
        Assert.True(result);
    }

    [Fact]
    public void IsPasswordStrong_MultipleSpecialCharacters_ReturnsTrue()
    {
        // Arrange
        string password = "P@$$w0rd!#";
        
        // Act
        bool result = GeneralUtils.IsPasswordStrong(password);
        
        // Assert
        Assert.True(result);
    }

    [Fact]
    public void IsPasswordStrong_MultipleDigits_ReturnsTrue()
    {
        // Arrange
        string password = "P@ssw0rd123";
        
        // Act
        bool result = GeneralUtils.IsPasswordStrong(password);
        
        // Assert
        Assert.True(result);
    }

    [Fact]
    public void IsPasswordStrong_MultipleUpperCase_ReturnsTrue()
    {
        // Arrange
        string password = "PASsw0rd!";
        
        // Act
        bool result = GeneralUtils.IsPasswordStrong(password);
        
        // Assert
        Assert.True(result);
    }

    [Fact]
    public void IsPasswordStrong_MultipleLowerCase_ReturnsTrue()
    {
        // Arrange
        string password = "P@ssword0";
        
        // Act
        bool result = GeneralUtils.IsPasswordStrong(password);
        
        // Assert
        Assert.True(result);
    }
}
