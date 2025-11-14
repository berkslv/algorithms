using Problems.Leetcode;
using Xunit;

namespace Problems.Tests.Leetcode;

public class S150EvaluateReversePolishNotationTests
{
    [Theory]
    [InlineData(new[] { "2", "1", "+", "3", "*" }, 9)]
    [InlineData(new[] { "4", "13", "5", "/", "+" }, 6)]
    [InlineData(new[] { "10", "6", "9", "3", "+", "-11", "*", "/", "*", "17", "+", "5", "+" }, 22)]
    public void Test_EvalRPN(string[] tokens, int expected)
    {
        var solution = new S150EvaluateReversePolishNotation();
        var result = solution.EvalRPN(tokens);
        Assert.Equal(expected, result);
    }
}
