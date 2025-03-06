namespace Problems.Leetcode;

/// <summary>
/// https://leetcode.com/problems/rotate-list/submissions/1564413925
/// </summary>
public class S61RotateRight 
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
    
    public ListNode RotateRight(ListNode head, int k)
    {
        if(head == null || head.next == null)
        {
            return head;
        }

        var length = 1;
        var lastnode = head;
        
        while(lastnode.next !=null)
        {
            lastnode = lastnode.next;
            length++;
        }
        
        lastnode.next = head;
        var first = head;
        int n = k % length;

        for(int i = 0; i < length - n - 1; i++)
        {
            first = first.next;
        }
        
        head = first.next;
        first.next = null;
        
        return head;
    }
}