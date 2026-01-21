/**
 * Provides general utility methods for common operations including array/list manipulation,
 * string validation, and mathematical calculations. All methods are static and generic where applicable.
 * Copilot was used for header, comments and docstrings.
 * *
 * @author Mridul Agrawal and Graham Fink
 * @date January 21, 2026
 */

using System.Net.NetworkInformation;
using Xunit.Abstractions;

public static class GeneralUtils
{
    /// <summary>
    /// Checks if an array contains a specific item using equality comparison.
    /// </summary>
    /// <typeparam name="T">The type of elements in the array</typeparam>
    /// <param name="arr">The array to search</param>
    /// <param name="target">The item to search for</param>
    /// <returns>True if the array contains the target, false otherwise</returns>
    public static bool Contains<T>(T[] arr, T target)
    {
        // Iterate through each element in the array
        for (int i = 0; i < arr.Length; i++)
        {
            // Use EqualityComparer to check if current element equals target
            if (EqualityComparer<T>.Default.Equals(arr[i],(target))) return true;
        }
        // Target not found in array
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

    /// <summary>
    /// Returns a string with spaces for the specified indentation level.
    /// </summary>
    /// <param name="level">The indentation level (4 spaces per level)</param>
    /// <returns>A string containing 4 * level spaces</returns>
    /// <exception cref="ArgumentOutOfRangeException">Thrown when level is negative</exception>
    public static string GetIndentation(int level)
    {
        // Validate that level is non-negative
        if (level < 0) throw new ArgumentOutOfRangeException("Level must be positive");
        
        string indentation = "";
        // Build indentation string by adding 4 spaces per level
        for (int i = 0; i < level; i++)
        {
            indentation += "    ";
        }
        return indentation;
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

    /// <summary>
    /// Checks if a string contains only lowercase letters.
    /// </summary>
    /// <param name="name">The string to validate</param>
    /// <returns>True if the string contains only lowercase letters, false otherwise</returns>
    public static bool IsValidVariable(string name)
    {
        // Empty strings are not valid
        if (name.Equals("")) return false;
        
        // Check each character to ensure it's a lowercase letter
        foreach (char c in name)
        {
            // Character must be between 'a' and 'z' inclusive
            if (c > 'z' || c < 'a')
            {
                return false;
            }
        }
        return true;
    }

    /// <summary>
    /// Checks if a string is a valid mathematical operator.
    /// </summary>
    /// <param name="op">The string to validate</param>
    /// <returns>True if the string is one of: +, -, *, /, //, %, **</returns>
    public static bool IsValidOperator(string op)
    {
        // Check if operator matches any of the valid operators
        if (op.Equals("+") || op.Equals("-") || op.Equals("*") || op.Equals("/") || 
            op.Equals("//") || op.Equals("%") || op.Equals("**"))
        {
            return true;
        }
        return false;
    }

    /// <summary>
    /// Counts how many times a given character appears in a string.
    /// </summary>
    /// <param name="s">The string to search</param>
    /// <param name="c">The character to count</param>
    /// <returns>The number of occurrences of the character in the string</returns>
    public static int CountOccurrences(string s, char c)
    {
        int numberOfCharacters = 0;
        
        // Iterate through each character in the string
        foreach (char d in s)
        {
            // Increment counter if character matches
            if (d.Equals(c)) numberOfCharacters++;
        }
        return numberOfCharacters;
    }

        /// <summary>
    /// Converts space-separated words to camelCase format.
    /// The first character is lowercase, spaces are removed, and the first letter 
    /// after each space is capitalized.
    /// </summary>
    /// <param name="s">The space-separated string to convert</param>
    /// <returns>The string in camelCase format</returns>
    /// <example>
    /// "Hello world test string" returns "helloWorldTestString"
    /// </example>
    public static string ToCamelCase(string s)
    {
        string result = "";
        bool capitalizeNextLetter = false;
        bool firstLetter = true;
        
        // Process each character in the input string
        foreach (char c in s)
        {
            // Skip spaces but mark that next letter should be capitalized
            if (c.Equals(' '))
            {
                capitalizeNextLetter = true;
                continue;
            }
            
            // Capitalize if this follows a space
            if (capitalizeNextLetter && !firstLetter)
            {
                result += char.ToUpper(c);
            }
            else 
            {
                // Lowercase the character
                result += char.ToLower(c);
                firstLetter = false;
            }
            capitalizeNextLetter = false;
        }
        return result;
    }

}