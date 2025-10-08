namespace Problems.Leetcode;

/// <summary>+
/// https://leetcode.com/problems/roman-to-integer/
/// </summary>
public class S13RomanToInteger
{
    public int RomanToInt(string s)
    {
        var romanValues = new Dictionary<char, int>
        {
            { 'I', 1 },
            { 'V', 5 },
            { 'X', 10 },
            { 'L', 50 },
            { 'C', 100 },
            { 'D', 500 },
            { 'M', 1000 }
        };
        
        var result = 0;
        var prevValue = 0;
        
        // Process from right to left
        for (int i = s.Length - 1; i >= 0; i--)
        {
            var currentValue = romanValues[s[i]];
            
            // If current value is less than previous, we subtract (e.g., IV = 5 - 1 = 4)
            if (currentValue < prevValue)
            {
                result -= currentValue;
            }
            else
            {
                result += currentValue;
            }
            
            prevValue = currentValue;
        }
        
        return result;
    }
}