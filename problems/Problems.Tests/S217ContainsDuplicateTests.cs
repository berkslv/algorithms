namespace Problems.Tests;

public class S217ContainsDuplicateTests
{
    [Fact]
    public void ContainsDuplicate_WhenEmpty_ReturnsFalse()
    {
        var s217 = new S217ContainsDuplicate();
        var result = s217.ContainsDuplicate(Array.Empty<int>());
        Assert.False(result);
    }

    [Fact]
    public void ContainsDuplicate_WhenSingle_ReturnsFalse()
    {
        var s217 = new S217ContainsDuplicate();
        var result = s217.ContainsDuplicate(new[] { 1 });
        Assert.False(result);
    }

    [Fact]
    public void ContainsDuplicate_WhenTwoDifferent_ReturnsFalse()
    {
        var s217 = new S217ContainsDuplicate();
        var result = s217.ContainsDuplicate(new[] { 1, 2 });
        Assert.False(result);
    }

    [Fact]
    public void ContainsDuplicate_WhenTwoSame_ReturnsTrue()
    {
        var s217 = new S217ContainsDuplicate();
        var result = s217.ContainsDuplicate(new[] { 1, 1 });
        Assert.True(result);
    }

    [Fact]
    public void ContainsDuplicate_WhenThreeDifferent_ReturnsFalse()
    {
        var s217 = new S217ContainsDuplicate();
        var result = s217.ContainsDuplicate(new[] { 1, 2, 3 });
        Assert.False(result);
    }

    [Fact]
    public void ContainsDuplicate_WhenThreeSame_ReturnsTrue()
    {
        var s217 = new S217ContainsDuplicate();
        var result = s217.ContainsDuplicate(new[] { 1, 1, 1 });
        Assert.True(result);
    }

    [Fact]
    public void ContainsDuplicate_WhenThreeWithDuplicate_ReturnsTrue()
    {
        var s217 = new S217ContainsDuplicate();
        var result = s217.ContainsDuplicate(new[] { 1, 2, 1 });
        Assert.True(result);
    }

    [Fact]
    public void ContainsDuplicate_WhenFourDifferent_ReturnsFalse()
    {
        var s217 = new S217ContainsDuplicate();
        var result = s217.ContainsDuplicate(new[] { 1, 2, 3, 4 });
        Assert.False(result);
    }

    [Fact]
    public void ContainsDuplicate_WhenFourWithDuplicate_ReturnsTrue()
    {
        var s217 = new S217ContainsDuplicate();
        var result = s217.ContainsDuplicate(new[] { 1, 2, 3, 1 });
        Assert.True(result);
    }
}