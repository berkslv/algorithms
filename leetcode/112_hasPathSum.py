# https://leetcode.com/problems/path-sum/submissions/875616715/
from typing import Optional
from _structures import TreeNode


class Solution:
    def hasPathSum(self, root: Optional[TreeNode], targetSum: int) -> bool:
        if not root:
            return False
        if not root.left and not root.right and root.val == targetSum:
            return True
        if root.left and root.left:
            return self.hasPathSum(root.left, targetSum - root.val) or self.hasPathSum(root.right, targetSum - root.val)

# Test
root = TreeNode.from_list([5, 4, 8, 11, None, 13, 4, 7, 2, None, None, None, 1])
targetSum = 22
result = Solution().hasPathSum(root, targetSum)
root.print()
print("result: ", result)
