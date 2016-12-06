using System;
using System.Collections.Generic;

class Solution 
{
    public int solution(string S) 
    {
        Stack<char> stack = new Stack<char>();
        
        foreach (char c in S.ToCharArray())
        {
            if (c == '{' || c == '(' || c == '[')
            {
                stack.Push(c);   
            }
            else 
            {
                if (stack.Count == 0) return 0;
                
                char popc = stack.Pop();
                if (!((popc == '{' && c == '}') 
                        || (popc == '(' && c == ')')
                        || (popc == '[' && c == ']')))  return 0;
            }
            
        }
        
        if (stack.Count == 0) return 1;
        
        return 0;
    }
}