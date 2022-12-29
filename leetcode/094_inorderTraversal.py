# https://leetcode.com/problems/binary-tree-inorder-traversal/submissions/867446669/
from typing import Optional, List
from _structures import TreeNode

# Recursive approach
class Solution:
    def inorderTraversal(self, root: Optional[TreeNode]) -> List[int]:
        result = []
        self.inorder(root, result)
        return result

    def inorder(self, root: Optional[TreeNode], result: List[int]):
        if root is not None:
            self.inorder(root.left, result)
            result.append(root.val)
            self.inorder(root.right, result)



# Test
root = TreeNode.from_list([1,None,2,3])
answer = Solution().inorderTraversal(root)
root.print()
print("answer: ", answer)
