namespace Problems.Leetcode;

/// <summary>+
/// https://leetcode.com/problems/reorder-list/
/// </summary>
public class S143ReorderList
{
    public void ReorderList(ListNode head)
    {
        if (head?.next == null)
        {
            return;
        }

        // Find the middle of the list
        var slow = head;
        var fast = head;
        while (fast?.next != null)
        {
            slow = slow.next;
            fast = fast.next.next;
        }

        // Reverse the second half of the list
        var prev = default(ListNode);
        var curr = slow;
        while (curr != null)
        {
            var nextTemp = curr.next;
            curr.next = prev;
            prev = curr;
            curr = nextTemp;
        }

        // Merge the two halves
        var first = head;
        var second = prev;
        while (second.next != null)
        {
            var tmp1 = first.next;
            first.next = second;
            var tmp2 = second.next;
            second.next = tmp1;
            first = tmp1;
            second = tmp2;
        }
    }
}
