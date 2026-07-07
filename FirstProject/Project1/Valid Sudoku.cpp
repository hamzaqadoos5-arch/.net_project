#include<iostream>
#include<vector>
#include<map>
#include<set>

using namespace std;

class Solution {
private:
    bool checkRow(int row, vector<vector<char>>& board)
    {
        set<char> onc;
        for (int col = 0; col < 9; col++)
        {
            char cell = board[row][col];
            if (cell != '.')
            {
                if (onc.find(cell) != onc.end())
                {
                    return false;
                }
                onc.insert(cell);
            }


        }
    }
    bool checkColumn(int col,vector<vector<char>>& board)
    {
        map<char, int>onc;
        for (int row = 0; row < 9; row++)
        {
            char cell = board[row][col];
            if (cell != '.')
            {
                if (onc[cell]>1)
                {
                    return false;
                }
                onc[cell]++;
            }


        }





    }
    vector<vector<char>> getAllBox(vector<vector<char>>& board)
    {
        vector<vector<char>> boxes;
    
        for (int boxrow = 0; boxrow < 3; boxrow++)
        {
            for (int boxcol = 0; boxcol < 3; boxcol++)
            {
                int startrow = boxrow * 3, startcol = boxcol * 3;
                vector<char>box;
                for (int i = startrow; i < startrow + 3; i++)
                {
                    for (int j = startcol; j < startcol + 3; j++)
                    {
                        box.push_back(board[i][j]);
                    }


                }
                boxes.push_back(box);

            }
        }
        return boxes;
    }
        
    bool checkox(vector<char>& box)
    {
        map<char, int>onc;
        for (int row = 0; row < 9; row++)
        {
            char cell =box[row];
            if (cell != '.')
            {
                if (onc[cell] > 1)
                {
                    return false;
                }
                onc[cell]++;
            }


        }
    }
public:
    bool isValidSudoku(vector<vector<char>>& board) {
    for (int row = 0; row < 9; row++)
    {
            if (!checkRow(row,board))
                return false;
    }
    
     for (int col = 0; col < 9; col++)
    { 
        if (!checkColumn(col,board))
            return false;
    }
     vector<vector<char>>boxes = getAllBox(board);
     for (int i = 0; i < boxes.size(); i++)
     {
         if (!checkox(boxes[i]))
         {
             return false;
         }


     }
     return true;


}
    
};

