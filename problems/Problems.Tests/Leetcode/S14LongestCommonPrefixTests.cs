using Problems.Leetcode;

namespace Problems.Tests.Leetcode;

public class S14LongestCommonPrefixTests
{
    private readonly S14LongestCommonPrefix _solution = new S14LongestCommonPrefix();

    [Fact]
    public void LongestCommonPrefix_WithCommonPrefix_ReturnsCorrectPrefix()
    {
        // Arrange
        string[] strs = { "flower", "flow", "flight" };

        // Act
        var result = _solution.LongestCommonPrefix(strs);

        // Assert
        Assert.Equal("fl", result);
    }

    [Fact]
    public void LongestCommonPrefix_NoCommonPrefix_ReturnsEmptyString()
    {
        // Arrange
        string[] strs = { "dog", "racecar", "car" };

        // Act
        var result = _solution.LongestCommonPrefix(strs);

        // Assert
        Assert.Equal("", result);
    }

    [Fact]
    public void LongestCommonPrefix_SingleString_ReturnsTheString()
    {
        // Arrange
        string[] strs = { "alone" };

        // Act
        var result = _solution.LongestCommonPrefix(strs);

        // Assert
        Assert.Equal("alone", result);
    }

    [Fact]
    public void LongestCommonPrefix_EmptyArray_ReturnsEmptyString()
    {
        // Arrange
        string[] strs = { };

        // Act
        var result = _solution.LongestCommonPrefix(strs);

        // Assert
        Assert.Equal("", result);
    }

    [Fact]
    public void LongestCommonPrefix_IdenticalStrings_ReturnsTheString()
    {
        // Arrange
        string[] strs = { "test", "test", "test" };

        // Act
        var result = _solution.LongestCommonPrefix(strs);

        // Assert
        Assert.Equal("test", result);
    }

    [Fact]
    public void LongestCommonPrefix_OneEmptyString_ReturnsEmptyString()
    {
        // Arrange
        string[] strs = { "flower", "", "flight" };

        // Act
        var result = _solution.LongestCommonPrefix(strs);

        // Assert
        Assert.Equal("", result);
    }

    [Fact]
    public void LongestCommonPrefix_PrefixIsOneOfTheStrings_ReturnsPrefix()
    {
        // Arrange
        string[] strs = { "ab", "abc", "abcd" };

        // Act
        var result = _solution.LongestCommonPrefix(strs);

        // Assert
        Assert.Equal("ab", result);
    }

    [Fact]
    public void LongestCommonPrefix_SingleCharacterCommon_ReturnsSingleCharacter()
    {
        // Arrange
        string[] strs = { "apple", "application", "apply" };

        // Act
        var result = _solution.LongestCommonPrefix(strs);

        // Assert
        Assert.Equal("appl", result);
    }

    [Fact]
    public void LongestCommonPrefix_TwoStrings_ReturnsCommonPrefix()
    {
        // Arrange
        string[] strs = { "interview", "internet" };

        // Act
        var result = _solution.LongestCommonPrefix(strs);

        // Assert
        Assert.Equal("inter", result);
    }
}