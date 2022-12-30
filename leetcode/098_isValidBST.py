# https://leetcode.com/problems/validate-binary-search-tree/submissions/867472498/
from typing import Optional, List
from _structures import TreeNode
import sys


class Solution:
    def isValidBST(self, root: TreeNode) -> bool:
        INF = sys.maxsize
        return self.helper(root, -INF, INF)

    def helper(self, root, lower, higher):
        if not root:
            return True
        
        if lower < root.val < higher:
            return self.helper(root.left, lower, root.val) and self.helper(root.right, root.val, higher)
        
        return False

# Test
print(float('inf'))
root = TreeNode.from_list([5, 1, 4, None, None, 3, 6])
root = TreeNode.from_list([2, 1, 3])
result = Solution().isValidBST(root)
root.print()
print("result: ", result)
