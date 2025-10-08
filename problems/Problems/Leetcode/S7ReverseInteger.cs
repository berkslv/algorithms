namespace Problems.Leetcode;

/// <summary>+
/// https://leetcode.com/problems/reverse-integer/
/// </summary>
public class S7ReverseInteger
{
    public int Reverse(int x)
    {
        var result = 0;
        
        while (x != 0)
        {
            var pop = x % 10;
            x /= 10;
            
            // Check for overflow before multiplication
            if (result > int.MaxValue / 10 || (result == int.MaxValue / 10 && pop > 7))
                return 0;
            if (result < int.MinValue / 10 || (result == int.MinValue / 10 && pop < -8))
                return 0;
            
            result = result * 10 + pop;
        }
        
        return result;
    }
}