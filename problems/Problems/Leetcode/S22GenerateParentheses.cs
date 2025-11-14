using System.Text;

namespace Problems.Leetcode;

/// <summary>+
/// https://leetcode.com/problems/generate-parentheses/
/// </summary>
public class S22GenerateParentheses
{
    public IList<string> GenerateParenthesis(int n)
    {
        var result = new List<string>();
        var sb = new StringBuilder();
        
        Backtrack(result, sb, 0, 0, n);
        
        return result;
    }

    private void Backtrack(List<string> result, StringBuilder sb, int open, int close, int n)
    {
        if (sb.Length == n * 2)
        {
            result.Add(sb.ToString());
            return;
        }

        if (open < n)
        {
            sb.Append('(');
            Backtrack(result, sb, open + 1, close, n);
            sb.Length--;
        }

        if (close < open)
        {
            sb.Append(')');
            Backtrack(result, sb, open, close + 1, n);
            sb.Length--;
        }
    }
}
