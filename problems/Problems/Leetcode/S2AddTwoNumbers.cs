namespace Problems.Leetcode;

/// <summary>+
/// https://leetcode.com/problems/add-two-numbers/
/// </summary>
public class S2AddTwoNumbers
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
    
    public ListNode AddTwoNumbers(ListNode l1, ListNode l2) 
    {
        var dummy = new ListNode(0);
        var current = dummy;
        var carry = 0;
        
        while (l1 != null || l2 != null || carry > 0)
        {
            var sum = carry;
            
            if (l1 != null)
            {
                sum += l1.val;
                l1 = l1.next;
            }
            
            if (l2 != null)
            {
                sum += l2.val;
                l2 = l2.next;
            }
            
            carry = sum / 10;
            current.next = new ListNode(sum % 10);
            current = current.next;
        }
        
        return dummy.next;
    }
}