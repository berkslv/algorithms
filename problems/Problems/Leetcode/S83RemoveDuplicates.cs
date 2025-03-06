namespace Problems.Leetcode;

/// <summary>
/// https://leetcode.com/problems/remove-duplicates-from-sorted-list/submissions/1564464342
/// </summary>
public class S83RemoveDuplicates
{
    public class ListNode 
    {
        public int val;
        public ListNode? next;
        
        public ListNode(int val = 0, ListNode next = null) 
        {
            this.val = val;
            this.next = next;
        }
    }
    
    public ListNode DeleteDuplicates(ListNode head)
    {
        ListNode curr = head;
        
        while (curr is not null)
        {
            while (curr.next is not null && curr.val == curr.next.val)
            {
                curr.next = curr.next.next;
            }

            curr = curr.next;
        }

        return head;
    }
}