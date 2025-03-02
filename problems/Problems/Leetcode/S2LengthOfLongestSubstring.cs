namespace Problems.Leetcode;

public class S2LengthOfLongestSubstring
{
    public int LengthOfLongestSubstring(string s)
    {
        var list = s.ToList();
        var set = new HashSet<char>();
        var result = 0;
        
        for (int i = 0; i < list.Count; i++)
        {
            var first = list[i];

            set.Add(first);

            for (int j = i + 1; j < list.Count; j++)
            {
                var second = list[j];
                if (!set.Add(second))
                {
                    break;
                }
                
            }
            
            var count = set.Count;
            if (count > result)
            {
                result = count;
            }
            
            set.Clear();
        }

        return result;
    }
}