using Problems.Leetcode;

namespace Problems.Tests.Leetcode;

public class S36ValidSudokuTests
{
    private readonly S36ValidSudoku _solution = new S36ValidSudoku();

    [Fact]
    public void IsValidSudoku_ValidBoard_ReturnsTrue()
    {
        // Arrange
        char[][] board = {
            new char[] {'5','3','.','.','7','.','.','.','.'},
            new char[] {'6','.','.','1','9','5','.','.','.'},
            new char[] {'.','9','8','.','.','.','.','6','.'},
            new char[] {'8','.','.','.','6','.','.','.','3'},
            new char[] {'4','.','.','8','.','3','.','.','1'},
            new char[] {'7','.','.','.','2','.','.','.','6'},
            new char[] {'.','6','.','.','.','.','2','8','.'},
            new char[] {'.','.','.','4','1','9','.','.','5'},
            new char[] {'.','.','.','.','8','.','.','7','9'}
        };

        // Act
        var result = _solution.IsValidSudoku(board);

        // Assert
        Assert.True(result);
    }

    [Fact]
    public void IsValidSudoku_InvalidBoard_ReturnsFalse()
    {
        // Arrange - Same as valid board but with 5 changed to 8 in top-left corner
        char[][] board = {
            new char[] {'8','3','.','.','7','.','.','.','.'},
            new char[] {'6','.','.','1','9','5','.','.','.'},
            new char[] {'.','9','8','.','.','.','.','6','.'},
            new char[] {'8','.','.','.','6','.','.','.','3'},
            new char[] {'4','.','.','8','.','3','.','.','1'},
            new char[] {'7','.','.','.','2','.','.','.','6'},
            new char[] {'.','6','.','.','.','.','2','8','.'},
            new char[] {'.','.','.','4','1','9','.','.','5'},
            new char[] {'.','.','.','.','8','.','.','7','9'}
        };

        // Act
        var result = _solution.IsValidSudoku(board);

        // Assert
        Assert.False(result); // Two 8's in the same 3x3 box
    }

    [Fact]
    public void IsValidSudoku_EmptyBoard_ReturnsTrue()
    {
        // Arrange
        char[][] board = {
            new char[] {'.','.','.','.','.','.','.','.','.'},
            new char[] {'.','.','.','.','.','.','.','.','.'},
            new char[] {'.','.','.','.','.','.','.','.','.'},
            new char[] {'.','.','.','.','.','.','.','.','.'},
            new char[] {'.','.','.','.','.','.','.','.','.'},
            new char[] {'.','.','.','.','.','.','.','.','.'},
            new char[] {'.','.','.','.','.','.','.','.','.'},
            new char[] {'.','.','.','.','.','.','.','.','.'},
            new char[] {'.','.','.','.','.','.','.','.','.'}
        };

        // Act
        var result = _solution.IsValidSudoku(board);

        // Assert
        Assert.True(result);
    }

    [Fact]
    public void IsValidSudoku_DuplicateInRow_ReturnsFalse()
    {
        // Arrange
        char[][] board = {
            new char[] {'1','2','3','4','5','6','7','8','1'}, // Duplicate 1 in row
            new char[] {'.','.','.','.','.','.','.','.','.'},
            new char[] {'.','.','.','.','.','.','.','.','.'},
            new char[] {'.','.','.','.','.','.','.','.','.'},
            new char[] {'.','.','.','.','.','.','.','.','.'},
            new char[] {'.','.','.','.','.','.','.','.','.'},
            new char[] {'.','.','.','.','.','.','.','.','.'},
            new char[] {'.','.','.','.','.','.','.','.','.'},
            new char[] {'.','.','.','.','.','.','.','.','.'}
        };

        // Act
        var result = _solution.IsValidSudoku(board);

        // Assert
        Assert.False(result);
    }

    [Fact]
    public void IsValidSudoku_DuplicateInColumn_ReturnsFalse()
    {
        // Arrange
        char[][] board = {
            new char[] {'1','.','.','.','.','.','.','.','.'},
            new char[] {'2','.','.','.','.','.','.','.','.'},
            new char[] {'3','.','.','.','.','.','.','.','.'},
            new char[] {'4','.','.','.','.','.','.','.','.'},
            new char[] {'5','.','.','.','.','.','.','.','.'},
            new char[] {'6','.','.','.','.','.','.','.','.'},
            new char[] {'7','.','.','.','.','.','.','.','.'},
            new char[] {'8','.','.','.','.','.','.','.','.'},
            new char[] {'1','.','.','.','.','.','.','.','.'}  // Duplicate 1 in column
        };

        // Act
        var result = _solution.IsValidSudoku(board);

        // Assert
        Assert.False(result);
    }

    [Fact]
    public void IsValidSudoku_SingleFilledCell_ReturnsTrue()
    {
        // Arrange
        char[][] board = {
            new char[] {'.','.','.','.','.','.','.','.','.'},
            new char[] {'.','.','.','.','.','.','.','.','.'},
            new char[] {'.','.','.','.','.','.','.','.','.'},
            new char[] {'.','.','.','.','.','.','.','.','.'},
            new char[] {'.','.','.','.','5','.','.','.','.'}, // Single filled cell
            new char[] {'.','.','.','.','.','.','.','.','.'},
            new char[] {'.','.','.','.','.','.','.','.','.'},
            new char[] {'.','.','.','.','.','.','.','.','.'},
            new char[] {'.','.','.','.','.','.','.','.','.'}
        };

        // Act
        var result = _solution.IsValidSudoku(board);

        // Assert
        Assert.True(result);
    }
}