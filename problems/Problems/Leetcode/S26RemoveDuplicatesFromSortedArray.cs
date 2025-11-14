namespace Problems.Leetcode;

/// <summary>+
/// https://leetcode.com/problems/remove-duplicates-from-sorted-array/
/// </summary>
public class S26RemoveDuplicatesFromSortedArray
{
    public int RemoveDuplicates(int[] nums)
    {
        if (nums.Length == 0)
        {
            return 0;
        }

        var k = 1;
        for (var i = 1; i < nums.Length; i++)
        {
            if (nums[i] != nums[i - 1])
            {
                nums[k] = nums[i];
                k++;
            }
        }

        return k;
    }
}
