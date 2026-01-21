/**
 * Tests for the Contains method in GeneralUtils class.
 * Validates array search functionality for various data types and edge cases.
 *
 * Bugs: None known
 *
 * @author Mridul
 * @date January 21, 2026
 */

namespace AssignmentProject1;

public class GeneralUtilsTests
{
    [Fact]
    public void Contains_ItemExistsInArray_ReturnsTrue()
    {
        // Arrange
        int[] numbers = { 1, 2, 3, 4, 5 };
        
        // Act
        bool result = GeneralUtils.Contains(numbers, 3);
        
        // Assert
        Assert.True(result);
    }

    [Fact]
    public void Contains_ItemNotInArray_ReturnsFalse()
    {
        // Arrange
        int[] numbers = { 1, 2, 3, 4, 5 };
        
        // Act
        bool result = GeneralUtils.Contains(numbers, 10);
        
        // Assert
        Assert.False(result);
    }

    [Fact]
    public void Contains_EmptyArray_ReturnsFalse()
    {
        // Arrange
        int[] numbers = { };
        
        // Act
        bool result = GeneralUtils.Contains(numbers, 1);
        
        // Assert
        Assert.False(result);
    }

    [Fact]
    public void Contains_ItemAtBeginning_ReturnsTrue()
    {
        // Arrange
        string[] words = { "apple", "banana", "cherry" };
        
        // Act
        bool result = GeneralUtils.Contains(words, "apple");
        
        // Assert
        Assert.True(result);
    }

    [Fact]
    public void Contains_ItemAtEnd_ReturnsTrue()
    {
        // Arrange
        string[] words = { "apple", "banana", "cherry" };
        
        // Act
        bool result = GeneralUtils.Contains(words, "cherry");
        
        // Assert
        Assert.True(result);
    }

    [Fact]
    public void Contains_StringArray_CaseSensitive()
    {
        // Arrange
        string[] words = { "Apple", "Banana", "Cherry" };
        
        // Act
        bool resultLower = GeneralUtils.Contains(words, "apple");
        bool resultUpper = GeneralUtils.Contains(words, "Apple");
        
        // Assert
        Assert.False(resultLower);
        Assert.True(resultUpper);
    }

    [Fact]
    public void Contains_NullItemInArray_FindsNull()
    {
        // Arrange
        string?[] words = { "apple", null, "cherry" };
        
        // Act
        bool result = GeneralUtils.Contains(words, null);
        
        // Assert
        Assert.True(result);
    }

    [Fact]
    public void Contains_SearchForNullNotInArray_ReturnsFalse()
    {
        // Arrange
        string[] words = { "apple", "banana", "cherry" };
        
        // Act
        bool result = GeneralUtils.Contains(words, null);
        
        // Assert
        Assert.False(result);
    }

    [Fact]
    public void Contains_SingleElementArray_Found()
    {
        // Arrange
        int[] numbers = { 42 };
        
        // Act
        bool result = GeneralUtils.Contains(numbers, 42);
        
        // Assert
        Assert.True(result);
    }

    [Fact]
    public void Contains_SingleElementArray_NotFound()
    {
        // Arrange
        int[] numbers = { 42 };
        
        // Act
        bool result = GeneralUtils.Contains(numbers, 100);
        
        // Assert
        Assert.False(result);
    }

    [Fact]
    public void Contains_DoubleArray_FindsItem()
    {
        // Arrange
        double[] values = { 1.5, 2.7, 3.14, 4.0 };
        
        // Act
        bool result = GeneralUtils.Contains(values, 3.14);
        
        // Assert
        Assert.True(result);
    }

    [Fact]
    public void Contains_DuplicateItems_ReturnsTrue()
    {
        // Arrange
        int[] numbers = { 1, 2, 3, 2, 5 };
        
        // Act
        bool result = GeneralUtils.Contains(numbers, 2);
        
        // Assert
        Assert.True(result);
    }

        public static IEnumerable<object[]> ContainsIntTestData =>
        new List<object[]>
        {
            new object[] { new int[] { 1, 2, 3, 4, 5 }, 3, true },
            new object[] { new int[] { 1, 2, 3, 4, 5 }, 6, false },
            new object[] { new int[] { 10 }, 10, true },
            new object[] { new int[] { 10 }, 5, false },
            new object[] { new int[] { -1, 0, 1 }, 0, true },
            new object[] { new int[] { }, 1, false }
        };

    [Theory]
    [MemberData(nameof(ContainsIntTestData))]
    public void Contains_WithIntArray_ReturnsExpectedResult(int[] arr, int target, bool expected)
    {
        bool result = GeneralUtils.Contains(arr, target);
        Assert.Equal(expected, result);
    }

    public static IEnumerable<object[]> ContainsStringTestData =>
        new List<object[]>
        {
            new object[] { new string[] { "apple", "banana", "cherry" }, "banana", true },
            new object[] { new string[] { "apple", "banana", "cherry" }, "orange", false },
            new object[] { new string[] { "hello" }, "hello", true },
            new object[] { new string[] { "" }, "", true },
            new object[] { new string[] { }, "test", false }
        };

    [Theory]
    [MemberData(nameof(ContainsStringTestData))]
    public void Contains_WithStringArray_ReturnsExpectedResult(string[] arr, string target, bool expected)
    {
        bool result = GeneralUtils.Contains(arr, target);
        Assert.Equal(expected, result);
    }
}
