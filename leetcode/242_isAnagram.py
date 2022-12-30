# https://leetcode.com/problems/valid-anagram/submissions/867572157/

class Solution:
    def isAnagram(self, s: str, t: str) -> bool:
        return sorted(s) == sorted(t)

# Test
s = "rat"
t = "car"
result = Solution().isAnagram(s, t)
print(" s: ", s, "\n t: ", t, "\n result: ", result)
