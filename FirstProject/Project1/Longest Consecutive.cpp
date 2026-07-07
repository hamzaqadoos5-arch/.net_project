#include<iostream>
#include<vector>
#include<unordered_set>

using namespace std;

class Solution {
public:
    int longestConsecutive(vector<int>& nums) {
        unordered_set<int> values(nums.begin(),nums.end());
        int longest=0;
        for (const auto& i:nums)
        {
            if (values.find(i - 1) == values.end())
            {
                int currentnum = i;
                int currentStreak = 1;
                while (values.find(currentnum + 1) != values.end()) {
                    currentnum += 1;
                    currentStreak += 1;
                }
                longest = max(longest, currentStreak);
            }
            
        }
       
        return longest;

        
    }

};

int main()
{
    vector<int> n = {2,20,4,10,3,4,5 };
    Solution a;
    cout<<a.longestConsecutive(n);


}