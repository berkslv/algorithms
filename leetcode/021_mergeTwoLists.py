# https://leetcode.com/problems/merge-two-sorted-lists/submissions/867079320/
from typing import Optional
from _structures import ListNode


class Solution:
    def mergeTwoLists(self, list1: Optional[ListNode], list2: Optional[ListNode]) -> Optional[ListNode]:
        if list1 == None:
            return list2
        if list2 == None:
            return list1

        mergedHead = ListNode()

        if list1.val < list2.val:
            mergedHead = list1
            mergedHead.next = self.mergeTwoLists(list1.next, list2)
        else:
            mergedHead = list2
            mergedHead.next = self.mergeTwoLists(list1, list2.next)

        return mergedHead


# Test
l1 = ListNode.from_list([1, 2, 4])
l2 = ListNode.from_list([1, 3, 4])
answer = Solution().mergeTwoLists(l1, l2)
print(" l1: ", l1, "\n l2: ", l2, "\n answer: ", answer)
