# https://leetcode.com/problems/top-k-frequent-elements/submissions/867546129/
from typing import List


class Solution:
    def topKFrequent(self, nums: List[int], k: int) -> List[int]:
        dic = {}
        for i in nums:
            if i in dic:
                dic[i] = dic[i] +1
            else:
                dic[i] = 1
        srt = sorted(dic.items(), key=lambda x:x[1], reverse=True)
        srt = list(zip(*srt))[0]
        result = []
        for i in range(k):
            result.append(srt[i])
        return result


# Test
nums = [1,1,1,2,2,3]
k = 2
result = Solution().topKFrequent(nums, k)
print(" nums: ", nums, "\n k: ", k, "\n result: ", result)
