namespace Problems.Leetcode;

/// <summary>+
/// https://leetcode.com/problems/container-with-most-water/
/// </summary>
public class S11ContainerWithMostWater
{
    public int MaxArea(int[] height)
    {
        var left = 0;
        var right = height.Length - 1;
        var maxArea = 0;
        
        while (left < right)
        {
            var currentArea = Math.Min(height[left], height[right]) * (right - left);
            maxArea = Math.Max(maxArea, currentArea);
            
            // Move the pointer with smaller height
            if (height[left] < height[right])
            {
                left++;
            }
            else
            {
                right--;
            }
        }
        
        return maxArea;
    }
}