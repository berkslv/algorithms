# https://leetcode.com/problems/valid-sudoku/submissions/867589804/
from typing import List
from collections import defaultdict


class Solution:
    def isValidSudoku(self, board: List[List[str]]) -> bool:
        row_dict = defaultdict(set)
        col_dict = defaultdict(set)
        sec_dict = defaultdict(set)

        for i in range(9):
            for j in range(9):
                num = board[i][j]

                # continue if num equal to dot "."
                if not num.isdigit():
                    continue
                
                # get sector of number
                sec = (i // 3, j // 3)
                if num in row_dict[i] or num in col_dict[j] or num in sec_dict[sec]:
                    return False
                else:
                    row_dict[i].add(num)
                    col_dict[j].add(num)
                    sec_dict[sec].add(num)
        return True


# Test
board = [["5","3",".",".","7",".",".",".","."]
,["6",".",".","1","9","5",".",".","."]
,[".","9","8",".",".",".",".","6","."]
,["8",".",".",".","6",".",".",".","3"]
,["4",".",".","8",".","3",".",".","1"]
,["7",".",".",".","2",".",".",".","6"]
,[".","6",".",".",".",".","2","8","."]
,[".",".",".","4","1","9",".",".","5"]
,[".",".",".",".","8",".",".","7","9"]]
answer = Solution().isValidSudoku(board)
print(" board: ", board, "\n answer: ", answer)
