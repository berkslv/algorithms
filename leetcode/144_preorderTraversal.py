# https://leetcode.com/problems/binary-tree-preorder-traversal/submissions/867450451/
from typing import Optional, List
from _structures import TreeNode


class Solution:
    def preorderTraversal(self, root: Optional[TreeNode]) -> List[int]:
        result = []
        self.preorder(root, result)
        return result

    def preorder(self, root: Optional[TreeNode], result: List[int]):
        if root is not None:
            result.append(root.val)
            self.preorder(root.left, result)
            self.preorder(root.right, result)


# Test
root = TreeNode.from_list([1, None, 2, 3])
answer = Solution().preorderTraversal(root)
root.print()
print("answer: ", answer)
