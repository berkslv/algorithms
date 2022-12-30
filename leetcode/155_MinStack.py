# https://leetcode.com/problems/min-stack/submissions/867600956/

class MinStack:
    def __init__(self):
        self.arr = []
        self.min = []

    def push(self, x):
        self.arr.append(x)
        self.min.append(x if not self.min else min(x, self.min[-1]))

    def pop(self):
        self.arr.pop()
        self.min.pop()

    def top(self):
        return self.arr[-1]

    def getMin(self):
        return self.min[-1]
