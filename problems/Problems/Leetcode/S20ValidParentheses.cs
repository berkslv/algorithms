namespace Problems.Leetcode;

/// <summary>+
/// https://leetcode.com/problems/valid-parentheses/
/// </summary>
public class S20ValidParentheses
{
    public bool IsValid(string s)
    {
        var stack = new Stack<char>();
        var mapping = new Dictionary<char, char>
        {
            { ')', '(' },
            { '}', '{' },
            { ']', '[' }
        };
        
        foreach (var c in s)
        {
            if (mapping.ContainsKey(c)) // Closing bracket
            {
                if (stack.Count == 0 || stack.Pop() != mapping[c])
                {
                    return false;
                }
            }
            else // Opening bracket
            {
                stack.Push(c);
            }
        }
        
        return stack.Count == 0;
    }
}