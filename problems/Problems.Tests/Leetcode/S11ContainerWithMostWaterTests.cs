using Problems.Leetcode;

namespace Problems.Tests.Leetcode;

public class S11ContainerWithMostWaterTests
{
    private readonly S11ContainerWithMostWater _solution = new S11ContainerWithMostWater();

    [Fact]
    public void MaxArea_Example1_ReturnsCorrectArea()
    {
        // Arrange
        int[] height = { 1, 8, 6, 2, 5, 4, 8, 3, 7 };

        // Act
        var result = _solution.MaxArea(height);

        // Assert
        Assert.Equal(49, result); // Between indices 1 and 8: min(8,7) * (8-1) = 7 * 7 = 49
    }

    [Fact]
    public void MaxArea_Example2_ReturnsCorrectArea()
    {
        // Arrange
        int[] height = { 1, 1 };

        // Act
        var result = _solution.MaxArea(height);

        // Assert
        Assert.Equal(1, result); // min(1,1) * (1-0) = 1 * 1 = 1
    }

    [Fact]
    public void MaxArea_TwoTallLines_ReturnsCorrectArea()
    {
        // Arrange
        int[] height = { 2, 1, 2 };

        // Act
        var result = _solution.MaxArea(height);

        // Assert
        Assert.Equal(4, result); // Between indices 0 and 2: min(2,2) * (2-0) = 2 * 2 = 4
    }

    [Fact]
    public void MaxArea_IncreasingHeight_ReturnsCorrectArea()
    {
        // Arrange
        int[] height = { 1, 2, 3, 4, 5 };

        // Act
        var result = _solution.MaxArea(height);

        // Assert
        Assert.Equal(6, result); // Between indices 1 and 4: min(2,5) * (4-1) = 2 * 3 = 6
    }

    [Fact]
    public void MaxArea_DecreasingHeight_ReturnsCorrectArea()
    {
        // Arrange
        int[] height = { 5, 4, 3, 2, 1 };

        // Act
        var result = _solution.MaxArea(height);

        // Assert
        Assert.Equal(6, result); // Between indices 0 and 3: min(5,2) * (3-0) = 2 * 3 = 6
    }

    [Fact]
    public void MaxArea_AllSameHeight_ReturnsCorrectArea()
    {
        // Arrange
        int[] height = { 3, 3, 3, 3 };

        // Act
        var result = _solution.MaxArea(height);

        // Assert
        Assert.Equal(9, result); // Between indices 0 and 3: min(3,3) * (3-0) = 3 * 3 = 9
    }

    [Fact]
    public void MaxArea_SinglePeak_ReturnsCorrectArea()
    {
        // Arrange
        int[] height = { 1, 1000, 1 };

        // Act
        var result = _solution.MaxArea(height);

        // Assert
        Assert.Equal(2, result); // Between indices 0 and 2: min(1,1) * (2-0) = 1 * 2 = 2
    }
}