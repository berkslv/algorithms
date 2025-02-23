namespace Problems;

/// <summary>
/// https://leetcode.com/problems/contains-duplicate/description/
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