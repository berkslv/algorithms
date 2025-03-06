using Problems.Leetcode;

namespace Problems.Tests.Leetcode;

public class S83RemoveDuplicatesTests
{
    private readonly S83RemoveDuplicates _solution = new S83RemoveDuplicates();

    [Fact]
    public void DeleteDuplicates_EmptyList_ReturnsEmptyList()
    {
        // Arrange
        S83RemoveDuplicates.ListNode head = null;

        // Act
        var result = _solution.DeleteDuplicates(head);

        // Assert
        Assert.Null(result); // An empty list should return null.
    }

    [Fact]
    public void DeleteDuplicates_SingleNode_ReturnsSameList()
    {
        // Arrange
        var head = new S83RemoveDuplicates.ListNode(1); // List: [1]

        // Act
        var result = _solution.DeleteDuplicates(head);

        // Assert
        Assert.NotNull(result); // The result should not be null.
        Assert.Equal(1, result.val); // The value of the single node should remain 1.
        Assert.Null(result.next); // There should be no next node.
    }

    [Fact]
    public void DeleteDuplicates_TwoNodes_NoDuplicates_ReturnsSameList()
    {
        // Arrange
        var head = new S83RemoveDuplicates.ListNode(1); // List: [1, 2]
        head.next = new S83RemoveDuplicates.ListNode(2);

        // Act
        var result = _solution.DeleteDuplicates(head);

        // Assert
        Assert.NotNull(result); // The result should not be null.
        Assert.Equal(1, result.val); // The first node should be 1.
        Assert.Equal(2, result.next.val); // The second node should be 2.
        Assert.Null(result.next.next); // There should be no third node.
    }

    [Fact]
    public void DeleteDuplicates_TwoNodes_WithDuplicates_ReturnsListWithoutDuplicates()
    {
        // Arrange
        var head = new S83RemoveDuplicates.ListNode(1); // List: [1, 1]
        head.next = new S83RemoveDuplicates.ListNode(1);

        // Act
        var result = _solution.DeleteDuplicates(head);

        // Assert
        Assert.NotNull(result); // The result should not be null.
        Assert.Equal(1, result.val); // The first node should be 1.
        Assert.Null(result.next); // There should be no second node.
    }

    [Fact]
    public void DeleteDuplicates_MultipleNodes_WithDuplicates_ReturnsListWithoutDuplicates()
    {
        // Arrange
        var head = new S83RemoveDuplicates.ListNode(1); // List: [1, 1, 2, 3, 3]
        head.next = new S83RemoveDuplicates.ListNode(1);
        head.next.next = new S83RemoveDuplicates.ListNode(2);
        head.next.next.next = new S83RemoveDuplicates.ListNode(3);
        head.next.next.next.next = new S83RemoveDuplicates.ListNode(3);

        // Act
        var result = _solution.DeleteDuplicates(head);

        // Assert
        Assert.NotNull(result); // The result should not be null.
        Assert.Equal(1, result.val); // The first node should be 1.
        Assert.Equal(2, result.next.val); // The second node should be 2.
        Assert.Equal(3, result.next.next.val); // The third node should be 3.
        Assert.Null(result.next.next.next); // There should be no fourth node.
    }

    [Fact]
    public void DeleteDuplicates_AllNodesDuplicates_ReturnsSingleNode()
    {
        // Arrange
        var head = new S83RemoveDuplicates.ListNode(2); // List: [2, 2, 2]
        head.next = new S83RemoveDuplicates.ListNode(2);
        head.next.next = new S83RemoveDuplicates.ListNode(2);

        // Act
        var result = _solution.DeleteDuplicates(head);

        // Assert
        Assert.NotNull(result); // The result should not be null.
        Assert.Equal(2, result.val); // The first node should be 2.
        Assert.Null(result.next); // There should be no second node.
    }

    [Fact]
    public void DeleteDuplicates_LongList_WithDuplicates_ReturnsListWithoutDuplicates()
    {
        // Arrange
        var head = new S83RemoveDuplicates.ListNode(1); // List: [1, 1, 2, 2, 3, 4, 4, 5, 5, 5]
        head.next = new S83RemoveDuplicates.ListNode(1);
        head.next.next = new S83RemoveDuplicates.ListNode(2);
        head.next.next.next = new S83RemoveDuplicates.ListNode(2);
        head.next.next.next.next = new S83RemoveDuplicates.ListNode(3);
        head.next.next.next.next.next = new S83RemoveDuplicates.ListNode(4);
        head.next.next.next.next.next.next = new S83RemoveDuplicates.ListNode(4);
        head.next.next.next.next.next.next.next = new S83RemoveDuplicates.ListNode(5);
        head.next.next.next.next.next.next.next.next = new S83RemoveDuplicates.ListNode(5);
        head.next.next.next.next.next.next.next.next.next = new S83RemoveDuplicates.ListNode(5);

        // Act
        var result = _solution.DeleteDuplicates(head);

        // Assert
        Assert.NotNull(result); // The result should not be null.
        Assert.Equal(1, result.val); // The first node should be 1.
        Assert.Equal(2, result.next.val); // The second node should be 2.
        Assert.Equal(3, result.next.next.val); // The third node should be 3.
        Assert.Equal(4, result.next.next.next.val); // The fourth node should be 4.
        Assert.Equal(5, result.next.next.next.next.val); // The fifth node should be 5.
        Assert.Null(result.next.next.next.next.next); // There should be no sixth node.
    }
}