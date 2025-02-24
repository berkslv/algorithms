namespace Problems.Tests;

public class S150ValidPalindromeTests
{
    [Theory]
    [InlineData("Was it a car or a cat I saw?", true)]
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
        var solution = new S150ValidPalindrome();

        // Act
        var result = solution.IsPalindrome(input);

        // Assert
        Assert.Equal(expected, result);
    }
}
