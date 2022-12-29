# https://leetcode.com/problems/symmetric-tree/submissions/867121298/
from typing import Optional
from _structures import TreeNode


class Solution:
    def isSymmetric(self, root: Optional[TreeNode]) -> bool:
        if root == None:
            return True
        return self.isSymmetric2(root.left, root.right)

    def isSymmetric2(self, left: Optional[TreeNode], right: Optional[TreeNode]) -> bool:
        if left is None or right is None:
            return left == right
        if left.val != right.val:
            return False
        return self.isSymmetric2(left.left, right.right) and self.isSymmetric2(left.right, right.left)


# Test
root = TreeNode(1, TreeNode(2, TreeNode(3), TreeNode(4)),
                TreeNode(2, TreeNode(4), TreeNode(3)))
answer = Solution().isSymmetric(root)
root.print()
print("answer: ", answer)
