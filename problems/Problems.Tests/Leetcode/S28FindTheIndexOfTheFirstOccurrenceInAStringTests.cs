using Problems.Leetcode;
using Xunit;

namespace Problems.Tests.Leetcode;

public class S28FindTheIndexOfTheFirstOccurrenceInAStringTests
{
    [Theory]
    [InlineData("sadbutsad", "sad", 0)]
    [InlineData("leetcode", "leeto", -1)]
    [InlineData("hello", "ll", 2)]
    public void Test_StrStr(string haystack, string needle, int expected)
    {
        var solution = new S28FindTheIndexOfTheFirstOccurrenceInAString();
        var result = solution.StrStr(haystack, needle);
        Assert.Equal(expected, result);
    }
}
