# https://leetcode.com/problems/two-sum/submissions/867507954/
from typing import List


class Solution:
    def twoSum(self, nums: List[int], target: int) -> List[int]:
        dict = {}
        for i, v in enumerate(nums):
            m = target - v
            if m in dict:
                return [dict[m],i]
            else:
                dict[v] = i


# Test
nums = [2, 7, 11, 15]
target = 9
result = Solution().twoSum(nums, target)
print(" nums: ", nums, "\n target: ", target, "\n result: ", result)
