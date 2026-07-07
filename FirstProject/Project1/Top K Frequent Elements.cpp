#include<iostream>
#include<vector>
#include<unordered_map>
#include <queue>
using namespace std;
void printMap(unordered_map<int,int>groups)
{
	for (auto i : groups)
	{
		cout << i.first << " " << i.second << endl;
	}
}


class Solution {
public:
    vector<int> topKFrequent(vector<int>& nums, int k) {
        unordered_map<int, int> frequent_values;
        for (int i :nums)
        {
            frequent_values[i] +=1;
        }
        printMap(frequent_values);
        priority_queue<pair<int, int>> pq;

        for (auto const& val : frequent_values) {
            pq.push({ val.second,val.first });
        }
        vector<int> result;
        for (int i = 0; i < k; i++)
        {
            result.push_back(pq.top().second);
            pq.pop();

        }
        return result;







    }
     
};

int main()
{
    vector<int>nums = {1, 2, 2, 3, 3, 3};
    int k = 2;
    Solution a;
    vector<int >r=a.topKFrequent(nums, k);
    for (int i : r)
    {
        cout<<i << " ";
    }
}