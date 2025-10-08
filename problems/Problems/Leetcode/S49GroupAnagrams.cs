namespace Problems.Leetcode;

/// <summary>+
/// https://leetcode.com/problems/group-anagrams/
/// </summary>
public class S49GroupAnagrams
{
    public IList<IList<string>> GroupAnagrams(string[] strs)
    {
        var groups = new Dictionary<string, IList<string>>();
        
        foreach (var str in strs)
        {
            // Sort characters to create a key for anagrams
            var sortedChars = str.ToCharArray();
            Array.Sort(sortedChars);
            var key = new string(sortedChars);
            
            if (!groups.ContainsKey(key))
            {
                groups[key] = new List<string>();
            }
            
            groups[key].Add(str);
        }
        
        return groups.Values.ToList();
    }
}