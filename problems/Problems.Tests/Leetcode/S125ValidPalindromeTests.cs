using Problems.Leetcode;

namespace Problems.Tests.Leetcode;

public class S125ValidPalindromeTests
{
    [Theory]
    [InlineData("tab a cat", false)]
    [InlineData("A man, a plan, a canal, Panama", true)]
    [InlineData("No 'x' in Nixon", true)]
    [InlineData("race a car", false)]
    [InlineData("", true)]
    [InlineData(" ", true)]
    [InlineData("a", true)]
    [InlineData("ab", false)]
    [InlineData("!aba", true)]
    public void IsPalindrome_ShouldReturnExpectedResult(string input, bool expected)
    {
        // Arrange
        var solution = new S125ValidPalindrome();

        // Act
        var result = solution.IsPalindrome(input);

        // Assert
        Assert.Equal(expected, result);
    }
}
