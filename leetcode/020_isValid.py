# https://leetcode.com/problems/valid-parentheses/submissions/866941695/

class Solution:
    def isValid(self, s: str) -> bool:
        if len(s) < 2 or len(s) % 2 != 0:
            return False

        left = "([{"
        right = ")]}"
        stack = []

        for c in s:
            if left.find(c) != -1:
                stack.append(c)
            else:
                if len(stack) == 0 or stack.pop() is not left[right.find(c)]:
                    return False

        return len(stack) == 0


# Test
s = "()"
result = Solution().isValid(s)
print(" s: ", s, "\n result: ", result)
