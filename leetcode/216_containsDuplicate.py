# https://leetcode.com/problems/contains-duplicate/submissions/867564979/
from typing import List


class Solution:
    def containsDuplicate(self, nums: List[int]) -> bool:
        dict = {}
        for i in nums:
            if dict.get(i) is not None:
                return True
            dict[i] = 0
        return False

# Test
nums = [1,2,3,1]
result = Solution().containsDuplicate(nums)
print(" nums: ", nums, "\n result: ", result)