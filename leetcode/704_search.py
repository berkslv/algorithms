# https://leetcode.com/problems/binary-search/submissions/867531679/
from typing import List

class Solution:
    def search(self, nums: List[int], target: int) -> int:
        l = 0
        r = len(nums) - 1
        while l <= r:
            m = (r + l) // 2
            if nums[m] == target:
                return m
            elif nums[m] < target:
                l = m + 1
            else:
                r = m - 1
        return -1

# Test
nums = [-1, 0, 3, 5, 9, 12]
target = 12
result = Solution().search(nums, target)
print(" nums: ", nums, "\n target: ", target, "\n result: ", result)
