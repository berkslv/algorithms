using Problems.Leetcode;

namespace Problems.Tests.Leetcode;

public class S74SearchA2DMatrixTests
{
    private readonly S74SearchA2DMatrix _solution = new S74SearchA2DMatrix();

    [Fact]
    public void SearchMatrix_TargetExists_ReturnsTrue()
    {
        // Arrange
        int[][] matrix = {
            new int[] { 1, 3, 5, 7 },
            new int[] { 10, 11, 16, 20 },
            new int[] { 23, 30, 34, 60 }
        };
        int target = 3;

        // Act
        var result = _solution.SearchMatrix(matrix, target);

        // Assert
        Assert.True(result);
    }

    [Fact]
    public void SearchMatrix_TargetDoesNotExist_ReturnsFalse()
    {
        // Arrange
        int[][] matrix = {
            new int[] { 1, 3, 5, 7 },
            new int[] { 10, 11, 16, 20 },
            new int[] { 23, 30, 34, 60 }
        };
        int target = 13;

        // Act
        var result = _solution.SearchMatrix(matrix, target);

        // Assert
        Assert.False(result);
    }

    [Fact]
    public void SearchMatrix_SingleElement_TargetExists_ReturnsTrue()
    {
        // Arrange
        int[][] matrix = {
            new int[] { 1 }
        };
        int target = 1;

        // Act
        var result = _solution.SearchMatrix(matrix, target);

        // Assert
        Assert.True(result);
    }

    [Fact]
    public void SearchMatrix_SingleElement_TargetDoesNotExist_ReturnsFalse()
    {
        // Arrange
        int[][] matrix = {
            new int[] { 1 }
        };
        int target = 2;

        // Act
        var result = _solution.SearchMatrix(matrix, target);

        // Assert
        Assert.False(result);
    }

    [Fact]
    public void SearchMatrix_TargetAtBeginning_ReturnsTrue()
    {
        // Arrange
        int[][] matrix = {
            new int[] { 1, 3, 5, 7 },
            new int[] { 10, 11, 16, 20 },
            new int[] { 23, 30, 34, 60 }
        };
        int target = 1;

        // Act
        var result = _solution.SearchMatrix(matrix, target);

        // Assert
        Assert.True(result);
    }

    [Fact]
    public void SearchMatrix_TargetAtEnd_ReturnsTrue()
    {
        // Arrange
        int[][] matrix = {
            new int[] { 1, 3, 5, 7 },
            new int[] { 10, 11, 16, 20 },
            new int[] { 23, 30, 34, 60 }
        };
        int target = 60;

        // Act
        var result = _solution.SearchMatrix(matrix, target);

        // Assert
        Assert.True(result);
    }

    [Fact]
    public void SearchMatrix_TargetSmallerThanAll_ReturnsFalse()
    {
        // Arrange
        int[][] matrix = {
            new int[] { 1, 3, 5, 7 },
            new int[] { 10, 11, 16, 20 },
            new int[] { 23, 30, 34, 60 }
        };
        int target = 0;

        // Act
        var result = _solution.SearchMatrix(matrix, target);

        // Assert
        Assert.False(result);
    }

    [Fact]
    public void SearchMatrix_TargetLargerThanAll_ReturnsFalse()
    {
        // Arrange
        int[][] matrix = {
            new int[] { 1, 3, 5, 7 },
            new int[] { 10, 11, 16, 20 },
            new int[] { 23, 30, 34, 60 }
        };
        int target = 100;

        // Act
        var result = _solution.SearchMatrix(matrix, target);

        // Assert
        Assert.False(result);
    }

    [Fact]
    public void SearchMatrix_SingleRow_TargetExists_ReturnsTrue()
    {
        // Arrange
        int[][] matrix = {
            new int[] { 1, 3, 5, 7, 9, 11 }
        };
        int target = 5;

        // Act
        var result = _solution.SearchMatrix(matrix, target);

        // Assert
        Assert.True(result);
    }

    [Fact]
    public void SearchMatrix_SingleColumn_TargetExists_ReturnsTrue()
    {
        // Arrange
        int[][] matrix = {
            new int[] { 1 },
            new int[] { 3 },
            new int[] { 5 },
            new int[] { 7 }
        };
        int target = 5;

        // Act
        var result = _solution.SearchMatrix(matrix, target);

        // Assert
        Assert.True(result);
    }

    [Fact]
    public void SearchMatrix_EmptyMatrix_ReturnsFalse()
    {
        // Arrange
        int[][] matrix = { };
        int target = 1;

        // Act
        var result = _solution.SearchMatrix(matrix, target);

        // Assert
        Assert.False(result);
    }
}