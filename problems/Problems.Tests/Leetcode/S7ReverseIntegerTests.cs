using Problems.Leetcode;

namespace Problems.Tests.Leetcode;

public class S7ReverseIntegerTests
{
    private readonly S7ReverseInteger _solution = new S7ReverseInteger();

    [Fact]
    public void Reverse_PositiveNumber_ReturnsReversed()
    {
        // Arrange
        int x = 123;

        // Act
        var result = _solution.Reverse(x);

        // Assert
        Assert.Equal(321, result);
    }

    [Fact]
    public void Reverse_NegativeNumber_ReturnsReversed()
    {
        // Arrange
        int x = -123;

        // Act
        var result = _solution.Reverse(x);

        // Assert
        Assert.Equal(-321, result);
    }

    [Fact]
    public void Reverse_NumberWithTrailingZero_ReturnsReversed()
    {
        // Arrange
        int x = 120;

        // Act
        var result = _solution.Reverse(x);

        // Assert
        Assert.Equal(21, result);
    }

    [Fact]
    public void Reverse_Zero_ReturnsZero()
    {
        // Arrange
        int x = 0;

        // Act
        var result = _solution.Reverse(x);

        // Assert
        Assert.Equal(0, result);
    }

    [Fact]
    public void Reverse_Overflow_ReturnsZero()
    {
        // Arrange - This would overflow when reversed
        int x = 1534236469;

        // Act
        var result = _solution.Reverse(x);

        // Assert
        Assert.Equal(0, result);
    }

    [Fact]
    public void Reverse_MaxValue_ReturnsZero()
    {
        // Arrange
        int x = int.MaxValue; // 2147483647

        // Act
        var result = _solution.Reverse(x);

        // Assert
        Assert.Equal(0, result); // Reverse would cause overflow
    }

    [Fact]
    public void Reverse_SingleDigit_ReturnsSameDigit()
    {
        // Arrange
        int x = 7;

        // Act
        var result = _solution.Reverse(x);

        // Assert
        Assert.Equal(7, result);
    }
}