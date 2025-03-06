using Problems.Leetcode;

namespace Problems.Tests.Leetcode;

public class S61RotateRightTests
{
    private readonly S61RotateRight _solution = new S61RotateRight();

    [Fact]
    public void RotateRight_EmptyList_ReturnsEmptyList()
    {
        // Arrange
        S61RotateRight.ListNode head = null;
        int k = 2;

        // Act
        var result = _solution.RotateRight(head, k);

        // Assert
        Assert.Null(result); // An empty list should return null.
    }

    [Fact]
    public void RotateRight_SingleNode_ReturnsSameList()
    {
        // Arrange
        var head = new S61RotateRight.ListNode(1); // List: [1]
        int k = 1;

        // Act
        var result = _solution.RotateRight(head, k);

        // Assert
        Assert.NotNull(result); // The result should not be null.
        Assert.Equal(1, result.val); // The value of the single node should remain 1.
        Assert.Null(result.next); // There should be no next node.
    }

    [Fact]
    public void RotateRight_TwoNodes_KEquals1_ReturnsReversedList()
    {
        // Arrange
        var head = new S61RotateRight.ListNode(1); // List: [1, 2]
        head.next = new S61RotateRight.ListNode(2);
        int k = 1;

        // Act
        var result = _solution.RotateRight(head, k);

        // Assert
        Assert.NotNull(result); // The result should not be null.
        Assert.Equal(2, result.val); // The first node of the rotated list should be 2.
        Assert.Equal(1, result.next.val); // The second node of the rotated list should be 1.
        Assert.Null(result.next.next); // There should be no third node.
    }

    [Fact]
    public void RotateRight_MultipleNodes_KEquals2_ReturnsRotatedList()
    {
        // Arrange
        var head = new S61RotateRight.ListNode(1); // List: [1, 2, 3, 4, 5]
        head.next = new S61RotateRight.ListNode(2);
        head.next.next = new S61RotateRight.ListNode(3);
        head.next.next.next = new S61RotateRight.ListNode(4);
        head.next.next.next.next = new S61RotateRight.ListNode(5);
        int k = 2;

        // Act
        var result = _solution.RotateRight(head, k);

        // Assert
        Assert.NotNull(result); // The result should not be null.
        Assert.Equal(4, result.val); // The first node of the rotated list should be 4.
        Assert.Equal(5, result.next.val); // The second node of the rotated list should be 5.
        Assert.Equal(1, result.next.next.val); // The third node of the rotated list should be 1.
        Assert.Equal(2, result.next.next.next.val); // The fourth node of the rotated list should be 2.
        Assert.Equal(3, result.next.next.next.next.val); // The fifth node of the rotated list should be 3.
        Assert.Null(result.next.next.next.next.next); // There should be no sixth node.
    }

    [Fact]
    public void RotateRight_ThreeNodes_KEquals4_ReturnsRotatedList()
    {
        // Arrange
        var head = new S61RotateRight.ListNode(0); // List: [0, 1, 2]
        head.next = new S61RotateRight.ListNode(1);
        head.next.next = new S61RotateRight.ListNode(2);
        int k = 4;

        // Act
        var result = _solution.RotateRight(head, k);

        // Assert
        Assert.NotNull(result); // The result should not be null.
        Assert.Equal(2, result.val); // The first node of the rotated list should be 2.
        Assert.Equal(0, result.next.val); // The second node of the rotated list should be 0.
        Assert.Equal(1, result.next.next.val); // The third node of the rotated list should be 1.
        Assert.Null(result.next.next.next); // There should be no fourth node.
    }

    [Fact]
    public void RotateRight_MultipleNodes_KZero_ReturnsOriginalList()
    {
        // Arrange
        var head = new S61RotateRight.ListNode(1); // List: [1, 2, 3]
        head.next = new S61RotateRight.ListNode(2);
        head.next.next = new S61RotateRight.ListNode(3);
        int k = 0;

        // Act
        var result = _solution.RotateRight(head, k);

        // Assert
        Assert.NotNull(result); // The result should not be null.
        Assert.Equal(1, result.val); // The first node of the rotated list should be 1.
        Assert.Equal(2, result.next.val); // The second node of the rotated list should be 2.
        Assert.Equal(3, result.next.next.val); // The third node of the rotated list should be 3.
        Assert.Null(result.next.next.next); // There should be no fourth node.
    }
}