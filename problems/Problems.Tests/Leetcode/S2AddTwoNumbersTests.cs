using Problems.Leetcode;

namespace Problems.Tests.Leetcode;

public class S2AddTwoNumbersTests
{
    private readonly S2AddTwoNumbers _solution = new S2AddTwoNumbers();

    [Fact]
    public void AddTwoNumbers_Example1_ReturnsCorrectSum()
    {
        // Arrange: l1 = [2,4,3], l2 = [5,6,4] -> 342 + 465 = 807 -> [7,0,8]
        var l1 = new S2AddTwoNumbers.ListNode(2);
        l1.next = new S2AddTwoNumbers.ListNode(4);
        l1.next.next = new S2AddTwoNumbers.ListNode(3);

        var l2 = new S2AddTwoNumbers.ListNode(5);
        l2.next = new S2AddTwoNumbers.ListNode(6);
        l2.next.next = new S2AddTwoNumbers.ListNode(4);

        // Act
        var result = _solution.AddTwoNumbers(l1, l2);

        // Assert
        Assert.Equal(7, result.val);
        Assert.Equal(0, result.next.val);
        Assert.Equal(8, result.next.next.val);
        Assert.Null(result.next.next.next);
    }

    [Fact]
    public void AddTwoNumbers_Example2_ReturnsCorrectSum()
    {
        // Arrange: l1 = [0], l2 = [0] -> 0 + 0 = 0 -> [0]
        var l1 = new S2AddTwoNumbers.ListNode(0);
        var l2 = new S2AddTwoNumbers.ListNode(0);

        // Act
        var result = _solution.AddTwoNumbers(l1, l2);

        // Assert
        Assert.Equal(0, result.val);
        Assert.Null(result.next);
    }

    [Fact]
    public void AddTwoNumbers_Example3_ReturnsCorrectSum()
    {
        // Arrange: l1 = [9,9,9,9,9,9,9], l2 = [9,9,9,9] -> 9999999 + 9999 = 10009998 -> [8,9,9,9,0,0,0,1]
        var l1 = new S2AddTwoNumbers.ListNode(9);
        var current = l1;
        for (int i = 0; i < 6; i++)
        {
            current.next = new S2AddTwoNumbers.ListNode(9);
            current = current.next;
        }

        var l2 = new S2AddTwoNumbers.ListNode(9);
        current = l2;
        for (int i = 0; i < 3; i++)
        {
            current.next = new S2AddTwoNumbers.ListNode(9);
            current = current.next;
        }

        // Act
        var result = _solution.AddTwoNumbers(l1, l2);

        // Assert
        Assert.Equal(8, result.val);
        Assert.Equal(9, result.next.val);
        Assert.Equal(9, result.next.next.val);
        Assert.Equal(9, result.next.next.next.val);
        Assert.Equal(0, result.next.next.next.next.val);
        Assert.Equal(0, result.next.next.next.next.next.val);
        Assert.Equal(0, result.next.next.next.next.next.next.val);
        Assert.Equal(1, result.next.next.next.next.next.next.next.val);
        Assert.Null(result.next.next.next.next.next.next.next.next);
    }

    [Fact]
    public void AddTwoNumbers_DifferentLengths_ReturnsCorrectSum()
    {
        // Arrange: l1 = [1], l2 = [9,9] -> 1 + 99 = 100 -> [0,0,1]
        var l1 = new S2AddTwoNumbers.ListNode(1);

        var l2 = new S2AddTwoNumbers.ListNode(9);
        l2.next = new S2AddTwoNumbers.ListNode(9);

        // Act
        var result = _solution.AddTwoNumbers(l1, l2);

        // Assert
        Assert.Equal(0, result.val);
        Assert.Equal(0, result.next.val);
        Assert.Equal(1, result.next.next.val);
        Assert.Null(result.next.next.next);
    }
}