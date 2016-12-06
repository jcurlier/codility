using System;

// Test Cases
// (1,1,2) > 0
// (1,2,1) > 1
// (1,2,2) > 1
class Solution 
{
    public int solution(int X, int Y, int D) 
    {
        return (int) Math.Ceiling((double) (Y - X) / D);
    }
}

