using Problems.Leetcode;
using Xunit;

namespace Problems.Tests.Leetcode;

public class S29DivideTwoIntegersTests
{
    [Theory]
    [InlineData(10, 3, 3)]
    [InlineData(7, -3, -2)]
    [InlineData(0, 1, 0)]
    [InlineData(1, 1, 1)]
    [InlineData(int.MaxValue, 1, int.MaxValue)]
    [InlineData(int.MinValue, -1, int.MaxValue)]
    [InlineData(int.MinValue, 1, int.MinValue)]
    public void Test_Divide(int dividend, int divisor, int expected)
    {
        var solution = new S29DivideTwoIntegers();
        var result = solution.Divide(dividend, divisor);
        Assert.Equal(expected, result);
    }
}
