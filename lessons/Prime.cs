using System;
using System.Collections.Generic;
using static System.Math;
using static System.Console;

/// Test cases: 1,2,3,4,5,6,2147483647
class Solution 
{
    /// <summary>calucalate number of factors</summary?
    /// <param name="N">integer in the range 1..Int.MaxValue]</param>
    /// <returns>number of factors</returns>
    public int solution(int n) 
    {
        int count = 0;
        int i = 1;
        double s = Sqrt(n);
        
        while (i<s) 
        {
            if (n % i == 0) count = count + 2; 
            i++;
        }
        
        if (i*i==n) count++;
        
        return count;
    }
}