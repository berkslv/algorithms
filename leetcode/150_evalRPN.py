# https://leetcode.com/problems/evaluate-reverse-polish-notation/submissions/867606089/
from typing import List
from math import trunc

class Solution:
    def evalRPN(self, tokens: List[str]) -> int:
        stack = []
        for i in tokens:
            if i not in {"+", "-", "*", "/"}:
                stack.append(int(i))
            else: #operand
                b, a = stack.pop(), stack.pop()
                if i == "+": 
                    stack.append(a + b)
                elif i == "-": 
                    stack.append(a - b)
                elif i == "*": 
                    stack.append(a*b)
                else: 
                    stack.append(trunc(a/b))
        return stack[0]

# Test
tokens = ["2","1","+","3","*"]
answer = Solution().evalRPN(tokens)
print(" tokens: ", tokens, "\n answer: ", answer)