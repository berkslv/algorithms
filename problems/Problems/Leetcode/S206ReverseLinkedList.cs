namespace Problems.Leetcode;

/// <summary>
/// https://leetcode.com/problems/reverse-linked-list/
/// </summary>
public class S206ReverseLinkedList
{
    public class ListNode {
        public int val;
        public ListNode? next;
        
        public ListNode(int val = 0, ListNode next = null) {
            this.val = val;
            this.next = next;
        }
    }
 
    public ListNode ReverseList(ListNode head) 
    {
        ListNode prev = null;
        var curr = head;
        
        while (curr is not null)
        {
            var holder = curr.next;
            curr.next = prev;
            prev = curr;
            curr = holder;
        }

        return prev;
    }
}