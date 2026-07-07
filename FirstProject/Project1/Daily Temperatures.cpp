#include<iostream>
#include<vector>
#include<stack>

using namespace std;

class Solution {
public:
    vector<int> dailyTemperatures(vector<int>& temperatures) {
        stack< pair<int,int> >valus;
        vector<int>result(temperatures.size());
        for (int i=0;i<temperatures.size();i++)
        {
            while (!valus.empty() && temperatures[i] > valus.top().first)
            {

                int p = valus.top().second;
                result[p] = i - p;
                valus.pop();


            }
            valus.push({ temperatures[i],i });


        }
        return result;
    
    
    }
};


int main()
{
    vector<int> values = { 30,38,30,36,35,40,28 };
    Solution a;
    a.dailyTemperatures(values);


}