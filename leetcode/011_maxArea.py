# https://leetcode.com/problems/container-with-most-water/submissions/875638901/
from typing import List



class Solution:
    def maxArea(self, height: List[int]) -> int:
        right = len(height) - 1
        left = 0
        maxarea = 0

        while left < right:
            maxarea = max(maxarea, min(height[left], height[right]) * (right - left))
            if height[left] <= height[right]:
                left += 1
            else:
                right -= 1

        return maxarea


# Test
height = [1, 8, 6, 2, 5, 4, 8, 3, 7]
result = Solution().maxArea(height)
print(" height: ", height, "\n result: ", result)
