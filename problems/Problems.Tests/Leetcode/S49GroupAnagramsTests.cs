using Problems.Leetcode;

namespace Problems.Tests.Leetcode;

public class S49GroupAnagramsTests
{
    private readonly S49GroupAnagrams _solution = new S49GroupAnagrams();

    [Fact]
    public void GroupAnagrams_Example1_ReturnsCorrectGroups()
    {
        // Arrange
        string[] strs = { "eat", "tea", "tan", "ate", "nat", "bat" };

        // Act
        var result = _solution.GroupAnagrams(strs);

        // Assert
        Assert.Equal(3, result.Count); // Should have 3 groups
        
        // Find groups by checking if they contain specific words
        var batGroup = result.FirstOrDefault(group => group.Contains("bat"));
        var eatGroup = result.FirstOrDefault(group => group.Contains("eat"));
        var tanGroup = result.FirstOrDefault(group => group.Contains("tan"));
        
        Assert.NotNull(batGroup);
        Assert.NotNull(eatGroup);
        Assert.NotNull(tanGroup);
        
        Assert.Single(batGroup); // "bat" should be alone
        Assert.Contains("bat", batGroup);
        
        Assert.Equal(3, eatGroup.Count); // "eat", "tea", "ate" group
        Assert.Contains("eat", eatGroup);
        Assert.Contains("tea", eatGroup);
        Assert.Contains("ate", eatGroup);
        
        Assert.Equal(2, tanGroup.Count); // "tan", "nat" group
        Assert.Contains("tan", tanGroup);
        Assert.Contains("nat", tanGroup);
    }

    [Fact]
    public void GroupAnagrams_EmptyString_ReturnsOneGroup()
    {
        // Arrange
        string[] strs = { "" };

        // Act
        var result = _solution.GroupAnagrams(strs);

        // Assert
        Assert.Single(result);
        Assert.Single(result[0]);
        Assert.Equal("", result[0][0]);
    }

    [Fact]
    public void GroupAnagrams_SingleString_ReturnsOneGroup()
    {
        // Arrange
        string[] strs = { "a" };

        // Act
        var result = _solution.GroupAnagrams(strs);

        // Assert
        Assert.Single(result);
        Assert.Single(result[0]);
        Assert.Equal("a", result[0][0]);
    }

    [Fact]
    public void GroupAnagrams_NoAnagrams_ReturnsIndividualGroups()
    {
        // Arrange
        string[] strs = { "abc", "def", "ghi" };

        // Act
        var result = _solution.GroupAnagrams(strs);

        // Assert
        Assert.Equal(3, result.Count); // Each string should be in its own group
        
        foreach (var group in result)
        {
            Assert.Single(group);
        }
    }

    [Fact]
    public void GroupAnagrams_AllSameAnagrams_ReturnsOneGroup()
    {
        // Arrange
        string[] strs = { "abc", "bca", "cab", "acb" };

        // Act
        var result = _solution.GroupAnagrams(strs);

        // Assert
        Assert.Single(result); // All should be in one group
        Assert.Equal(4, result[0].Count);
        
        foreach (var str in strs)
        {
            Assert.Contains(str, result[0]);
        }
    }

    [Fact]
    public void GroupAnagrams_MixedLengths_ReturnsCorrectGroups()
    {
        // Arrange
        string[] strs = { "a", "ab", "ba", "abc", "bca", "c" };

        // Act
        var result = _solution.GroupAnagrams(strs);

        // Assert
        Assert.Equal(4, result.Count); // "a", "c", {"ab","ba"}, {"abc","bca"}
        
        // Check that anagrams are grouped correctly
        var abGroup = result.FirstOrDefault(g => g.Contains("ab"));
        var abcGroup = result.FirstOrDefault(g => g.Contains("abc"));
        
        Assert.NotNull(abGroup);
        Assert.NotNull(abcGroup);
        
        Assert.Equal(2, abGroup.Count);
        Assert.Contains("ab", abGroup);
        Assert.Contains("ba", abGroup);
        
        Assert.Equal(2, abcGroup.Count);
        Assert.Contains("abc", abcGroup);
        Assert.Contains("bca", abcGroup);
    }

    [Fact]
    public void GroupAnagrams_SingleCharacterStrings_ReturnsCorrectGroups()
    {
        // Arrange
        string[] strs = { "a", "b", "a", "c", "b" };

        // Act
        var result = _solution.GroupAnagrams(strs);

        // Assert
        Assert.Equal(3, result.Count); // Three different characters
        
        var aGroup = result.FirstOrDefault(g => g.Contains("a"));
        var bGroup = result.FirstOrDefault(g => g.Contains("b"));
        var cGroup = result.FirstOrDefault(g => g.Contains("c"));
        
        Assert.NotNull(aGroup);
        Assert.NotNull(bGroup);
        Assert.NotNull(cGroup);
        
        Assert.Equal(2, aGroup.Count); // Two "a"s
        Assert.Equal(2, bGroup.Count); // Two "b"s
        Assert.Single(cGroup); // One "c"
    }
}