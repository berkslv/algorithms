namespace Problems;

/// <summary>
/// https://neetcode.io/problems/is-palindrome
/// </summary>
public class S150ValidPalindrome
{
    public bool IsPalindrome(string s)
    {
        for (int i = 0, j = s.Length - 1; i < j;)
        {
            var left = s[i];
            if (!char.IsLetterOrDigit(left))
            {
                i++;
                continue;
            }

            var right = s[j];
            if (!char.IsLetterOrDigit(right))
            {
                j--;
                continue;
            }

            if (char.ToLower(left) != char.ToLower(right))
            {
                return false;
            }

            i++;
            j--;
        }

        return true;
    }
}