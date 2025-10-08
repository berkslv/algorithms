namespace Problems.Leetcode;

/// <summary>+
/// https://leetcode.com/problems/longest-common-prefix/
/// </summary>
public class S14LongestCommonPrefix
{
    public string LongestCommonPrefix(string[] strs)
    {
        if (strs.Length == 0) return "";
        if (strs.Length == 1) return strs[0];
        
        // Start with the first string as the prefix
        var prefix = strs[0];
        
        // Compare with each subsequent string
        for (int i = 1; i < strs.Length; i++)
        {
            // Find common prefix between current prefix and current string
            while (!strs[i].StartsWith(prefix))
            {
                // Reduce prefix by one character from the end
                prefix = prefix[..^1];
                
                // If prefix becomes empty, no common prefix exists
                if (prefix.Length == 0) return "";
            }
        }
        
        return prefix;
    }
}