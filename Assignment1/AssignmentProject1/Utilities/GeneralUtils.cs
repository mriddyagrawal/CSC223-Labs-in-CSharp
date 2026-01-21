/**
 * Provides general utility methods for common operations including array/list manipulation,
 * string validation, and mathematical calculations. All methods are static and generic where applicable.
 *
 * Bugs: None known
 *
 * @author Mridul
 * @date January 21, 2026
 */

using System.Net.NetworkInformation;
using Xunit.Abstractions;

public static class GeneralUtils
{
    #region Array and List Operations

    /// <summary>
    /// Checks if a specific item exists in an array.
    /// </summary>
    /// <typeparam name="T">The type of elements in the array</typeparam>
    /// <param name="array">The array to search through</param>
    /// <param name="item">The item to search for</param>
    /// <returns>True if the item is found; otherwise, false</returns>
    public static bool Contains<T>(T[] array, T item)
    {
        // Iterate through each element to check for equality
        foreach (var element in array)
        {
            if (EqualityComparer<T>.Default.Equals(element, item))
            {
                return true;
            }
        }
        return false;
    }

    /// <summary>
    /// Returns a list of unique items from the input list, preserving the order of first occurrence.
    /// </summary>
    /// <typeparam name="T">The type of elements in the list</typeparam>
    /// <param name="list">The list to process</param>
    /// <returns>A list containing only unique items</returns>
    /// <exception cref="ArgumentException">Thrown when the input list is null</exception>
    public static List<T> GetUniqueItems<T>(List<T> list )
    {
        List<T> uniqueList = new List<T>();

        // Validate input
        if (list == null) throw new ArgumentException("Input list is null or empty.");

        // Add items only if they haven't been seen before
        foreach (var item in list)
        {
            if (!uniqueList.Contains(item)) uniqueList.Add(item);
        }

        return uniqueList;
    }

    /// <summary>
    /// Finds and returns all duplicate items from an array (items that appear more than once).
    /// </summary>
    /// <typeparam name="T">The type of elements in the array</typeparam>
    /// <param name="array">The array to search for duplicates</param>
    /// <returns>An array containing items that appear more than once</returns>
    /// <exception cref="NullReferenceException">Thrown when the array is null or contains null items</exception>
    public static T[] Duplicates<T>(T[] array)
    {        
        // Validate input array
        if (array == null) throw new NullReferenceException("Input array is null.");
        
        Dictionary<T, int> itemCounts = new Dictionary<T, int>();
        List<T> duplicates = new List<T>();

        // Count occurrences of each item
        foreach (T item in array)
        {     
            if (item == null) throw new NullReferenceException("Array cannot contain null items.");

            if (itemCounts.ContainsKey(item))
            {
                itemCounts[item]++;
            }
            else
            {
                itemCounts[item] = 1;
            }
        }

        // Collect items that appear more than once
        foreach (var KeyValue in itemCounts)
        {
            if (KeyValue.Value > 1)
            {
                duplicates.Add(KeyValue.Key);
            }
        }

        return duplicates.ToArray();
    }

    #endregion

    #region String Utilities

    /// <summary>
    /// Generates an indentation string based on the specified nesting level.
    /// Each level produces 4 spaces.
    /// </summary>
    /// <param name="level">The indentation level (0 = no indentation)</param>
    /// <returns>A string containing the appropriate number of spaces</returns>
    public static string GetIndentation(int level)
    {
        return new string(' ', level * 4);
    }

    /// <summary>
    /// Validates whether a password meets strong password requirements.
    /// A strong password must be at least 8 characters long and contain at least one uppercase letter,
    /// one lowercase letter, one digit, and one special character.
    /// </summary>
    /// <param name="pwd">The password string to validate</param>
    /// <returns>True if the password meets all requirements; otherwise, false</returns>
    public static bool IsPasswordStrong(string pwd)
    {
        // Check minimum length requirement
        if (pwd.Length < 8)
            return false;

        // Initialize condition variables
        bool containsUpper = false, containsLower = false, containsDigit = false, containsSpecialChar = false;

        // Check for presence of each required character type
        foreach (char a in pwd) {
            if (char.IsUpper(a)) containsUpper = true;
            else if (char.IsLower(a)) containsLower = true;
            else if (!char.IsLetterOrDigit(a)) containsSpecialChar = true;
            else if (char.IsDigit(a)) containsDigit = true;
            }

        // All four conditions must be met
        return (containsUpper && containsLower && containsDigit && containsSpecialChar);
    }

    /// <summary>
    /// Calculates the average of a set of numbers.
    /// </summary>
    /// <param name="numbers">An array of integers to calculate the average from</param>
    /// <returns>The average as a double</returns>
    /// <exception cref="ArgumentException">Thrown when the array is null or empty</exception>
    public static double CalculateAverage(int[] numbers)
    {
        // Make either sum or count double to avoid just integer division later
        int sum = 0;
        double count = 0;

        // Validate input
        if (numbers == null || numbers.Length == 0) throw new ArgumentException("Input list is null or empty.");

        // Sum all numbers and count them
        foreach (int number in numbers)
        {
            sum = sum + number;
            count++;
        }

        return (sum / count);
    }

    #endregion

}