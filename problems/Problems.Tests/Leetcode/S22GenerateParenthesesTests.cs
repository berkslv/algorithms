using Problems.Leetcode;
using Xunit;

namespace Problems.Tests.Leetcode;

public class S22GenerateParenthesesTests
{
    [Fact]
    public void Test_GenerateParenthesis_N1()
    {
        var solution = new S22GenerateParentheses();
        var result = solution.GenerateParenthesis(1);
        Assert.Equal(new[] { "()" }, result);
    }

    [Fact]
    public void Test_GenerateParenthesis_N3()
    {
        var solution = new S22GenerateParentheses();
        var result = solution.GenerateParenthesis(3);
        var expected = new[] { "((()))", "(()())", "(())()", "()(())", "()()()" };
        Assert.Equal(expected.OrderBy(x => x), result.OrderBy(x => x));
    }
}
