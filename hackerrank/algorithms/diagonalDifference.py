# https://www.hackerrank.com/challenges/diagonal-difference/problem?isFullScreen=true

def diagonalDifference(arr):
    length = len(arr)
    result = 0
    for i in range(0, length):
        result = result + (arr[i][i] - arr[i][length-1-i])
    return abs(result)
        
arr = [[11, 2, 4], [4, 5, 6], [10, 8, -12]]
print(diagonalDifference(arr))