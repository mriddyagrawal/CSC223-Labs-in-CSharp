/**
 * Tests for the Duplicates method in GeneralUtils class.
 * Validates duplicate detection in arrays with various data types and patterns.
 *
 * Bugs: None known
 *
 * @author Mridul
 * @date January 21, 2026
 */

namespace AssignmentProject1;

public class DuplicatesTests
{
    [Fact]
    public void Duplicates_ArrayWithDuplicates_ReturnsDuplicateItems()
    {
        // Arrange
        int[] numbers = { 1, 2, 2, 3, 3, 3, 4 };
        
        // Act
        var result = GeneralUtils.Duplicates(numbers);
        
        // Assert
        Assert.Equal(2, result.Length);
        Assert.Contains(2, result);
        Assert.Contains(3, result);
    }

    [Fact]
    public void Duplicates_ArrayWithoutDuplicates_ReturnsEmpty()
    {
        // Arrange
        int[] numbers = { 1, 2, 3, 4, 5 };
        
        // Act
        var result = GeneralUtils.Duplicates(numbers);
        
        // Assert
        Assert.Empty(result);
    }

    [Fact]
    public void Duplicates_EmptyArray_ReturnsEmpty()
    {
        // Arrange
        int[] numbers = { };
        
        // Act
        var result = GeneralUtils.Duplicates(numbers);
        
        // Assert
        Assert.Empty(result);
    }

    [Fact]
    public void Duplicates_AllItemsDuplicated_ReturnsAllItems()
    {
        // Arrange
        int[] numbers = { 1, 1, 2, 2, 3, 3 };
        
        // Act
        var result = GeneralUtils.Duplicates(numbers);
        
        // Assert
        Assert.Equal(3, result.Length);
        Assert.Contains(1, result);
        Assert.Contains(2, result);
        Assert.Contains(3, result);
    }

    [Fact]
    public void Duplicates_SingleDuplicate_ReturnsThatItem()
    {
        // Arrange
        int[] numbers = { 1, 2, 3, 3, 4, 5 };
        
        // Act
        var result = GeneralUtils.Duplicates(numbers);
        
        // Assert
        Assert.Single(result);
        Assert.Contains(3, result);
    }

    [Fact]
    public void Duplicates_StringArray_ReturnsDuplicateStrings()
    {
        // Arrange
        string[] words = { "apple", "banana", "apple", "cherry", "banana", "date" };
        
        // Act
        var result = GeneralUtils.Duplicates(words);
        
        // Assert
        Assert.Equal(2, result.Length);
        Assert.Contains("apple", result);
        Assert.Contains("banana", result);
    }

    [Fact]
    public void Duplicates_AllSameItem_ReturnsSingleItem()
    {
        // Arrange
        int[] numbers = { 5, 5, 5, 5, 5 };
        
        // Act
        var result = GeneralUtils.Duplicates(numbers);
        
        // Assert
        Assert.Single(result);
        Assert.Contains(5, result);
    }

    [Fact]
    public void Duplicates_NullArray_ThrowsNullReferenceException()
    {
        // Arrange
        int[] numbers = null;
        
        // Act & Assert
        Assert.Throws<NullReferenceException>(() => GeneralUtils.Duplicates(numbers));
    }

    [Fact]
    public void Duplicates_SingleItem_ReturnsEmpty()
    {
        // Arrange
        int[] numbers = { 42 };
        
        // Act
        var result = GeneralUtils.Duplicates(numbers);
        
        // Assert
        Assert.Empty(result);
    }

    [Fact]
    public void Duplicates_TwoOfEachItem_ReturnsAllItems()
    {
        // Arrange
        int[] numbers = { 1, 1, 2, 2, 3, 3, 4, 4 };
        
        // Act
        var result = GeneralUtils.Duplicates(numbers);
        
        // Assert
        Assert.Equal(4, result.Length);
        Assert.Contains(1, result);
        Assert.Contains(2, result);
        Assert.Contains(3, result);
        Assert.Contains(4, result);
    }

    [Fact]
    public void Duplicates_MultipleOccurrences_ReturnsItemOnce()
    {
        // Arrange
        int[] numbers = { 1, 1, 1, 1, 2, 3 };
        
        // Act
        var result = GeneralUtils.Duplicates(numbers);
        
        // Assert
        Assert.Single(result);
        Assert.Contains(1, result);
    }

    [Fact]
    public void Duplicates_NonConsecutiveDuplicates_ReturnsDuplicates()
    {
        // Arrange
        int[] numbers = { 1, 2, 3, 1, 4, 2 };
        
        // Act
        var result = GeneralUtils.Duplicates(numbers);
        
        // Assert
        Assert.Equal(2, result.Length);
        Assert.Contains(1, result);
        Assert.Contains(2, result);
    }

    [Fact]
    public void Duplicates_MixedDuplicatesAndUniques_ReturnsOnlyDuplicates()
    {
        // Arrange
        int[] numbers = { 1, 2, 2, 3, 4, 4, 5, 6, 6 };
        
        // Act
        var result = GeneralUtils.Duplicates(numbers);
        
        // Assert
        Assert.Equal(3, result.Length);
        Assert.Contains(2, result);
        Assert.Contains(4, result);
        Assert.Contains(6, result);
        Assert.DoesNotContain(1, result);
        Assert.DoesNotContain(3, result);
        Assert.DoesNotContain(5, result);
    }

    [Fact]
    public void Duplicates_ArrayWithNull_ReturnsDuplicatesExcludingNull()
    {
        // Arrange
        int?[] numbers = { 1, 2, 3, null, 4, 4 };
        
        // Act
        Assert.Throws<NullReferenceException>(() => GeneralUtils.Duplicates(numbers));

    }
}
