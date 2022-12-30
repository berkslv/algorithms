# https://leetcode.com/problems/two-sum-ii-input-array-is-sorted/submissions/868161853/
from typing import List


class Solution:
    def twoSum(self, numbers: List[int], target: int) -> List[int]:
        l, r = 0, len(numbers)-1
        while l < r:
            s = numbers[l] + numbers[r]
            if s == target:
                return [l+1, r+1]
            elif s < target:
                l += 1
            else:
                r -= 1


numbers = [2, 7, 11, 15]
target = 26
result = Solution().twoSum(numbers, target)
print(" numbers: ", numbers, "\n target: ", target, "\n result: ", result)
