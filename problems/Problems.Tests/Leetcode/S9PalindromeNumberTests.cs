using Problems.Leetcode;

namespace Problems.Tests.Leetcode;

public class S9PalindromeNumberTests
{
    private readonly S9PalindromeNumber _solution = new S9PalindromeNumber();

    [Fact]
    public void IsPalindrome_PositivePalindrome_ReturnsTrue()
    {
        // Arrange
        int x = 121;

        // Act
        var result = _solution.IsPalindrome(x);

        // Assert
        Assert.True(result);
    }

    [Fact]
    public void IsPalindrome_NegativeNumber_ReturnsFalse()
    {
        // Arrange
        int x = -121;

        // Act
        var result = _solution.IsPalindrome(x);

        // Assert
        Assert.False(result);
    }

    [Fact]
    public void IsPalindrome_NumberEndingInZero_ReturnsFalse()
    {
        // Arrange
        int x = 10;

        // Act
        var result = _solution.IsPalindrome(x);

        // Assert
        Assert.False(result);
    }

    [Fact]
    public void IsPalindrome_SingleDigit_ReturnsTrue()
    {
        // Arrange
        int x = 7;

        // Act
        var result = _solution.IsPalindrome(x);

        // Assert
        Assert.True(result);
    }

    [Fact]
    public void IsPalindrome_Zero_ReturnsTrue()
    {
        // Arrange
        int x = 0;

        // Act
        var result = _solution.IsPalindrome(x);

        // Assert
        Assert.True(result);
    }

    [Fact]
    public void IsPalindrome_EvenDigitPalindrome_ReturnsTrue()
    {
        // Arrange
        int x = 1221;

        // Act
        var result = _solution.IsPalindrome(x);

        // Assert
        Assert.True(result);
    }

    [Fact]
    public void IsPalindrome_OddDigitPalindrome_ReturnsTrue()
    {
        // Arrange
        int x = 12321;

        // Act
        var result = _solution.IsPalindrome(x);

        // Assert
        Assert.True(result);
    }

    [Fact]
    public void IsPalindrome_NonPalindrome_ReturnsFalse()
    {
        // Arrange
        int x = 123;

        // Act
        var result = _solution.IsPalindrome(x);

        // Assert
        Assert.False(result);
    }

    [Fact]
    public void IsPalindrome_LargePalindrome_ReturnsTrue()
    {
        // Arrange
        int x = 1234321;

        // Act
        var result = _solution.IsPalindrome(x);

        // Assert
        Assert.True(result);
    }
}