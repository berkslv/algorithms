namespace Problems.Leetcode;

/// <summary>+
/// https://leetcode.com/problems/merge-two-sorted-lists/
/// </summary>
public class S21MergeTwoSortedLists
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
    
    public ListNode MergeTwoLists(ListNode list1, ListNode list2) 
    {
        var dummy = new ListNode(0);
        var current = dummy;
        
        while (list1 != null && list2 != null)
        {
            if (list1.val <= list2.val)
            {
                current.next = list1;
                list1 = list1.next;
            }
            else
            {
                current.next = list2;
                list2 = list2.next;
            }
            current = current.next;
        }
        
        // Append remaining nodes
        current.next = list1 ?? list2;
        
        return dummy.next;
    }
}