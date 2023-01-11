# https://leetcode.com/problems/best-time-to-buy-and-sell-stock/submissions/875996657/
from typing import List


class Solution:
    def maxProfit(self, prices: List[int]) -> int:
        left = 0
        right = 1
        max_profit = 0

        while right < len(prices):
            temp = prices[right] - prices[left]
            if max_profit < temp:
                max_profit = temp

            if prices[left] > prices[right]:
                left = right
                right += 1
            else:
                right += 1

        return max_profit


# Test
# prices = [7, 1, 5, 3, 6, 4]
# prices = [7,6,4,3,1]
# prices = [2, 4, 1]
prices = [2, 1, 4]
result = Solution().maxProfit(prices)
print(" prices: ", prices, "\n result: ", result)
