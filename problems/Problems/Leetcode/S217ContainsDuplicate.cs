namespace Problems.Leetcode;

/// <summary>
/// https://leetcode.com/problems/contains-duplicate/submissions/1552732148
/// </summary>
public class S217ContainsDuplicate
{
    public bool ContainsDuplicate(int[] nums)
    {
        var dict = new Dictionary<int, bool>();

        foreach (var num in nums)
        {
            if (!dict.TryAdd(num, true))
            {
                return true;
            }
        }

        return false;
    }
}