/**
 * Tests for the GetUniqueItems method in GeneralUtils class.
 * Validates unique item extraction from lists with various duplicate patterns.
 *
 * Bugs: None known
 *
 * @author Mridul
 * @date January 21, 2026
 */

namespace AssignmentProject1;

public class GetUniqueItemsTests
{
    [Fact]
    public void GetUniqueItems_ListWithDuplicates_ReturnsUniqueItems()
    {
        // Arrange
        List<int> numbers = new List<int> { 1, 2, 2, 3, 3, 3, 4 };
        
        // Act
        var result = GeneralUtils.GetUniqueItems(numbers);
        
        // Assert
        Assert.Equal(4, result.Count);
        Assert.Contains(1, result);
        Assert.Contains(2, result);
        Assert.Contains(3, result);
        Assert.Contains(4, result);
    }

    [Fact]
    public void GetUniqueItems_ListWithoutDuplicates_ReturnsSameItems()
    {
        // Arrange
        List<int> numbers = new List<int> { 1, 2, 3, 4, 5 };
        
        // Act
        var result = GeneralUtils.GetUniqueItems(numbers);
        
        // Assert
        Assert.Equal(5, result.Count);
        Assert.Contains(1, result);
        Assert.Contains(2, result);
        Assert.Contains(3, result);
        Assert.Contains(4, result);
        Assert.Contains(5, result);
    }

    [Fact]
    public void GetUniqueItems_EmptyList_ThrowsArgumentException()
    {
        // Arrange
        List<int> numbers = new List<int>();
        
        // Act & Assert
        var result = GeneralUtils.GetUniqueItems(numbers);

        Assert.Empty(result);
    }

    [Fact]
    public void GetUniqueItems_AllDuplicates_ReturnsSingleItem()
    {
        // Arrange
        List<int> numbers = new List<int> { 5, 5, 5, 5, 5 };
        
        // Act
        var result = GeneralUtils.GetUniqueItems(numbers);
        
        // Assert
        Assert.Single(result);
        Assert.Contains(5, result);
    }

    [Fact]
    public void GetUniqueItems_StringList_ReturnsUniqueStrings()
    {
        // Arrange
        List<string> words = new List<string> { "apple", "banana", "apple", "cherry", "banana" };
        
        // Act
        var result = GeneralUtils.GetUniqueItems(words);
        
        // Assert
        Assert.Equal(3, result.Count);
        Assert.Contains("apple", result);
        Assert.Contains("banana", result);
        Assert.Contains("cherry", result);
    }

    [Fact]
    public void GetUniqueItems_PreservesOrder_ReturnsFirstOccurrence()
    {
        // Arrange
        List<int> numbers = new List<int> { 3, 1, 2, 1, 3, 2 };
        
        // Act
        var result = GeneralUtils.GetUniqueItems(numbers);
        
        // Assert
        Assert.Equal(3, result.Count);
        Assert.Equal(3, result[0]);
        Assert.Equal(1, result[1]);
        Assert.Equal(2, result[2]);
    }

    [Fact]
    public void GetUniqueItems_SingleItem_ReturnsSingleItemList()
    {
        // Arrange
        List<int> numbers = new List<int> { 42 };
        
        // Act
        var result = GeneralUtils.GetUniqueItems(numbers);
        
        // Assert
        Assert.Single(result);
        Assert.Equal(42, result[0]);
    }

    [Fact]
    public void GetUniqueItems_NullList_ThrowsArgumentException()
    {
        // Arrange
        List<int> numbers = null;
        
        // Act & Assert
        Assert.Throws<ArgumentException>(() => GeneralUtils.GetUniqueItems(numbers));
    }

    [Fact]
    public void GetUniqueItems_ConsecutiveDuplicates_ReturnsUniqueItems()
    {
        // Arrange
        List<int> numbers = new List<int> { 1, 1, 2, 2, 3, 3 };
        
        // Act
        var result = GeneralUtils.GetUniqueItems(numbers);
        
        // Assert
        Assert.Equal(3, result.Count);
        Assert.Contains(1, result);
        Assert.Contains(2, result);
        Assert.Contains(3, result);
    }

    [Fact]
    public void GetUniqueItems_NonConsecutiveDuplicates_ReturnsUniqueItems()
    {
        // Arrange
        List<int> numbers = new List<int> { 1, 2, 3, 1, 2, 3 };
        
        // Act
        var result = GeneralUtils.GetUniqueItems(numbers);
        
        // Assert
        Assert.Equal(3, result.Count);
        Assert.Contains(1, result);
        Assert.Contains(2, result);
        Assert.Contains(3, result);
    }

    [Fact]
    public void GetUniqueItems_MixedDuplicates_ReturnsUniqueItems()
    {
        // Arrange
        List<int> numbers = new List<int> { 1, 2, 1, 3, 2, 4, 3, 5 };
        
        // Act
        var result = GeneralUtils.GetUniqueItems(numbers);
        
        // Assert
        Assert.Equal(5, result.Count);
        Assert.Contains(1, result);
        Assert.Contains(2, result);
        Assert.Contains(3, result);
        Assert.Contains(4, result);
        Assert.Contains(5, result);
    }
}
