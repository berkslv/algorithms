using Problems.Leetcode;

namespace Problems.Tests.Leetcode;

public class S20ValidParenthesesTests
{
    private readonly S20ValidParentheses _solution = new S20ValidParentheses();

    [Fact]
    public void IsValid_SimpleParentheses_ReturnsTrue()
    {
        // Arrange
        string s = "()";

        // Act
        var result = _solution.IsValid(s);

        // Assert
        Assert.True(result);
    }

    [Fact]
    public void IsValid_MultipleBracketTypes_ReturnsTrue()
    {
        // Arrange
        string s = "()[{}]";

        // Act
        var result = _solution.IsValid(s);

        // Assert
        Assert.True(result);
    }

    [Fact]
    public void IsValid_MismatchedBrackets_ReturnsFalse()
    {
        // Arrange
        string s = "(]";

        // Act
        var result = _solution.IsValid(s);

        // Assert
        Assert.False(result);
    }

    [Fact]
    public void IsValid_NestedBrackets_ReturnsTrue()
    {
        // Arrange
        string s = "([])";

        // Act
        var result = _solution.IsValid(s);

        // Assert
        Assert.True(result);
    }

    [Fact]
    public void IsValid_WrongOrder_ReturnsFalse()
    {
        // Arrange
        string s = "([)]";

        // Act
        var result = _solution.IsValid(s);

        // Assert
        Assert.False(result);
    }

    [Fact]
    public void IsValid_EmptyString_ReturnsTrue()
    {
        // Arrange
        string s = "";

        // Act
        var result = _solution.IsValid(s);

        // Assert
        Assert.True(result);
    }

    [Fact]
    public void IsValid_OnlyOpeningBrackets_ReturnsFalse()
    {
        // Arrange
        string s = "((([{";

        // Act
        var result = _solution.IsValid(s);

        // Assert
        Assert.False(result);
    }

    [Fact]
    public void IsValid_OnlyClosingBrackets_ReturnsFalse()
    {
        // Arrange
        string s = "}])";

        // Act
        var result = _solution.IsValid(s);

        // Assert
        Assert.False(result);
    }

    [Fact]
    public void IsValid_ComplexValidExpression_ReturnsTrue()
    {
        // Arrange
        string s = "{[()()]}";

        // Act
        var result = _solution.IsValid(s);

        // Assert
        Assert.True(result);
    }

    [Fact]
    public void IsValid_ComplexInvalidExpression_ReturnsFalse()
    {
        // Arrange
        string s = "{[(])}";

        // Act
        var result = _solution.IsValid(s);

        // Assert
        Assert.False(result);
    }

    [Fact]
    public void IsValid_SingleOpenBracket_ReturnsFalse()
    {
        // Arrange
        string s = "(";

        // Act
        var result = _solution.IsValid(s);

        // Assert
        Assert.False(result);
    }

    [Fact]
    public void IsValid_SingleCloseBracket_ReturnsFalse()
    {
        // Arrange
        string s = ")";

        // Act
        var result = _solution.IsValid(s);

        // Assert
        Assert.False(result);
    }
}