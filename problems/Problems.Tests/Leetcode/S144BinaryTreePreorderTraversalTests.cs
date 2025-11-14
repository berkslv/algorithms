using Problems.Leetcode;
using Xunit;

namespace Problems.Tests.Leetcode;

public class S144BinaryTreePreorderTraversalTests
{
    [Fact]
    public void Test_PreorderTraversal_Example1()
    {
        var solution = new S144BinaryTreePreorderTraversal();
        var root = new TreeNode(1, null, new TreeNode(2, new TreeNode(3)));
        var result = solution.PreorderTraversal(root);
        Assert.Equal(new[] { 1, 2, 3 }, result);
    }

    [Fact]
    public void Test_PreorderTraversal_Empty()
    {
        var solution = new S144BinaryTreePreorderTraversal();
        var result = solution.PreorderTraversal(null);
        Assert.Empty(result);
    }

    [Fact]
    public void Test_PreorderTraversal_SingleNode()
    {
        var solution = new S144BinaryTreePreorderTraversal();
        var root = new TreeNode(1);
        var result = solution.PreorderTraversal(root);
        Assert.Equal(new[] { 1 }, result);
    }
}
