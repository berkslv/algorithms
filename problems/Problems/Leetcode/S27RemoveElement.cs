namespace Problems.Leetcode;

/// <summary>+
/// https://leetcode.com/problems/remove-element/
/// </summary>
public class S27RemoveElement
{
    public int RemoveElement(int[] nums, int val)
    {
        var k = 0;
        for (var i = 0; i < nums.Length; i++)
        {
            if (nums[i] != val)
            {
                nums[k] = nums[i];
                k++;
            }
        }

        return k;
    }
}
