# https://leetcode.com/problems/binary-tree-level-order-traversal/submissions/867153645/
from typing import Optional, List
from _structures import TreeNode


class Solution:
    def levelOrder(self, root: Optional[TreeNode]) -> List[List[int]]:
        res = []
        q = []
        q.append(root)

        while q:
            level = []
            for _ in range(len(q)):
                node = q.pop(0)
                if node:
                    level.append(node.val)
                    q.append(node.left)
                    q.append(node.right)
            if level:
                res.append(level)
        return res    


# Test
root = TreeNode.from_list([3, 9, 20, None, None, 15, 7])
answer = Solution().levelOrder(root)
root.print()
print("answer: ", answer)
