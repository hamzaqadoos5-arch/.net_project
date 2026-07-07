#include<iostream>
#include<stack>
#include<string>
#include<deque>

using namespace std;


class Solution {
public:
    bool isValid(string s) {
        stack<char> value ;
        for (char i :s)
        {
            if (i=='('|| i == '{'|| i == '[')
            {
                value.push(i);
            }
            else
            {
                if (value.empty()) return false;
                char top = value.top();

                if (i == ')' && top == '(' ||
                    i == ']' && top == '[' ||
                    i == '}' && top == '{')
                    
                {
                    value.pop();

                }
                else
                {
                    return false;

                }
            }
        
        }
        return true ? value.empty() : false;
    
    }
};



int main()
{

    Solution a;
    cout<<a.isValid("[({[})]]");


}