using Problems.Leetcode;
using Xunit;

namespace Problems.Tests.Leetcode;

public class S111MinimumDepthOfBinaryTreeTests
{
    [Fact]
    public void Test_MinDepth_Example1()
    {
        var solution = new S111MinimumDepthOfBinaryTree();
        var root = new TreeNode(3, new TreeNode(9), new TreeNode(20, new TreeNode(15), new TreeNode(7)));
        var result = solution.MinDepth(root);
        Assert.Equal(2, result);
    }

    [Fact]
    public void Test_MinDepth_Example2()
    {
        var solution = new S111MinimumDepthOfBinaryTree();
        var root = new TreeNode(2, null, new TreeNode(3, null, new TreeNode(4, null, new TreeNode(5, null, new TreeNode(6)))));
        var result = solution.MinDepth(root);
        Assert.Equal(5, result);
    }

    [Fact]
    public void Test_MinDepth_NullRoot()
    {
        var solution = new S111MinimumDepthOfBinaryTree();
        var result = solution.MinDepth(null);
        Assert.Equal(0, result);
    }

    [Fact]
    public void Test_MinDepth_SingleNode()
    {
        var solution = new S111MinimumDepthOfBinaryTree();
        var root = new TreeNode(1);
        var result = solution.MinDepth(root);
        Assert.Equal(1, result);
    }
}
