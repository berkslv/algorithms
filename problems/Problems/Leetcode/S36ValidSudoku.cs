namespace Problems.Leetcode;

/// <summary>+
/// https://leetcode.com/problems/valid-sudoku/
/// </summary>
public class S36ValidSudoku
{
    public bool IsValidSudoku(char[][] board)
    {
        var rows = new HashSet<char>[9];
        var cols = new HashSet<char>[9];
        var boxes = new HashSet<char>[9];
        
        // Initialize hash sets
        for (int i = 0; i < 9; i++)
        {
            rows[i] = new HashSet<char>();
            cols[i] = new HashSet<char>();
            boxes[i] = new HashSet<char>();
        }
        
        for (int i = 0; i < 9; i++)
        {
            for (int j = 0; j < 9; j++)
            {
                var cell = board[i][j];
                if (cell == '.') continue;
                
                var boxIndex = (i / 3) * 3 + j / 3;
                
                // Check if digit already exists in row, column, or box
                if (!rows[i].Add(cell) || !cols[j].Add(cell) || !boxes[boxIndex].Add(cell))
                {
                    return false;
                }
            }
        }
        
        return true;
    }
}