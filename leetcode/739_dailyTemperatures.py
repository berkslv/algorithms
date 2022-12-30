# https://leetcode.com/problems/daily-temperatures/submissions/868152177/
from typing import List


class Solution:
    def dailyTemperatures(self, temperatures: List[int]) -> List[int]:
        result = [0] * len(temperatures)
        stack = [] # pair: [temprature, index]
        for i, val in enumerate(temperatures):
            while stack and stack[-1][0] < val:
                stack_val, stack_i = stack.pop()
                result[stack_i] = i - stack_i
            stack.append([val, i])
        return result


temperatures = [73, 74, 75, 71, 69, 72, 76, 73]
result = Solution().dailyTemperatures(temperatures)
print(" temperatures: ", temperatures, "\n result: ", result)
