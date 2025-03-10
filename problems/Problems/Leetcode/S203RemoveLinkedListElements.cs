namespace Problems.Leetcode;

/// <summary>
/// https://leetcode.com/problems/remove-linked-list-elements/submissions/1569398521
/// </summary>
public class S203RemoveLinkedListElements
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
    
    public ListNode RemoveElements(ListNode head, int val)
    {
        ListNode dummy = new ListNode(0, head);
        var prev = dummy;
        var curr = head;

        while (curr is not null)
        {
            if (curr.val == val)
            {
                prev.next = curr.next;
            }
            else
            {
                prev = curr;
            }

            curr = curr.next;
        }

        return dummy.next;
    }   
}