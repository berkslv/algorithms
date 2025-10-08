namespace Problems.Leetcode;

/// <summary>+
/// https://leetcode.com/problems/search-a-2d-matrix/
/// </summary>
public class S74SearchA2DMatrix
{
    public bool SearchMatrix(int[][] matrix, int target)
    {
        if (matrix.Length == 0 || matrix[0].Length == 0) return false;
        
        int rows = matrix.Length;
        int cols = matrix[0].Length;
        
        // Treat the 2D matrix as a sorted 1D array
        int left = 0;
        int right = rows * cols - 1;
        
        while (left <= right)
        {
            int mid = left + (right - left) / 2;
            
            // Convert 1D index to 2D coordinates
            int midValue = matrix[mid / cols][mid % cols];
            
            if (midValue == target)
            {
                return true;
            }
            else if (midValue < target)
            {
                left = mid + 1;
            }
            else
            {
                right = mid - 1;
            }
        }
        
        return false;
    }
}