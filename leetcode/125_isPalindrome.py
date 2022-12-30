# https://leetcode.com/problems/valid-palindrome/submissions/867512251/
import re

class Solution:
    def isPalindrome(self, s: str) -> bool:
        s = s.lower().replace(" ","")
        s = re.sub(r'[^a-zA-Z0-9]+', '', s)

        if len(s) <= 0:
            return True

        for index, _ in enumerate(s):
            if s[index] != s[len(s)-index-1]:
                return False

        return True


# Test
s = "A man, a plan, a canal: Panama"
s = "race a car"
s = " "
s = "ab_a"
result = Solution().isPalindrome(s)
print(" s: ", s, "\n result: ", result)
