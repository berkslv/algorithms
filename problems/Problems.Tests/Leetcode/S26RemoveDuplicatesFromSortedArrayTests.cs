using Problems.Leetcode;
using Xunit;

namespace Problems.Tests.Leetcode;

public class S26RemoveDuplicatesFromSortedArrayTests
{
    [Fact]
    public void Test_RemoveDuplicates_Example1()
    {
        var solution = new S26RemoveDuplicatesFromSortedArray();
        int[] nums = { 1, 1, 2 };
        int k = solution.RemoveDuplicates(nums);
        Assert.Equal(2, k);
        int[] expectedNums = { 1, 2 };
        for (int i = 0; i < k; i++)
        {
            Assert.Equal(expectedNums[i], nums[i]);
        }
    }

    [Fact]
    public void Test_RemoveDuplicates_Example2()
    {
        var solution = new S26RemoveDuplicatesFromSortedArray();
        int[] nums = { 0, 0, 1, 1, 1, 2, 2, 3, 3, 4 };
        int k = solution.RemoveDuplicates(nums);
        Assert.Equal(5, k);
        int[] expectedNums = { 0, 1, 2, 3, 4 };
        for (int i = 0; i < k; i++)
        {
            Assert.Equal(expectedNums[i], nums[i]);
        }
    }
}
