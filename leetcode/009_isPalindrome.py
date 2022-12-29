# https://leetcode.com/problems/palindrome-number/submissions/865403547/

class Solution:
    def isPalindrome(self, x: int) -> bool:
        if x < 0:
            return False

        items = list(str(x))
        items_len = len(items)

        if items_len == 0:
            return True

        for index, _ in enumerate(items):
            if items[index] != items[len(items)-index-1]:
                return False

        return True


# Test
x = 121
result = Solution().isPalindrome(x)
print(" x: ", x, "\n result: ", result)
