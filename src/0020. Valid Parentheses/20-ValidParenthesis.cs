public class Solution {

    Stack<char> brackets = new Stack<char>();

    public bool IsValid(string s) {
        if(s.Length % 2 != 0)
            return false;

        //char prevChar = '`';
        //bool initMatch = true;

        foreach(var ch in s)
        {
            if(ch == '(' || ch == '{' || ch == '[')
                brackets.Push(ch);
            else
            {
                // means corresponding left braket is not exists
                if(brackets.Count <= 0)
                    return false;
                
                char leftBracket = brackets.Pop();
                if(leftBracket == '(' && ch == ')')
                    continue;
                else if(leftBracket == '{' && ch == '}')
                    continue;
                else if(leftBracket == '[' && ch == ']')
                    continue;
                else
                    return false;
            }
        }
        
        // stack should be empty
        // make sure all bracket checked
        if(brackets.Count == 0)
            return true;
        else
            return false;
    }
}

/*
Test cases
Example 1:
Input: s = "()"
Output: true

Example 2:
Input: s = "()[]{}"
Output: true

Example 3:
Input: s = "(]"
Output: false

*/