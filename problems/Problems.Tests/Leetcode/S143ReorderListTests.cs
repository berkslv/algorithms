using Problems.Leetcode;
using Xunit;

namespace Problems.Tests.Leetcode;

public class S143ReorderListTests
{
    [Fact]
    public void Test_ReorderList_Example1()
    {
        var solution = new S143ReorderList();
        var head = new ListNode(1, new ListNode(2, new ListNode(3, new ListNode(4))));
        solution.ReorderList(head);
        Assert.Equal(1, head.val);
        Assert.Equal(4, head.next.val);
        Assert.Equal(2, head.next.next.val);
        Assert.Equal(3, head.next.next.next.val);
        Assert.Null(head.next.next.next.next);
    }

    [Fact]
    public void Test_ReorderList_Example2()
    {
        var solution = new S143ReorderList();
        var head = new ListNode(1, new ListNode(2, new ListNode(3, new ListNode(4, new ListNode(5)))));
        solution.ReorderList(head);
        Assert.Equal(1, head.val);
        Assert.Equal(5, head.next.val);
        Assert.Equal(2, head.next.next.val);
        Assert.Equal(4, head.next.next.next.val);
        Assert.Equal(3, head.next.next.next.next.val);
        Assert.Null(head.next.next.next.next.next);
    }
}
