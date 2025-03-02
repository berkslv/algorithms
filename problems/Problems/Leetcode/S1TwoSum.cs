namespace Problems.Leetcode;

/// <summary>
/// https://leetcode.com/problems/two-sum/submissions/1560196105
/// </summary>
public class S1TwoSum
{
    public int[] TwoSum(int[] nums, int target)
    {
        var set = new Dictionary<int, int>();

        for (int i = 0; i < nums.Length; i++)
        {
            var num = nums[i];
            
            if (set.TryGetValue(num, out var j))
            {
                return [i, j];
            }
            
            set.TryAdd(target - num, i);
        }

        return [];
    }
}