#include<iostream>
#include<stack>
using namespace std;

class MinStack {
    stack<int>input_st;
    stack<int>min_st;
public:
    MinStack() {

    }

    void push(int val) {
        input_st.push(val);
        if (min_st.empty() || input_st.top() < min_st.top() || input_st.top() == min_st.top())
        {
            min_st.push(val);

        }

    }

    void pop() {
        if (input_st.top() == min_st.top())
        {
            min_st.pop();
        }
        input_st.pop();

    }

    int top() {
        return input_st.top();
    }

    int getMin() {
        return min_st.top();
    }
};

int main()
{
    MinStack minStack;
    minStack.push(1);
    minStack.push(2);
    minStack.push(0);
    cout<<minStack.getMin(); // return 0
    minStack.pop();
    cout<<minStack.top();    // return 2
    cout<<minStack.getMin(); // return 1


}