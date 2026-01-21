/**
 * Tests for the IsValidOperator method in GeneralUtils class.
 * Validates that strings are recognized as valid mathematical operators.
 *
 * Bugs: None known
 *
 * @author Mridul
 * @date January 21, 2026
 */

namespace AssignmentProject1;

public class IsValidOperatorTests
{
    [Fact]
    public void IsValidOperator_Addition_ReturnsTrue()
    {
        // Arrange
        string op = "+";
        
        // Act
        bool result = GeneralUtils.IsValidOperator(op);
        
        // Assert
        Assert.True(result);
    }

    [Fact]
    public void IsValidOperator_Subtraction_ReturnsTrue()
    {
        // Arrange
        string op = "-";
        
        // Act
        bool result = GeneralUtils.IsValidOperator(op);
        
        // Assert
        Assert.True(result);
    }

    [Fact]
    public void IsValidOperator_Multiplication_ReturnsTrue()
    {
        // Arrange
        string op = "*";
        
        // Act
        bool result = GeneralUtils.IsValidOperator(op);
        
        // Assert
        Assert.True(result);
    }

    [Fact]
    public void IsValidOperator_Division_ReturnsTrue()
    {
        // Arrange
        string op = "/";
        
        // Act
        bool result = GeneralUtils.IsValidOperator(op);
        
        // Assert
        Assert.True(result);
    }

    [Fact]
    public void IsValidOperator_FloorDivision_ReturnsTrue()
    {
        // Arrange
        string op = "//";
        
        // Act
        bool result = GeneralUtils.IsValidOperator(op);
        
        // Assert
        Assert.True(result);
    }

    [Fact]
    public void IsValidOperator_Modulus_ReturnsTrue()
    {
        // Arrange
        string op = "%";
        
        // Act
        bool result = GeneralUtils.IsValidOperator(op);
        
        // Assert
        Assert.True(result);
    }

    [Fact]
    public void IsValidOperator_Exponentiation_ReturnsTrue()
    {
        // Arrange
        string op = "**";
        
        // Act
        bool result = GeneralUtils.IsValidOperator(op);
        
        // Assert
        Assert.True(result);
    }

    [Fact]
    public void IsValidOperator_InvalidOperator_ReturnsFalse()
    {
        // Arrange
        string op = "&";
        
        // Act
        bool result = GeneralUtils.IsValidOperator(op);
        
        // Assert
        Assert.False(result);
    }

    [Fact]
    public void IsValidOperator_EmptyString_ReturnsFalse()
    {
        // Arrange
        string op = "";
        
        // Act
        bool result = GeneralUtils.IsValidOperator(op);
        
        // Assert
        Assert.False(result);
    }

    [Fact]
    public void IsValidOperator_Letter_ReturnsFalse()
    {
        // Arrange
        string op = "a";
        
        // Act
        bool result = GeneralUtils.IsValidOperator(op);
        
        // Assert
        Assert.False(result);
    }

    [Fact]
    public void IsValidOperator_Equals_ReturnsFalse()
    {
        // Arrange
        string op = "=";
        
        // Act
        bool result = GeneralUtils.IsValidOperator(op);
        
        // Assert
        Assert.False(result);
    }

    [Fact]
    public void IsValidOperator_TooLong_ReturnsFalse()
    {
        // Arrange
        string op = "***";
        
        // Act
        bool result = GeneralUtils.IsValidOperator(op);
        
        // Assert
        Assert.False(result);
    }

    [Fact]
    public void IsValidOperator_ComparisonOperator_ReturnsFalse()
    {
        // Arrange
        string op = "<";
        
        // Act
        bool result = GeneralUtils.IsValidOperator(op);
        
        // Assert
        Assert.False(result);
    }

    [Fact]
    public void IsValidOperator_LogicalOperator_ReturnsFalse()
    {
        // Arrange
        string op = "&&";
        
        // Act
        bool result = GeneralUtils.IsValidOperator(op);
        
        // Assert
        Assert.False(result);
    }

    [Fact]
    public void IsValidOperator_BitwiseOperator_ReturnsFalse()
    {
        // Arrange
        string op = "|";
        
        // Act
        bool result = GeneralUtils.IsValidOperator(op);
        
        // Assert
        Assert.False(result);
    }
}
