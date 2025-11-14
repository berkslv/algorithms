namespace Problems.Leetcode;

/// <summary>+
/// https://leetcode.com/problems/binary-tree-preorder-traversal/
/// </summary>
public class S144BinaryTreePreorderTraversal
{
    public IList<int> PreorderTraversal(TreeNode? root)
    {
        var result = new List<int>();
        Preorder(root, result);
        return result;
    }

    private void Preorder(TreeNode? node, ICollection<int> result)
    {
        if (node == null)
        {
            return;
        }

        result.Add(node.val);
        Preorder(node.left, result);
        Preorder(node.right, result);
    }
}
