public class Solution {
    public bool IsValidSudoku(char[][] board) {
         HashSet<string> seen = new HashSet<string>();

    for(int i = 0; i < 9; i++)
    {
        for(int j = 0; j < 9; j++)
        {
            char val = board[i][j];

            if(val == '.') continue;

            string rowKey = val + " in row " + i;
            string colKey = val + " in col " + j;
            string boxKey = val + " in box " + (i/3)*3 + (j/3);

            if(!seen.Add(rowKey) ||
               !seen.Add(colKey) ||
               !seen.Add(boxKey))
            {
                return false;
            }
        }
    }

    return true;
    }
}
