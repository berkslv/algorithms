# https://leetcode.com/problems/remove-nth-node-from-end-of-list/submissions/867094994/
from typing import Optional
from _structures import ListNode


class Solution:
    def removeNthFromEnd(self, head: Optional[ListNode], n: int) -> Optional[ListNode]:
        fast = slow = head
        for _ in range(n):
            fast = fast.next
        if not fast:
            return head.next
        while fast.next:
            fast = fast.next
            slow = slow.next
        slow.next = slow.next.next
        return head


# Test
l1 = ListNode.from_list([1, 2, 3, 4, 5])
n = 2
result = Solution().removeNthFromEnd(l1, n)
print(" l1: ", l1, "\n n: ", n, "\n result: ", result)
