#include<iostream>
#include<vector>

using namespace std;


class Solution {
public:
    vector<int> productExceptSelf(vector<int>& nums) {
        int n = nums.size();
        vector<int> result(n,1);
        

        int leftP = 1;
        for (int i = 0; i < n; i++)
        {
            result[i] = leftP;
            leftP *= nums[i];
        
        }
        int rightP = 1;
        for (int i =n-1; i >=0 ; i--)
        {
            result[i] *= rightP;
            rightP *= nums[i];


        }

        return result;



    }
};


int main()
{


}