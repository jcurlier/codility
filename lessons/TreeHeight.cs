using System;
// you can also use other imports, for example:
// using System.Collections.Generic;

// you can write to stdout for debugging purposes, e.g.
// Console.WriteLine("this is a debug message");

class Solution 
{
    public int solution(Tree T) 
    {
        if (T == null) return 0;
        return Math.Max(getDepth(T.l), getDepth(T.r));
    }

  	public int getDepth(Tree T)
    {
        if (T == null) return 0;

        int left = getDepth(T.l);
        int right = getDepth(T.r);
        
        return Math.Max(left, right) + 1;
    }
}