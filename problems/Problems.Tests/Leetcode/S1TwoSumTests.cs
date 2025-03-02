using Problems.Leetcode;

namespace Problems.Tests;

public class S1TwoSumTests
{
    [Fact]
    public void Test_TwoSum_Example1()
    {
        var solution = new S1TwoSum();
        int[] nums = { 2, 7, 11, 15 };
        int target = 9;
        int[] expected = { 0, 1 };
        int[] result = solution.TwoSum(nums, target);
        Assert.Equal(expected.OrderBy(x => x), result.OrderBy(x => x));
    }

    [Fact]
    public void Test_TwoSum_Example2()
    {
        var solution = new S1TwoSum();
        int[] nums = { 3, 2, 4 };
        int target = 6;
        int[] expected = { 1, 2 };
        int[] result = solution.TwoSum(nums, target);
        Assert.Equal(expected.OrderBy(x => x), result.OrderBy(x => x));
    }

    [Fact]
    public void Test_TwoSum_Example3()
    {
        var solution = new S1TwoSum();
        int[] nums = { 3, 3 };
        int target = 6;
        int[] expected = { 0, 1 };
        int[] result = solution.TwoSum(nums, target);
        Assert.Equal(expected.OrderBy(x => x), result.OrderBy(x => x));
    }

    [Fact]
    public void Test_TwoSum_NegativeNumbers()
    {
        var solution = new S1TwoSum();
        int[] nums = { -3, 4, 3, 90 };
        int target = 0;
        int[] expected = { 0, 2 };
        int[] result = solution.TwoSum(nums, target);
        Assert.Equal(expected.OrderBy(x => x), result.OrderBy(x => x));
    }
}