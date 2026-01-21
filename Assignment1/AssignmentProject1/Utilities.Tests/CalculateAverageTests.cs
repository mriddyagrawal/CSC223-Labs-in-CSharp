/**
 * Tests for the CalculateAverage method in GeneralUtils class.
 * Validates average calculation with various numeric inputs and edge cases.
 *
 * Bugs: None known
 *
 * @author Mridul
 * @date January 21, 2026
 */

namespace AssignmentProject1;

public class CalculateAverageTests
{
    [Fact]
    public void CalculateAverage_ValidArray_ReturnsCorrectAverage()
    {
        // Arrange
        int[] numbers = { 2, 4, 6, 8, 10 };
        
        // Act
        double result = GeneralUtils.CalculateAverage(numbers);
        
        // Assert
        Assert.Equal(6.0, result);
    }

    [Fact]
    public void CalculateAverage_SingleElement_ReturnsThatElement()
    {
        // Arrange
        int[] numbers = { 42 };
        
        // Act
        double result = GeneralUtils.CalculateAverage(numbers);
        
        // Assert
        Assert.Equal(42.0, result);
    }

    [Fact]
    public void CalculateAverage_AllZeros_ReturnsZero()
    {
        // Arrange
        int[] numbers = { 0, 0, 0, 0 };
        
        // Act
        double result = GeneralUtils.CalculateAverage(numbers);
        
        // Assert
        Assert.Equal(0.0, result);
    }

    [Fact]
    public void CalculateAverage_NegativeNumbers_ReturnsCorrectAverage()
    {
        // Arrange
        int[] numbers = { -10, -20, -30 };
        
        // Act
        double result = GeneralUtils.CalculateAverage(numbers);
        
        // Assert
        Assert.Equal(-20.0, result);
    }

    [Fact]
    public void CalculateAverage_MixedPositiveNegative_ReturnsCorrectAverage()
    {
        // Arrange
        int[] numbers = { -5, 0, 5, 10 };
        
        // Act
        double result = GeneralUtils.CalculateAverage(numbers);
        
        // Assert
        Assert.Equal(2.5, result);
    }

    [Fact]
    public void CalculateAverage_TwoNumbers_ReturnsCorrectAverage()
    {
        // Arrange
        int[] numbers = { 10, 20 };
        
        // Act
        double result = GeneralUtils.CalculateAverage(numbers);
        
        // Assert
        Assert.Equal(15.0, result);
    }

    [Fact]
    public void CalculateAverage_LargeNumbers_ReturnsCorrectAverage()
    {
        // Arrange
        int[] numbers = { 1000, 2000, 3000 };
        
        // Act
        double result = GeneralUtils.CalculateAverage(numbers);
        
        // Assert
        Assert.Equal(2000.0, result);
    }

    [Fact]
    public void CalculateAverage_NullArray_ThrowsArgumentException()
    {
        // Arrange
        int[] numbers = null;
        
        // Act & Assert
        Assert.Throws<ArgumentException>(() => GeneralUtils.CalculateAverage(numbers));
    }

    [Fact]
    public void CalculateAverage_EmptyArray_ThrowsArgumentException()
    {
        // Arrange
        int[] numbers = { };
        
        // Act & Assert
        Assert.Throws<ArgumentException>(() => GeneralUtils.CalculateAverage(numbers));
    }

    [Fact]
    public void CalculateAverage_OddCount_ReturnsCorrectAverage()
    {
        // Arrange
        int[] numbers = { 1, 2, 3, 4, 5 };
        
        // Act
        double result = GeneralUtils.CalculateAverage(numbers);
        
        // Assert
        Assert.Equal(3.0, result);
    }

    [Fact]
    public void CalculateAverage_EvenCount_ReturnsCorrectAverage()
    {
        // Arrange
        int[] numbers = { 1, 2, 3, 4 };
        
        // Act
        double result = GeneralUtils.CalculateAverage(numbers);
        
        // Assert
        Assert.Equal(2.5, result);
    }
}
