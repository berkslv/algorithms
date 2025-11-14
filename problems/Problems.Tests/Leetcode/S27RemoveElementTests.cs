using Problems.Leetcode;
using Xunit;

namespace Problems.Tests.Leetcode;

public class S27RemoveElementTests
{
    [Fact]
    public void Test_RemoveElement_Example1()
    {
        var solution = new S27RemoveElement();
        int[] nums = { 3, 2, 2, 3 };
        int val = 3;
        int k = solution.RemoveElement(nums, val);
        Assert.Equal(2, k);
        int[] expectedNums = { 2, 2 };
        Array.Sort(nums, 0, k);
        for (int i = 0; i < k; i++)
        {
            Assert.Equal(expectedNums[i], nums[i]);
        }
    }

    [Fact]
    public void Test_RemoveElement_Example2()
    {
        var solution = new S27RemoveElement();
        int[] nums = { 0, 1, 2, 2, 3, 0, 4, 2 };
        int val = 2;
        int k = solution.RemoveElement(nums, val);
        Assert.Equal(5, k);
        int[] expectedNums = { 0, 0, 1, 3, 4 };
        Array.Sort(nums, 0, k);
        for (int i = 0; i < k; i++)
        {
            Assert.Equal(expectedNums[i], nums[i]);
        }
    }
}
