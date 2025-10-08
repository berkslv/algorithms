using Problems.Leetcode;

namespace Problems.Tests.Leetcode;

public class S21MergeTwoSortedListsTests
{
    private readonly S21MergeTwoSortedLists _solution = new S21MergeTwoSortedLists();

    [Fact]
    public void MergeTwoLists_BothNonEmpty_ReturnsCorrectMergedList()
    {
        // Arrange: list1 = [1,2,4], list2 = [1,3,4] -> [1,1,2,3,4,4]
        var list1 = new S21MergeTwoSortedLists.ListNode(1);
        list1.next = new S21MergeTwoSortedLists.ListNode(2);
        list1.next.next = new S21MergeTwoSortedLists.ListNode(4);

        var list2 = new S21MergeTwoSortedLists.ListNode(1);
        list2.next = new S21MergeTwoSortedLists.ListNode(3);
        list2.next.next = new S21MergeTwoSortedLists.ListNode(4);

        // Act
        var result = _solution.MergeTwoLists(list1, list2);

        // Assert
        Assert.Equal(1, result.val);
        Assert.Equal(1, result.next.val);
        Assert.Equal(2, result.next.next.val);
        Assert.Equal(3, result.next.next.next.val);
        Assert.Equal(4, result.next.next.next.next.val);
        Assert.Equal(4, result.next.next.next.next.next.val);
        Assert.Null(result.next.next.next.next.next.next);
    }

    [Fact]
    public void MergeTwoLists_BothEmpty_ReturnsNull()
    {
        // Arrange: list1 = [], list2 = [] -> []
        S21MergeTwoSortedLists.ListNode list1 = null;
        S21MergeTwoSortedLists.ListNode list2 = null;

        // Act
        var result = _solution.MergeTwoLists(list1, list2);

        // Assert
        Assert.Null(result);
    }

    [Fact]
    public void MergeTwoLists_OneEmptyOneNonEmpty_ReturnsNonEmptyList()
    {
        // Arrange: list1 = [], list2 = [0] -> [0]
        S21MergeTwoSortedLists.ListNode list1 = null;
        var list2 = new S21MergeTwoSortedLists.ListNode(0);

        // Act
        var result = _solution.MergeTwoLists(list1, list2);

        // Assert
        Assert.Equal(0, result.val);
        Assert.Null(result.next);
    }

    [Fact]
    public void MergeTwoLists_FirstListLonger_ReturnsCorrectMergedList()
    {
        // Arrange: list1 = [1,2,3,4,5], list2 = [2,3] -> [1,2,2,3,3,4,5]
        var list1 = new S21MergeTwoSortedLists.ListNode(1);
        list1.next = new S21MergeTwoSortedLists.ListNode(2);
        list1.next.next = new S21MergeTwoSortedLists.ListNode(3);
        list1.next.next.next = new S21MergeTwoSortedLists.ListNode(4);
        list1.next.next.next.next = new S21MergeTwoSortedLists.ListNode(5);

        var list2 = new S21MergeTwoSortedLists.ListNode(2);
        list2.next = new S21MergeTwoSortedLists.ListNode(3);

        // Act
        var result = _solution.MergeTwoLists(list1, list2);

        // Assert
        Assert.Equal(1, result.val);
        Assert.Equal(2, result.next.val);
        Assert.Equal(2, result.next.next.val);
        Assert.Equal(3, result.next.next.next.val);
        Assert.Equal(3, result.next.next.next.next.val);
        Assert.Equal(4, result.next.next.next.next.next.val);
        Assert.Equal(5, result.next.next.next.next.next.next.val);
    }

    [Fact]
    public void MergeTwoLists_SecondListLonger_ReturnsCorrectMergedList()
    {
        // Arrange: list1 = [1,3], list2 = [2,4,5,6] -> [1,2,3,4,5,6]
        var list1 = new S21MergeTwoSortedLists.ListNode(1);
        list1.next = new S21MergeTwoSortedLists.ListNode(3);

        var list2 = new S21MergeTwoSortedLists.ListNode(2);
        list2.next = new S21MergeTwoSortedLists.ListNode(4);
        list2.next.next = new S21MergeTwoSortedLists.ListNode(5);
        list2.next.next.next = new S21MergeTwoSortedLists.ListNode(6);

        // Act
        var result = _solution.MergeTwoLists(list1, list2);

        // Assert
        Assert.Equal(1, result.val);
        Assert.Equal(2, result.next.val);
        Assert.Equal(3, result.next.next.val);
        Assert.Equal(4, result.next.next.next.val);
        Assert.Equal(5, result.next.next.next.next.val);
        Assert.Equal(6, result.next.next.next.next.next.val);
    }

    [Fact]
    public void MergeTwoLists_SingleNodes_ReturnsCorrectMergedList()
    {
        // Arrange: list1 = [2], list2 = [1] -> [1,2]
        var list1 = new S21MergeTwoSortedLists.ListNode(2);
        var list2 = new S21MergeTwoSortedLists.ListNode(1);

        // Act
        var result = _solution.MergeTwoLists(list1, list2);

        // Assert
        Assert.Equal(1, result.val);
        Assert.Equal(2, result.next.val);
        Assert.Null(result.next.next);
    }
}