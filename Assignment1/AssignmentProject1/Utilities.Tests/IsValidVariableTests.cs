/**
 * Tests for the IsValidVariable method in GeneralUtils class.
 * Validates that variable names contain only lowercase letters.
 *
 * Bugs: None known
 *
 * @author Mridul
 * @date January 21, 2026
 */

namespace AssignmentProject1;

public class IsValidVariableTests
{
    [Fact]
    public void IsValidVariable_AllLowerCase_ReturnsTrue()
    {
        // Arrange
        string name = "validname";
        
        // Act
        bool result = GeneralUtils.IsValidVariable(name);
        
        // Assert
        Assert.True(result);
    }

    [Fact]
    public void IsValidVariable_ContainsUpperCase_ReturnsFalse()
    {
        // Arrange
        string name = "InvalidName";
        
        // Act
        bool result = GeneralUtils.IsValidVariable(name);
        
        // Assert
        Assert.False(result);
    }

    [Fact]
    public void IsValidVariable_ContainsDigit_ReturnsFalse()
    {
        // Arrange
        string name = "variable1";
        
        // Act
        bool result = GeneralUtils.IsValidVariable(name);
        
        // Assert
        Assert.False(result);
    }

    [Fact]
    public void IsValidVariable_ContainsUnderscore_ReturnsFalse()
    {
        // Arrange
        string name = "valid_name";
        
        // Act
        bool result = GeneralUtils.IsValidVariable(name);
        
        // Assert
        Assert.False(result);
    }

    [Fact]
    public void IsValidVariable_EmptyString_ReturnsFalse()
    {
        // Arrange
        string name = "";
        
        // Act
        bool result = GeneralUtils.IsValidVariable(name);
        
        // Assert
        Assert.False(result);
    }

    [Fact]
    public void IsValidVariable_ContainsSpace_ReturnsFalse()
    {
        // Arrange
        string name = "valid name";
        
        // Act
        bool result = GeneralUtils.IsValidVariable(name);
        
        // Assert
        Assert.False(result);
    }

    [Fact]
    public void IsValidVariable_ContainsSpecialCharacter_ReturnsFalse()
    {
        // Arrange
        string name = "valid@name";
        
        // Act
        bool result = GeneralUtils.IsValidVariable(name);
        
        // Assert
        Assert.False(result);
    }

    [Fact]
    public void IsValidVariable_SingleLowercaseLetter_ReturnsTrue()
    {
        // Arrange
        string name = "a";
        
        // Act
        bool result = GeneralUtils.IsValidVariable(name);
        
        // Assert
        Assert.True(result);
    }

    [Fact]
    public void IsValidVariable_SingleUppercaseLetter_ReturnsFalse()
    {
        // Arrange
        string name = "A";
        
        // Act
        bool result = GeneralUtils.IsValidVariable(name);
        
        // Assert
        Assert.False(result);
    }

    [Fact]
    public void IsValidVariable_MixedCase_ReturnsFalse()
    {
        // Arrange
        string name = "camelCase";
        
        // Act
        bool result = GeneralUtils.IsValidVariable(name);
        
        // Assert
        Assert.False(result);
    }

    [Fact]
    public void IsValidVariable_ContainsHyphen_ReturnsFalse()
    {
        // Arrange
        string name = "valid-name";
        
        // Act
        bool result = GeneralUtils.IsValidVariable(name);
        
        // Assert
        Assert.False(result);
    }

    [Fact]
    public void IsValidVariable_ContainsDot_ReturnsFalse()
    {
        // Arrange
        string name = "valid.name";
        
        // Act
        bool result = GeneralUtils.IsValidVariable(name);
        
        // Assert
        Assert.False(result);
    }

    [Fact]
    public void IsValidVariable_AllAlphabet_ReturnsTrue()
    {
        // Arrange
        string name = "abcdefghijklmnopqrstuvwxyz";
        
        // Act
        bool result = GeneralUtils.IsValidVariable(name);
        
        // Assert
        Assert.True(result);
    }
}
