using Problems.Leetcode;

namespace Problems.Tests;

public class S2LengthOfLongestSubstringTests
{
    [Fact]
    public void Test_LengthOfLongestSubstring_Example1()
    {
        var solution = new S2LengthOfLongestSubstring();
        string s = "abcabcbb";
        int expected = 3;
        int result = solution.LengthOfLongestSubstring(s);
        Assert.Equal(expected, result);
    }

    [Fact]
    public void Test_LengthOfLongestSubstring_Example2()
    {
        var solution = new S2LengthOfLongestSubstring();
        string s = "bbbbb";
        int expected = 1;
        int result = solution.LengthOfLongestSubstring(s);
        Assert.Equal(expected, result);
    }

    [Fact]
    public void Test_LengthOfLongestSubstring_Example3()
    {
        var solution = new S2LengthOfLongestSubstring();
        string s = "pwwkew";
        int expected = 3;
        int result = solution.LengthOfLongestSubstring(s);
        Assert.Equal(expected, result);
    }

    [Fact]
    public void Test_LengthOfLongestSubstring_EmptyString()
    {
        var solution = new S2LengthOfLongestSubstring();
        string s = "";
        int expected = 0;
        int result = solution.LengthOfLongestSubstring(s);
        Assert.Equal(expected, result);
    }

    [Fact]
    public void Test_LengthOfLongestSubstring_AllUniqueCharacters()
    {
        var solution = new S2LengthOfLongestSubstring();
        string s = "abcdef";
        int expected = 6;
        int result = solution.LengthOfLongestSubstring(s);
        Assert.Equal(expected, result);
    }

    [Fact]
    public void Test_LengthOfLongestSubstring_MixedCharacters()
    {
        var solution = new S2LengthOfLongestSubstring();
        string s = "aababcabcdabcde";
        int expected = 5;
        int result = solution.LengthOfLongestSubstring(s);
        Assert.Equal(expected, result);
    }

    [Fact]
    public void Test_LengthOfLongestSubstring_LongString()
    {
        var solution = new S2LengthOfLongestSubstring();
        string s = new string('a', 10000) + "bcd" + new string('a', 10000);
        int expected = 4; // "bcda" is the longest substring without repeating characters
        int result = solution.LengthOfLongestSubstring(s);
        Assert.Equal(expected, result);
    }
}