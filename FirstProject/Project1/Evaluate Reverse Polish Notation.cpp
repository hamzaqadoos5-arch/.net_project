#include<iostream>
#include<stack>
#include<vector>
#include <string>

using namespace std;

class Solution {
public:
    int evalRPN(vector<string>& tokens) {
        stack<int> values;
        for (const auto &x : tokens)
        {
            if (x == "+" || x == "-" || x == "/" || x == "*")
            {
                int a = values.top();
                values.pop();
                int b = values.top();
                values.pop();
                if (x == "+")
                {
                    values.push(b + a);
                }
                else if (x == "-")
                {
                    values.push(b - a);
                }
                else if (x == "*")
                {
                    values.push(b * a);

                }
                else
                {
                    values.push(b / a);
                }



            }
            else
                values.push(stoi(x));

        }

        return values.top();

    }
};


int main()
{
    vector<string>tokens = {"1", "2", "+", "3", "*", "4", "-"};

    Solution a;
    cout<<a.evalRPN(tokens);

}