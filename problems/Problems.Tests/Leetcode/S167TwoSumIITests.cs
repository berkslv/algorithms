using Problems.Leetcode;

namespace Problems.Tests.Leetcode;

public class S167TwoSumIITests
{
    private readonly S167TwoSumII _solution = new();

    [Theory]
    [InlineData(new[] { 2, 7, 11, 15 }, 9, new[] { 1, 2 })]
    [InlineData(new[] { 2, 3, 4 }, 6, new[] { 1, 3 })]
    [InlineData(new[] { -1, 0 }, -1, new[] { 1, 2 })]
    public void Test1(int[] numbers, int target, int[] expected)
    {
        var result = _solution.TwoSum(numbers, target);
        Assert.Equal(expected, result);
    }
}