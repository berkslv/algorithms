using Problems.Leetcode;

namespace Problems.Tests;

public class S206ReverseLinkedListTests
{
    private readonly S206ReverseLinkedList _solution = new S206ReverseLinkedList();

    [Fact]
    public void ReverseList_EmptyList_ReturnsEmptyList()
    {
        // Arrange
        S206ReverseLinkedList.ListNode head = null;

        // Act
        var result = _solution.ReverseList(head);

        // Assert
        Assert.Null(result); // An empty list should return null.
    }

    [Fact]
    public void ReverseList_SingleNode_ReturnsSameList()
    {
        // Arrange
        var head = new S206ReverseLinkedList.ListNode(1); // List: [1]

        // Act
        var result = _solution.ReverseList(head);

        // Assert
        Assert.NotNull(result); // The result should not be null.
        Assert.Equal(1, result.val); // The value of the single node should remain 1.
        Assert.Null(result.next); // There should be no next node.
    }

    [Fact]
    public void ReverseList_TwoNodes_ReturnsReversedList()
    {
        // Arrange
        var head = new S206ReverseLinkedList.ListNode(1); // List: [1, 2]
        head.next = new S206ReverseLinkedList.ListNode(2);

        // Act
        var result = _solution.ReverseList(head);

        // Assert
        Assert.NotNull(result); // The result should not be null.
        Assert.Equal(2, result.val); // The first node of the reversed list should be 2.
        Assert.Equal(1, result.next.val); // The second node of the reversed list should be 1.
        Assert.Null(result.next.next); // There should be no third node.
    }

    [Fact]
    public void ReverseList_MultipleNodes_ReturnsReversedList()
    {
        // Arrange
        var head = new S206ReverseLinkedList.ListNode(1); // List: [1, 2, 3, 4, 5]
        head.next = new S206ReverseLinkedList.ListNode(2);
        head.next.next = new S206ReverseLinkedList.ListNode(3);
        head.next.next.next = new S206ReverseLinkedList.ListNode(4);
        head.next.next.next.next = new S206ReverseLinkedList.ListNode(5);

        // Act
        var result = _solution.ReverseList(head);

        // Assert
        Assert.NotNull(result); // The result should not be null.
        Assert.Equal(5, result.val); // The first node of the reversed list should be 5.
        Assert.Equal(4, result.next.val); // The second node of the reversed list should be 4.
        Assert.Equal(3, result.next.next.val); // The third node of the reversed list should be 3.
        Assert.Equal(2, result.next.next.next.val); // The fourth node of the reversed list should be 2.
        Assert.Equal(1, result.next.next.next.next.val); // The fifth node of the reversed list should be 1.
        Assert.Null(result.next.next.next.next.next); // There should be no sixth node.
    }

    [Fact]
    public void ReverseList_ThreeNodes_ReturnsReversedList()
    {
        // Arrange
        var head = new S206ReverseLinkedList.ListNode(1); // List: [1, 2, 3]
        head.next = new S206ReverseLinkedList.ListNode(2);
        head.next.next = new S206ReverseLinkedList.ListNode(3);

        // Act
        var result = _solution.ReverseList(head);

        // Assert
        Assert.NotNull(result); // The result should not be null.
        Assert.Equal(3, result.val); // The first node of the reversed list should be 3.
        Assert.Equal(2, result.next.val); // The second node of the reversed list should be 2.
        Assert.Equal(1, result.next.next.val); // The third node of the reversed list should be 1.
        Assert.Null(result.next.next.next); // There should be no fourth node.
    }
}