using System;
// you can also use other imports, for example:
// using System.Collections.Generic;

// you can write to stdout for debugging purposes, e.g.
// Console.WriteLine("this is a debug message");

class Solution 
{
    public int solution(int number) 
    {
        int max = 0;
        
        string[] tokens = Convert.ToString(number, 2).Split('1');
        
        for (int i=0; i<tokens.Length-1; i++)
        {
            if (tokens[i].Length > max) max = tokens[i].Length;
        }
        
        return max;
    }
}