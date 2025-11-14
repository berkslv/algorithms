namespace Problems.Leetcode;

/// <summary>+
/// https://leetcode.com/problems/two-sum-ii-input-array-is-sorted/
/// </summary>
public class S167TwoSumII
{
    public int[] TwoSum(int[] numbers, int target)
    {
        var left = 0;
        var right = numbers.Length - 1;

        while (left < right)
        {
            var sum = numbers[left] + numbers[right];

            if (sum == target)
            {
                return new[] { left + 1, right + 1 };
            }

            if (sum < target)
            {
                left++;
            }
            else
            {
                right--;
            }
        }

        return Array.Empty<int>();
    }
}