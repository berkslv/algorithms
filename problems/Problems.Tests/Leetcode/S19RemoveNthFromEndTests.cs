using Problems.Leetcode;

namespace Problems.Tests.Leetcode;

public class S19RemoveNthFromEndTests
{
    private readonly S19RemoveNthFromEnd _solution = new S19RemoveNthFromEnd();

    [Fact]
    public void RemoveNthFromEnd_RemoveFromMiddle_ReturnsCorrectList()
    {
        // Arrange: [1,2,3,4,5], n = 2 -> [1,2,3,5]
        var head = new S19RemoveNthFromEnd.ListNode(1);
        head.next = new S19RemoveNthFromEnd.ListNode(2);
        head.next.next = new S19RemoveNthFromEnd.ListNode(3);
        head.next.next.next = new S19RemoveNthFromEnd.ListNode(4);
        head.next.next.next.next = new S19RemoveNthFromEnd.ListNode(5);

        // Act
        var result = _solution.RemoveNthFromEnd(head, 2);

        // Assert
        Assert.Equal(1, result.val);
        Assert.Equal(2, result.next.val);
        Assert.Equal(3, result.next.next.val);
        Assert.Equal(5, result.next.next.next.val);
        Assert.Null(result.next.next.next.next);
    }

    [Fact]
    public void RemoveNthFromEnd_RemoveSingleNode_ReturnsNull()
    {
        // Arrange: [1], n = 1 -> []
        var head = new S19RemoveNthFromEnd.ListNode(1);

        // Act
        var result = _solution.RemoveNthFromEnd(head, 1);

        // Assert
        Assert.Null(result);
    }

    [Fact]
    public void RemoveNthFromEnd_RemoveLastNode_ReturnsCorrectList()
    {
        // Arrange: [1,2], n = 1 -> [1]
        var head = new S19RemoveNthFromEnd.ListNode(1);
        head.next = new S19RemoveNthFromEnd.ListNode(2);

        // Act
        var result = _solution.RemoveNthFromEnd(head, 1);

        // Assert
        Assert.Equal(1, result.val);
        Assert.Null(result.next);
    }

    [Fact]
    public void RemoveNthFromEnd_RemoveFirstNode_ReturnsCorrectList()
    {
        // Arrange: [1,2], n = 2 -> [2]
        var head = new S19RemoveNthFromEnd.ListNode(1);
        head.next = new S19RemoveNthFromEnd.ListNode(2);

        // Act
        var result = _solution.RemoveNthFromEnd(head, 2);

        // Assert
        Assert.Equal(2, result.val);
        Assert.Null(result.next);
    }

    [Fact]
    public void RemoveNthFromEnd_RemoveFromLargerList_ReturnsCorrectList()
    {
        // Arrange: [1,2,3,4,5,6], n = 3 -> [1,2,3,5,6]
        var head = new S19RemoveNthFromEnd.ListNode(1);
        head.next = new S19RemoveNthFromEnd.ListNode(2);
        head.next.next = new S19RemoveNthFromEnd.ListNode(3);
        head.next.next.next = new S19RemoveNthFromEnd.ListNode(4);
        head.next.next.next.next = new S19RemoveNthFromEnd.ListNode(5);
        head.next.next.next.next.next = new S19RemoveNthFromEnd.ListNode(6);

        // Act
        var result = _solution.RemoveNthFromEnd(head, 3);

        // Assert
        Assert.Equal(1, result.val);
        Assert.Equal(2, result.next.val);
        Assert.Equal(3, result.next.next.val);
        Assert.Equal(5, result.next.next.next.val);
        Assert.Equal(6, result.next.next.next.next.val);
        Assert.Null(result.next.next.next.next.next);
    }

    [Fact]
    public void RemoveNthFromEnd_RemoveHeadFromThreeNodes_ReturnsCorrectList()
    {
        // Arrange: [1,2,3], n = 3 -> [2,3]
        var head = new S19RemoveNthFromEnd.ListNode(1);
        head.next = new S19RemoveNthFromEnd.ListNode(2);
        head.next.next = new S19RemoveNthFromEnd.ListNode(3);

        // Act
        var result = _solution.RemoveNthFromEnd(head, 3);

        // Assert
        Assert.Equal(2, result.val);
        Assert.Equal(3, result.next.val);
        Assert.Null(result.next.next);
    }
}