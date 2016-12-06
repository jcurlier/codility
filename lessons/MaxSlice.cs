using System;
// https://codesays.com/2014/solution-to-min-avg-two-slice-by-codility/
// you can also use other imports, for example:
// using System.Collections.Generic;

// you can write to stdout for debugging purposes, e.g.
// Console.WriteLine("this is a debug message");
// [-3, -5, -8, -4, -10] > 2
// [a b c d] (a+b+c+d)/4 a+b/2 c+d/2    1 6 2 3 = 3 
//
class Solution 
{
    public int solution(int[] A) 
    {
        int minPos = 0;
            
        int N = A.Length;

        double minVal = double.MaxValue;        
        double val;
        
        for (int i=0; i<N-1; i++)
        {
            val = (double) (A[i] + A[i+1]) / 2;
            if (val < minVal) 
            {
                minVal = val;
                minPos = i;
            } 
        }
	
        for (int i=0; i<N-2; i++) 
        {
            val = (double) (A[i] + A[i+1] + A[i+2]) / 3;
            if (val < minVal) 
            {
                minVal = val;
                minPos = i;
            }
        }

        return minPos;
    }
}