# https://leetcode.com/problems/reverse-linked-list/submissions/867521257/
from typing import Optional
from _structures import ListNode


class Solution:
    def reverseList(self, head: Optional[ListNode]) -> Optional[ListNode]:
        prev = None
        curr = head
        while curr:
            next = curr.next
            curr.next = prev
            prev = curr
            curr = next
        return prev


# Test
head = ListNode.from_list([1, 2, 3, 4, 5])
answer = Solution().reverseList(head)
print(" head: ", head, "\n answer: ", answer)
