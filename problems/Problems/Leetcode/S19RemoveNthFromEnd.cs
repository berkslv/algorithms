namespace Problems.Leetcode;

/// <summary>+
/// https://leetcode.com/problems/remove-nth-node-from-end-of-list/
/// </summary>
public class S19RemoveNthFromEnd
{
    public class ListNode 
    {
        public int val;
        public ListNode? next;
        
        public ListNode(int val = 0, ListNode? next = null) 
        {
            this.val = val;
            this.next = next;
        }
    }
    
    public ListNode RemoveNthFromEnd(ListNode head, int n)
    {
        var dummy = new ListNode(0, head);
        var first = dummy;
        var second = dummy;
        
        // Move first pointer n+1 steps ahead
        for (int i = 0; i <= n; i++)
        {
            first = first.next;
        }
        
        // Move both pointers until first reaches the end
        while (first != null)
        {
            first = first.next;
            second = second.next;
        }
        
        // Remove the nth node from the end
        second.next = second.next.next;
        
        return dummy.next;
    }
}