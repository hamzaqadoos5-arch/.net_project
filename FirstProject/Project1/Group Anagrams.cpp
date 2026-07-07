#include<iostream>
#include<vector>
#include<string>
#include<unordered_map>
#include<algorithm>

using namespace std;

void printMap(unordered_map<string, vector<string>> groups)
{
    for (const auto& pair : groups)
    {
        cout << "[" << pair.first << "]:";

        cout << "{";
        for (string w : pair.second)
        {
            cout << w << ",";
        }
        cout << "}"<<endl;

    }
}



class Solution {
public:
    vector<vector<string>> groupAnagrams(vector<string>& strs) {
        unordered_map<string, vector<string>> groups;
        for (string s:strs)
        {
            string sorted_s = s;
            sort(sorted_s.begin(), sorted_s.end());
            groups[sorted_s].push_back(s);
        }
        cout << "********************\n";
        printMap(groups);
      



        vector<vector<string>>result;
        for (const auto& pair : groups)
        {
            result.push_back(pair.second);
        }
        return result;


    }
};
int main()
{

    vector<string>  strs = { "act", "pots", "tops", "cat", "stop", "hat" };
    Solution a;
    vector<vector<string>>p= a.groupAnagrams(strs);
    cout << "{ ";
    for (int i=0;i<p.size();i++)
    {
        cout << "{";
        for (string world : p[i])
        {
            cout << world<<",";
        }
        cout << "},";


    }


}