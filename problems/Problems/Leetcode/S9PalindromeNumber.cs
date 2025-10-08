namespace Problems.Leetcode;

/// <summary>+
/// https://leetcode.com/problems/palindrome-number/
/// </summary>
public class S9PalindromeNumber
{
    public bool IsPalindrome(int x)
    {
        // Negative numbers are not palindromes
        if (x < 0) return false;
        
        // Single digit numbers are palindromes
        if (x < 10) return true;
        
        // Numbers ending in 0 (except 0 itself) are not palindromes
        if (x % 10 == 0) return false;
        
        var reversed = 0;
        var original = x;
        
        // Only reverse half of the number to avoid overflow
        while (x > reversed)
        {
            reversed = reversed * 10 + x % 10;
            x /= 10;
        }
        
        // For even number of digits: x == reversed
        // For odd number of digits: x == reversed / 10 (middle digit doesn't matter)
        return x == reversed || x == reversed / 10;
    }
}